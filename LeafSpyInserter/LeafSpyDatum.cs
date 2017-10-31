using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeafSpyInserter
{
    class LeafSpyDatum
    {
        public int tripId;
        public int driverId;
        public int carId;
        public DateTime dateTime;
        public Object latitude;
        public Object longitude;
        public double elv;
        public double speed;
        public int gids;
        public int soc;
        public int ahr;
        public double packVolts;
        public double packAmps;
        public int maxCpMv;
        public int minCpMv;
        public int avgCpMv;
        public int cpMvDiff;
        public int judgementValue;
        public double packT1F;
        public double packT1C;
        public double packT2F;
        public double packT2C;
        public double packT3F;
        public double packT3C;
        public double packT4F;
        public double packT4C;
        public double batVlot;
        public String vin;
        public double hx;
        public double raw12Bat;
        public int odoKm;
        public int qc;
        public String l1l2;
        public int tpFl;
        public int tpFr;
        public int tpRr;
        public int tpRl;
        public int ambient;
        public int soh;
        public int regenWh;
        public int bLevel;
        public int epochTime;
        public int motorPwr100W;
        public int auxPwr100W;
        public int acPwr250W;
        public int acPSI;
        public int estPwrAc250W;
        public int estPwrHtr250W;
        public int plugState;
        public int chargeMode;
        public int obcOutPwr;
        public int gear;
        public double hVolt1;
        public double hVolt2;
        public String gpsStatus;
        public int powerSW;
        public int bms;
        public int obc;
        public int debug;
        public int motorTemp;
        public int inverter2Temp;
        public int inverter4Temp;
        public int speed1;
        public int speed2;
        public String wiperStatus;

        public void setTripId(int tripId)
        {
            this.tripId = tripId;
        }

        public void setDriverId(int driverId)
        {
            this.driverId = driverId;
        }

        public void setCarId(int carId)
        {
            this.carId = carId;
        }

        public void setDateTime(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public void setLatitude(Object latitude)
        {
            this.latitude = latitude;
        }

        public void setLongitude(Object longitude)
        {
            this.longitude = longitude;
        }

        public void setElv(double elv)
        {
            this.elv = elv;
        }

        public void setSpeed(double speed)
        {
            this.speed = speed;
        }

        public void setGids(int gids)
        {
            this.gids = gids;
        }

        public void setSoc(int soc)
        {
            this.soc = soc;
        }

        public void setAhr(int ahr)
        {
            this.ahr = ahr;
        }

        public void setPackVolts(double packVolts)
        {
            this.packVolts = packVolts;
        }

        public void setPackAmps(double packAmps)
        {
            this.packAmps = packAmps;
        }

        public void setMaxCpMv(int maxCpMv)
        {
            this.maxCpMv = maxCpMv;
        }

        public void setMinCpMv(int minCpMv)
        {
            this.minCpMv = minCpMv;
        }

        public void setAvgCpMv(int avgCpMv)
        {
            this.avgCpMv = avgCpMv;
        }

        public void setCpMvDiff(int cpMvDiff)
        {
            this.cpMvDiff = cpMvDiff;
        }

        public void setJudgementValue(int judgementValue)
        {
            this.judgementValue = judgementValue;
        }

        public void setPackT1F(double packT1F)
        {
            this.packT1F = packT1F;
        }

        public void setPackT1C(double packT1C)
        {
            this.packT1C = packT1C;
        }

        public void setPackT2F(double packT2F)
        {
            this.packT2F = packT2F;
        }

        public void setPackT2C(double packT2C)
        {
            this.packT2C = packT2C;
        }

        public void setPackT3F(double packT3F)
        {
            this.packT3F = packT3F;
        }

        public void setPackT3C(double packT3C)
        {
            this.packT3C = packT3C;
        }

        public void setPackT4F(double packT4F)
        {
            this.packT4F = packT4F;
        }

        public void setPackT4C(double packT4C)
        {
            this.packT4C = packT4C;
        }

        public void setBatVlot(double batVlot)
        {
            this.batVlot = batVlot;
        }

        public void setVin(String vin)
        {
            this.vin = vin;
        }

        public void setHx(double hx)
        {
            this.hx = hx;
        }

        public void setRaw12Bat(double raw12Bat)
        {
            this.raw12Bat = raw12Bat;
        }

        public void setOdoKm(int odoKm)
        {
            this.odoKm = odoKm;
        }

        public void setQc(int qc)
        {
            this.qc = qc;
        }

        public void setL1l2(String l1l2)
        {
            this.l1l2 = l1l2;
        }

        public void setTpFl(int tpFl)
        {
            this.tpFl = tpFl;
        }

        public void setTpFr(int tpFr)
        {
            this.tpFr = tpFr;
        }

        public void setTpRr(int tpRr)
        {
            this.tpRr = tpRr;
        }

        public void setTpRl(int tpRl)
        {
            this.tpRl = tpRl;
        }

        public void setAmbient(int ambient)
        {
            this.ambient = ambient;
        }

        public void setSoh(int soh)
        {
            this.soh = soh;
        }

        public void setRegenWh(int regenWh)
        {
            this.regenWh = regenWh;
        }

        public void setBLevel(int bLevel)
        {
            this.bLevel = bLevel;
        }

        public void setEpochTime(int epochTime)
        {
            this.epochTime = epochTime;
        }

        public void setMotorPwr100W(int motorPwr100W)
        {
            this.motorPwr100W = motorPwr100W;
        }

        public void setAuxPwr100W(int auxPwr100W)
        {
            this.auxPwr100W = auxPwr100W;
        }

        public void setAcPwr250W(int acPwr250W)
        {
            this.acPwr250W = acPwr250W;
        }

        public void setAcPSI(int acPSI)
        {
            this.acPSI = acPSI;
        }

        public void setEstPwrAc250W(int estPwrAc250W)
        {
            this.estPwrAc250W = estPwrAc250W;
        }

        public void setEstPwrHtr250W(int estPwrHtr250W)
        {
            this.estPwrHtr250W = estPwrHtr250W;
        }

        public void setPlugState(int plugState)
        {
            this.plugState = plugState;
        }

        public void setChargeMode(int chargeMode)
        {
            this.chargeMode = chargeMode;
        }

        public void setObcOutPwr(int obcOutPwr)
        {
            this.obcOutPwr = obcOutPwr;
        }

        public void setGear(int gear)
        {
            this.gear = gear;
        }

        public void setHVolt1(double hVolt1)
        {
            this.hVolt1 = hVolt1;
        }

        public void setHVolt2(double hVolt2)
        {
            this.hVolt2 = hVolt2;
        }

        public void setGpsStatus(String gpsStatus)
        {
            this.gpsStatus = gpsStatus;
        }

        public void setPowerSW(int powerSW)
        {
            this.powerSW = powerSW;
        }

        public void setBms(int bms)
        {
            this.bms = bms;
        }

        public void setObc(int obc)
        {
            this.obc = obc;
        }

        public void setDebug(int debug)
        {
            this.debug = debug;
        }

        public void setMotorTemp(int motorTemp)
        {
            this.motorTemp = motorTemp;
        }

        public void setInverter2Temp(int inverter2Temp)
        {
            this.inverter2Temp = inverter2Temp;
        }

        public void setInverter4Temp(int inverter4Temp)
        {
            this.inverter4Temp = inverter4Temp;
        }

        public void setSpeed1(int speed1)
        {
            this.speed1 = speed1;
        }

        public void setSpeed2(int speed2)
        {
            this.speed2 = speed2;
        }

        public void setWiperStatus(String wiperStatus)
        {
            this.wiperStatus = wiperStatus;
        }

        public void setDatumByIndex(int index, Object datum)
        {
            switch (index)
            {
                case 1:
                    /*
                    String rawString = (String)datum;
                    if (rawString.Length == 19)
                    {
                        int month = int.Parse(rawString.Substring(0, 2));
                        int dayOfMonth = int.Parse(rawString.Substring(3, 2));
                        int year = int.Parse(rawString.Substring(6, 4));
                        int hour = int.Parse(rawString.Substring(11, 2));
                        int minute = int.Parse(rawString.Substring(14, 2));
                        int second = int.Parse(rawString.Substring(17, 2));
                        setDateTime(new DateTime(year, month, dayOfMonth, hour, minute, second));
                    }
                    else
                    {
                        int month = int.Parse(rawString.Substring(0, 2));
                        int dayOfMonth = int.Parse(rawString.Substring(3, 2));
                        int year = int.Parse(rawString.Substring(6, 4));
                        int hour = int.Parse(rawString.Substring(11, 1));
                        int minute = int.Parse(rawString.Substring(13, 2));
                        int second = int.Parse(rawString.Substring(16, 2));
                        setDateTime(new DateTime(year, month, dayOfMonth, hour, minute, second));
                    }*/
                    setDateTime((DateTime)datum);
                    break;
                case 2:
                    setLatitude(null);
                    break;
                case 3:
                    setLongitude(null);
                    break;
                case 4:
                    setElv((double)datum);
                    break;
                case 5:
                    setSpeed((double)datum);
                    break;
                case 6:
                    setGids((int)(double)datum);
                    break;
                case 7:
                    setSoc((int)(double)datum);
                    break;
                case 8:
                    setAhr((int)(double)datum);
                    break;
                case 9:
                    setPackVolts((double)datum);
                    break;
                case 10:
                    setPackAmps((double)datum);
                    break;
                case 11:
                    setMaxCpMv((int)(double)datum);
                    break;
                case 12:
                    setMinCpMv((int)(double)datum);
                    break;
                case 13:
                    setAvgCpMv((int)(double)datum);
                    break;
                case 14:
                    setCpMvDiff((int)(double)datum);
                    break;
                case 15:
                    setJudgementValue((int)(double)datum);
                    break;
                case 16:
                    setPackT1F((double)datum);
                    break;
                case 17:
                    setPackT1C((double)datum);
                    break;
                case 18:
                    setPackT2F((double)datum);
                    break;
                case 19:
                    setPackT2C((double)datum);
                    break;
                case 20:
                    setPackT3F((double)datum);
                    break;
                case 21:
                    setPackT3C((double)datum);
                    break;
                case 22:
                    setPackT4F((double)datum);
                    break;
                case 23:
                    setPackT4C((double)datum);
                    break;
                case 120:
                    setBatVlot((double)datum);
                    break;
                case 121:
                    if (datum.GetType() == typeof(double))
                    {
                        String temp = ((double)datum).ToString();
                        setVin(temp);
                    }
                    else
                    {
                        setVin((String)datum);
                    }
                    break;
                case 122:
                    setHx((double)datum);
                    break;
                case 123:
                    setRaw12Bat((double)datum);
                    break;
                case 124:
                    setOdoKm((int)(double)datum);
                    break;
                case 125:
                    setQc((int)(double)datum);
                    break;
                case 126:
                    double tempDouble = (double)datum;
                    setL1l2(tempDouble.ToString());
                    break;
                case 127:
                    setTpFl((int)(double)datum);
                    break;
                case 128:
                    setTpFr((int)(double)datum);
                    break;
                case 129:
                    setTpRr((int)(double)datum);
                    break;
                case 130:
                    setTpRl((int)(double)datum);
                    break;
                case 131:
                    setAmbient((int)(double)datum);
                    break;
                case 132:
                    setSoh((int)(double)datum);
                    break;
                case 133:
                    setRegenWh((int)(double)datum);
                    break;
                case 134:
                    setBLevel((int)(double)datum);
                    break;
                case 135:
                    setEpochTime((int)(double)datum);
                    break;
                case 136:
                    setMotorPwr100W((int)(double)datum);
                    break;
                case 137:
                    setAuxPwr100W((int)(double)datum);
                    break;
                case 138:
                    setAcPwr250W((int)(double)datum);
                    break;
                case 139:
                    setAcPSI((int)(double)datum);
                    break;
                case 140:
                    setEstPwrAc250W((int)(double)datum);
                    break;
                case 141:
                    setEstPwrHtr250W((int)(double)datum);
                    break;
                case 142:
                    setPlugState((int)(double)datum);
                    break;
                case 143:
                    setChargeMode((int)(double)datum);
                    break;
                case 144:
                    setObcOutPwr((int)(double)datum);
                    break;
                case 145:
                    setGear((int)(double)datum);
                    break;
                case 146:
                    setHVolt1((double)datum);
                    break;
                case 147:
                    setHVolt2((double)datum);
                    break;
                case 148:
                    setGpsStatus((String)datum);
                    break;
                case 149:
                    setPowerSW((int)(double)datum);
                    break;
                case 150:
                    setBms((int)(double)datum);
                    break;
                case 151:
                    setObc((int)(double)datum);
                    break;
                case 152:
                    if (datum.GetType() == typeof(String))
                    {
                        int debugTemp = -1;
                        setDebug(debugTemp);
                    }
                    else
                    {
                        setDebug((int)(double)datum);
                    }
                    break;
                case 153:
                    setMotorTemp((int)(double)datum);
                    break;
                case 154:
                    setInverter2Temp((int)(double)datum);
                    break;
                case 155:
                    setInverter4Temp((int)(double)datum);
                    break;
                case 156:
                    setSpeed1((int)(double)datum);
                    break;
                case 157:
                    setSpeed2((int)(double)datum);
                    break;
                case 158:
                    if (datum.GetType() != typeof(String))
                    {
                        String tmp = ((int)(double)datum).ToString();
                        setWiperStatus(tmp);
                    }
                    else
                    {
                        setWiperStatus((String)datum);
                    }
                    break;

            }
        }
    }
}
