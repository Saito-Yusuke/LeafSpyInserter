namespace LeafSpyInserter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.driverIDLabel = new System.Windows.Forms.Label();
            this.driverIDComboBox = new System.Windows.Forms.ComboBox();
            this.carIDLabel = new System.Windows.Forms.Label();
            this.carIDComboBox = new System.Windows.Forms.ComboBox();
            this.startInsertingButton = new System.Windows.Forms.Button();
            this.indexLabel = new System.Windows.Forms.Label();
            this.successInsertingLabel = new System.Windows.Forms.Label();
            this.successInsertingTextBox = new System.Windows.Forms.TextBox();
            this.failedInsertingLabel = new System.Windows.Forms.Label();
            this.failedInsertingTextBox = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.errorCodeLabel = new System.Windows.Forms.Label();
            this.nullAllowanceCheckBox = new System.Windows.Forms.CheckBox();
            this.SensorIdCombobox = new System.Windows.Forms.ComboBox();
            this.SensorIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // driverIDLabel
            // 
            this.driverIDLabel.AutoSize = true;
            this.driverIDLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.driverIDLabel.Location = new System.Drawing.Point(12, 35);
            this.driverIDLabel.Name = "driverIDLabel";
            this.driverIDLabel.Size = new System.Drawing.Size(68, 16);
            this.driverIDLabel.TabIndex = 0;
            this.driverIDLabel.Text = "Driver ID";
            // 
            // driverIDComboBox
            // 
            this.driverIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverIDComboBox.FormattingEnabled = true;
            this.driverIDComboBox.Items.AddRange(new object[] {
            "1（富井先生）",
            "4（森先生）",
            "16（本藤先生）"});
            this.driverIDComboBox.Location = new System.Drawing.Point(15, 55);
            this.driverIDComboBox.Name = "driverIDComboBox";
            this.driverIDComboBox.Size = new System.Drawing.Size(121, 20);
            this.driverIDComboBox.TabIndex = 1;
            // 
            // carIDLabel
            // 
            this.carIDLabel.AutoSize = true;
            this.carIDLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.carIDLabel.Location = new System.Drawing.Point(151, 35);
            this.carIDLabel.Name = "carIDLabel";
            this.carIDLabel.Size = new System.Drawing.Size(52, 16);
            this.carIDLabel.TabIndex = 2;
            this.carIDLabel.Text = "Car ID";
            // 
            // carIDComboBox
            // 
            this.carIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carIDComboBox.FormattingEnabled = true;
            this.carIDComboBox.Items.AddRange(new object[] {
            "3（LEAF）",
            "8（LEAF_XXXXXX）"});
            this.carIDComboBox.Location = new System.Drawing.Point(154, 55);
            this.carIDComboBox.Name = "carIDComboBox";
            this.carIDComboBox.Size = new System.Drawing.Size(121, 20);
            this.carIDComboBox.TabIndex = 3;
            // 
            // startInsertingButton
            // 
            this.startInsertingButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startInsertingButton.Location = new System.Drawing.Point(15, 82);
            this.startInsertingButton.Name = "startInsertingButton";
            this.startInsertingButton.Size = new System.Drawing.Size(121, 28);
            this.startInsertingButton.TabIndex = 4;
            this.startInsertingButton.Text = "Start inserting";
            this.startInsertingButton.UseVisualStyleBackColor = true;
            this.startInsertingButton.Click += new System.EventHandler(this.startInsertingButton_Click);
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.indexLabel.Location = new System.Drawing.Point(172, 88);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(103, 16);
            this.indexLabel.TabIndex = 5;
            this.indexLabel.Text = "inserting index";
            // 
            // successInsertingLabel
            // 
            this.successInsertingLabel.AutoSize = true;
            this.successInsertingLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.successInsertingLabel.Location = new System.Drawing.Point(15, 117);
            this.successInsertingLabel.Name = "successInsertingLabel";
            this.successInsertingLabel.Size = new System.Drawing.Size(160, 16);
            this.successInsertingLabel.TabIndex = 6;
            this.successInsertingLabel.Text = "Success inserting data";
            // 
            // successInsertingTextBox
            // 
            this.successInsertingTextBox.Location = new System.Drawing.Point(18, 137);
            this.successInsertingTextBox.MaxLength = 0;
            this.successInsertingTextBox.Multiline = true;
            this.successInsertingTextBox.Name = "successInsertingTextBox";
            this.successInsertingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.successInsertingTextBox.Size = new System.Drawing.Size(512, 150);
            this.successInsertingTextBox.TabIndex = 7;
            // 
            // failedInsertingLabel
            // 
            this.failedInsertingLabel.AutoSize = true;
            this.failedInsertingLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.failedInsertingLabel.Location = new System.Drawing.Point(18, 294);
            this.failedInsertingLabel.Name = "failedInsertingLabel";
            this.failedInsertingLabel.Size = new System.Drawing.Size(143, 16);
            this.failedInsertingLabel.TabIndex = 8;
            this.failedInsertingLabel.Text = "Failed inserting data";
            // 
            // failedInsertingTextBox
            // 
            this.failedInsertingTextBox.Location = new System.Drawing.Point(18, 314);
            this.failedInsertingTextBox.MaxLength = 0;
            this.failedInsertingTextBox.Multiline = true;
            this.failedInsertingTextBox.Name = "failedInsertingTextBox";
            this.failedInsertingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.failedInsertingTextBox.Size = new System.Drawing.Size(512, 150);
            this.failedInsertingTextBox.TabIndex = 9;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fileNameLabel.Location = new System.Drawing.Point(13, 13);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(86, 16);
            this.fileNameLabel.TabIndex = 10;
            this.fileNameLabel.Text = "File name ...";
            // 
            // errorCodeLabel
            // 
            this.errorCodeLabel.AutoSize = true;
            this.errorCodeLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.errorCodeLabel.Location = new System.Drawing.Point(21, 471);
            this.errorCodeLabel.Name = "errorCodeLabel";
            this.errorCodeLabel.Size = new System.Drawing.Size(94, 16);
            this.errorCodeLabel.TabIndex = 11;
            this.errorCodeLabel.Text = "Error code ...";
            // 
            // nullAllowanceCheckBox
            // 
            this.nullAllowanceCheckBox.AutoSize = true;
            this.nullAllowanceCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nullAllowanceCheckBox.Location = new System.Drawing.Point(432, 53);
            this.nullAllowanceCheckBox.Name = "nullAllowanceCheckBox";
            this.nullAllowanceCheckBox.Size = new System.Drawing.Size(138, 20);
            this.nullAllowanceCheckBox.TabIndex = 12;
            this.nullAllowanceCheckBox.Text = "Allow null Trip ID";
            this.nullAllowanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // SensorIdCombobox
            // 
            this.SensorIdCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SensorIdCombobox.FormattingEnabled = true;
            this.SensorIdCombobox.Items.AddRange(new object[] {
            "12 AT570-3",
            "16 AT570-5",
            "29 Nexus7(2012)-1"});
            this.SensorIdCombobox.Location = new System.Drawing.Point(292, 55);
            this.SensorIdCombobox.Name = "SensorIdCombobox";
            this.SensorIdCombobox.Size = new System.Drawing.Size(121, 20);
            this.SensorIdCombobox.TabIndex = 13;
            // 
            // SensorIDLabel
            // 
            this.SensorIDLabel.AutoSize = true;
            this.SensorIDLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SensorIDLabel.Location = new System.Drawing.Point(289, 35);
            this.SensorIDLabel.Name = "SensorIDLabel";
            this.SensorIDLabel.Size = new System.Drawing.Size(74, 16);
            this.SensorIDLabel.TabIndex = 14;
            this.SensorIDLabel.Text = "Sensor ID";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 496);
            this.Controls.Add(this.SensorIDLabel);
            this.Controls.Add(this.SensorIdCombobox);
            this.Controls.Add(this.nullAllowanceCheckBox);
            this.Controls.Add(this.errorCodeLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.failedInsertingTextBox);
            this.Controls.Add(this.failedInsertingLabel);
            this.Controls.Add(this.successInsertingTextBox);
            this.Controls.Add(this.successInsertingLabel);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.startInsertingButton);
            this.Controls.Add(this.carIDComboBox);
            this.Controls.Add(this.carIDLabel);
            this.Controls.Add(this.driverIDComboBox);
            this.Controls.Add(this.driverIDLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LeafSpyInserter";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label driverIDLabel;
        private System.Windows.Forms.ComboBox driverIDComboBox;
        private System.Windows.Forms.Label carIDLabel;
        private System.Windows.Forms.ComboBox carIDComboBox;
        private System.Windows.Forms.Button startInsertingButton;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label successInsertingLabel;
        private System.Windows.Forms.TextBox successInsertingTextBox;
        private System.Windows.Forms.Label failedInsertingLabel;
        private System.Windows.Forms.TextBox failedInsertingTextBox;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label errorCodeLabel;
        private System.Windows.Forms.CheckBox nullAllowanceCheckBox;
        private System.Windows.Forms.Label SensorIDLabel;
        private System.Windows.Forms.ComboBox SensorIdCombobox;
    }
}

