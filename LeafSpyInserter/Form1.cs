using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeafSpyInserter
{
    public partial class Form1 : Form
    {
        // 挿入しないデータのカラム先頭
        public static readonly int REJECT_COLUMNS_START = 24;
        // 挿入しないデータのカラム末尾
        public static readonly int REJECT_COLUMNS_END = 119;
        // カラムの末尾
        public static readonly int END_OF_COLUMN = 158;

        // ファイルパス
        private String filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void startInsertingButton_Click(object sender, EventArgs e)
        {
            if (driverIDComboBox.SelectedIndex == -1)
            {
                errorCodeLabel.ForeColor = Color.Red;
                errorCodeLabel.Text = "Select Driver ID";
                return;
            } 

            if(carIDComboBox.SelectedIndex == -1)
            {
                errorCodeLabel.ForeColor = Color.Red;
                errorCodeLabel.Text = "Select Car ID";
                return;
            }
            if (SensorIdCombobox.SelectedIndex == -1)
            {
                errorCodeLabel.ForeColor = Color.Red;
                errorCodeLabel.Text = "Select Sensor ID";
                return;
            }

            if (filePath == null)
            {
                errorCodeLabel.ForeColor = Color.Red;
                errorCodeLabel.Text = "Select inserting file";
                return;
            }

            errorCodeLabel.ForeColor = Color.Blue;
            errorCodeLabel.Text = "Inserting start ...";

            int driverID = 0, carID = 0,sensorID = 0;
            bool nullAllowance;

            /**** Driver ID の決定 ****/
            switch(driverIDComboBox.SelectedIndex){
                case 0:
                    driverID = 1;
                    break;
                case 1:
                    driverID = 4;
                    break;
                case 2:
                    driverID = 16;
                    break;
            }

            /**** Car ID の決定 ****/
            switch(carIDComboBox.SelectedIndex){
                case 0:
                    carID = 3;
                    break;
                case 1:
                    carID = 8;
                    break;
            }
            switch (SensorIdCombobox.SelectedIndex)
            {
                case 0:
                    sensorID = 12;
                    break;
                case 1:
                    sensorID = 16;
                    break;
                case 2:
                    sensorID = 26;
                    break;
            }

            /**** Trip ID のNullの許容の確認 ****/
            nullAllowance = this.nullAllowanceCheckBox.Checked;

            Console.WriteLine("Driver ID : " + driverID + ", Car ID : " + carID + ", NullAllowance : " + nullAllowance);
            insertData(this.filePath, driverID, carID, sensorID, nullAllowance);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // ファイルが渡されていなければ、何もしない
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            // 渡されたファイルに対して処理を行う
            foreach (var filePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                fileNameLabel.Text = filePath;
                this.filePath = filePath;
            }
        }

        private void insertData(String filePath, int driverID, int carID,int sensorID, bool nullAllowance)
        {

            DataTable TRIPS_TABLE = new DataTable();

            /***** LeafSpyファイルの読み込み Start *****/
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            //エクセルを非表示
            ExcelApp.Visible = false;
            //エクセルファイルのオープン
            Microsoft.Office.Interop.Excel.Workbooks WorkBooks = ExcelApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook WorkBook = WorkBooks.Open(filePath);

            //1シート目の選択
            Microsoft.Office.Interop.Excel.Worksheet sheet = WorkBook.Sheets[1];
            sheet.Select();
            /***** LeafSpyファイルの読み込み End *****/

            /***** DBにアクセス *****/

            String connectionString = "Data Source=ECOLOGDB2016;Initial Catalog=ECOLOGDBver3;Integrated Security=True;Connection Timeout=60";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                /***** TRIPS_TABLE生成 Start *****/
                string query = "SELECT TRIP_ID, START_TIME, END_TIME FROM [ECOLOGDBver3].[dbo].[TRIPS_LINKS_LOOKUP2] WHERE DRIVER_ID = " + driverID + " AND CAR_ID = " + carID + "AND SENSOR_ID = " + sensorID;
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(TRIPS_TABLE);
                /***** TRIPS_TABLE生成 End *****/

                // データ挿入
                try
                {
                    // LeafSpyデータの読み込み ヘッダを除いてスタート
                    for (int i = 2; i <= sheet.UsedRange.Rows.Count; i++)
                    {
                        indexLabel.Text = i + " / " + sheet.UsedRange.Rows.Count;
                        LeafSpyDatum datum = new LeafSpyDatum();

                        for (int j = 1; j < END_OF_COLUMN; j++)
                        {
                            // 挿入しないデータはスルー
                            if (j >= REJECT_COLUMNS_START && j <= REJECT_COLUMNS_END)
                                continue;

                            Microsoft.Office.Interop.Excel.Range range = sheet.Cells[i, j];
                            datum.setDatumByIndex(j, range.Value);
                        }

                        // 規定値を設定
                        datum.setDriverId(driverID);
                        datum.setCarId(carID);

                        /**** トリップ判別 Start ****/
                        int tripID = 0;
                        for (int k = 0; k < TRIPS_TABLE.Rows.Count; k++)
                        {
                            // +- 5minute
                            DateTime startTime = (DateTime)TRIPS_TABLE.Rows[k][1];
                            DateTime startEdge = startTime.AddMinutes(-5);
                            DateTime endTime = (DateTime) TRIPS_TABLE.Rows[k][2];
                            DateTime endEdge = endTime.AddMinutes(5);

                            if (startEdge < datum.dateTime && datum.dateTime < endEdge)
                            {
                                tripID = (int)TRIPS_TABLE.Rows[k][0];
                                datum.setTripId((int)TRIPS_TABLE.Rows[k][0]);

                                // データベースに挿入
                                // トランザクション生成
                                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                                sqlCommand.Transaction = sqlTransaction;

                                try
                                {
                                    // 新規にInsert文を発行
                                    String sqlIns = getInsertString(datum, false);
                                    sqlCommand.CommandText = sqlIns;
                                    // 指定した SQL コマンドを実行してデータを挿入する
                                    sqlCommand.ExecuteNonQuery();
                                    // 旨くいったらコミット
                                    sqlTransaction.Commit();

                                    this.successInsertingTextBox.AppendText("Success : " + tripID + " , " + datum.dateTime + System.Environment.NewLine);
                                }
                                catch (Exception e)
                                {
                                    tripID = -1;
                                    Console.WriteLine(e.Message);
                                    this.failedInsertingTextBox.AppendText("Failed : " + datum.dateTime + System.Environment.NewLine);
                                    // 失敗すると例外となるので，ロールバック
                                    sqlTransaction.Rollback();
                                }
                            }
       
                        }
                        /**** トリップ判別 End ****/

                        // NULL許容ならばTrip ID NULLでインサート
                        if (tripID == 0 && nullAllowance == true)
                        {
                            // データベースに挿入
                            // トランザクション生成
                            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                            SqlCommand sqlCommand = sqlConnection.CreateCommand();
                            sqlCommand.Transaction = sqlTransaction;

                            try
                            {
                                // 新規にInsert文を発行
                                String sqlIns = getInsertString(datum, true);
                                sqlCommand.CommandText = sqlIns;
                                // 指定した SQL コマンドを実行してデータを挿入する
                                sqlCommand.ExecuteNonQuery();
                                // 旨くいったらコミット
                                sqlTransaction.Commit();

                                this.successInsertingTextBox.AppendText("Success : " + "NULL" + " , " + datum.dateTime + System.Environment.NewLine);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                this.failedInsertingTextBox.AppendText("Failed : " + datum.dateTime + System.Environment.NewLine);
                                // 失敗すると例外となるので，ロールバック
                                sqlTransaction.Rollback();
                            }
                        }

                    }
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            //workbookを閉じる
            WorkBook.Close();
            WorkBook = null;
            WorkBooks.Close();
            WorkBooks = null;
            //エクセルを閉じる
            ExcelApp.Quit();
            ExcelApp = null;

            errorCodeLabel.Text = "All inserting complete";

        }

        private String getInsertString(LeafSpyDatum datum, bool nullAllowance)
        {
            if (nullAllowance == false)
            {
                String insertQuery = "INSERT INTO LEAFSPY_RAW_TEST VALUES('" + datum.tripId + "','" + datum.driverId + "','" + datum.carId + "','" + datum.dateTime + "'," + "NULL"
                                        + "," + "NULL" + ",'" + datum.elv + "','" + datum.speed + "','" + datum.gids + "','" + datum.soc + "','" + datum.ahr
                                     + "','" + datum.packVolts + "','" + datum.packAmps + "','" + datum.maxCpMv + "','" + datum.minCpMv + "','" + datum.avgCpMv + "','" + datum.cpMvDiff + "','" + datum.judgementValue
                                     + "','" + datum.packT1F + "','" + datum.packT1C + "','" + datum.packT2F + "','" + datum.packT2C + "','" + datum.packT3F + "','" + datum.packT3C + "','" + datum.packT4F + "','" + datum.packT4C
                                     + "','" + datum.batVlot + "','" + datum.vin + "','" + datum.hx + "','" + datum.raw12Bat + "','" + datum.odoKm + "','" + datum.qc + "','" + datum.l1l2 + "','" + datum.tpFl
                                     + "','" + datum.tpFr + "','" + datum.tpRr + "','" + datum.tpRl + "','" + datum.ambient + "','" + datum.soh + "','" + datum.regenWh + "','" + datum.bLevel + "','" + datum.epochTime
                                     + "','" + datum.motorPwr100W + "','" + datum.auxPwr100W + "','" + datum.acPwr250W + "','" + datum.acPSI + "','" + datum.estPwrAc250W + "','" + datum.estPwrHtr250W
                                     + "','" + datum.plugState + "','" + datum.chargeMode + "','" + datum.obcOutPwr + "','" + datum.gear + "','" + datum.hVolt1 + "','" + datum.hVolt2 + "','" + datum.gpsStatus
                                     + "','" + datum.powerSW + "','" + datum.bms + "','" + datum.obc + "','" + datum.debug + "','" + datum.motorTemp + "','" + datum.inverter2Temp + "','" + datum.inverter4Temp
                                     + "','" + datum.speed1 + "','" + datum.speed2 + "','" + datum.wiperStatus + "')";

                if (datum.debug < 0)
                {
                    insertQuery = "INSERT INTO LEAFSPY_RAW_TEST VALUES('" + datum.tripId + "','" + datum.driverId + "','" + datum.carId + "','" + datum.dateTime + "'," + "NULL"
                                        + "," + "NULL" + ",'" + datum.elv + "','" + datum.speed + "','" + datum.gids + "','" + datum.soc + "','" + datum.ahr
                                     + "','" + datum.packVolts + "','" + datum.packAmps + "','" + datum.maxCpMv + "','" + datum.minCpMv + "','" + datum.avgCpMv + "','" + datum.cpMvDiff + "','" + datum.judgementValue
                                     + "','" + datum.packT1F + "','" + datum.packT1C + "','" + datum.packT2F + "','" + datum.packT2C + "','" + datum.packT3F + "','" + datum.packT3C + "','" + datum.packT4F + "','" + datum.packT4C
                                     + "','" + datum.batVlot + "','" + datum.vin + "','" + datum.hx + "','" + datum.raw12Bat + "','" + datum.odoKm + "','" + datum.qc + "','" + datum.l1l2 + "','" + datum.tpFl
                                     + "','" + datum.tpFr + "','" + datum.tpRr + "','" + datum.tpRl + "','" + datum.ambient + "','" + datum.soh + "','" + datum.regenWh + "','" + datum.bLevel + "','" + datum.epochTime
                                     + "','" + datum.motorPwr100W + "','" + datum.auxPwr100W + "','" + datum.acPwr250W + "','" + datum.acPSI + "','" + datum.estPwrAc250W + "','" + datum.estPwrHtr250W
                                     + "','" + datum.plugState + "','" + datum.chargeMode + "','" + datum.obcOutPwr + "','" + datum.gear + "','" + datum.hVolt1 + "','" + datum.hVolt2 + "','" + datum.gpsStatus
                                     + "','" + datum.powerSW + "','" + datum.bms + "','" + datum.obc + "'," + "NULL" +",'" + datum.motorTemp + "','" + datum.inverter2Temp + "','" + datum.inverter4Temp
                                     + "','" + datum.speed1 + "','" + datum.speed2 + "','" + datum.wiperStatus + "')";
                }

                return insertQuery;
            }
            else
            {
                String insertQuery = "INSERT INTO LEAFSPY_RAW_TEST VALUES(NULL" + ",'" + datum.driverId + "','" + datum.carId + "','" + datum.dateTime + "'," + "NULL"
                                    + "," + "NULL" + ",'" + datum.elv + "','" + datum.speed + "','" + datum.gids + "','" + datum.soc + "','" + datum.ahr
                                 + "','" + datum.packVolts + "','" + datum.packAmps + "','" + datum.maxCpMv + "','" + datum.minCpMv + "','" + datum.avgCpMv + "','" + datum.cpMvDiff + "','" + datum.judgementValue
                                 + "','" + datum.packT1F + "','" + datum.packT1C + "','" + datum.packT2F + "','" + datum.packT2C + "','" + datum.packT3F + "','" + datum.packT3C + "','" + datum.packT4F + "','" + datum.packT4C
                                 + "','" + datum.batVlot + "','" + datum.vin + "','" + datum.hx + "','" + datum.raw12Bat + "','" + datum.odoKm + "','" + datum.qc + "','" + datum.l1l2 + "','" + datum.tpFl
                                 + "','" + datum.tpFr + "','" + datum.tpRr + "','" + datum.tpRl + "','" + datum.ambient + "','" + datum.soh + "','" + datum.regenWh + "','" + datum.bLevel + "','" + datum.epochTime
                                 + "','" + datum.motorPwr100W + "','" + datum.auxPwr100W + "','" + datum.acPwr250W + "','" + datum.acPSI + "','" + datum.estPwrAc250W + "','" + datum.estPwrHtr250W
                                 + "','" + datum.plugState + "','" + datum.chargeMode + "','" + datum.obcOutPwr + "','" + datum.gear + "','" + datum.hVolt1 + "','" + datum.hVolt2 + "','" + datum.gpsStatus
                                 + "','" + datum.powerSW + "','" + datum.bms + "','" + datum.obc + "','" + datum.debug + "','" + datum.motorTemp + "','" + datum.inverter2Temp + "','" + datum.inverter4Temp
                                 + "','" + datum.speed1 + "','" + datum.speed2 + "','" + datum.wiperStatus + "')";
                return insertQuery;
            }
        }
    }
}