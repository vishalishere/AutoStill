﻿using System.Data.SqlClient;
using System.Configuration;

namespace AutoStillDotNet
{
    class SystemProperties
    {

        ////ACTUAL VALUES
        ////Digital IO Pins
        //private byte fvemptyswitch = 1;
        //private byte fvcompleteswitch = 1;
        //private byte stillfluidpump = 30;
        //private byte stillfillvalve = 7 + 21;
        //private byte stilllowswitch = 49;
        //private byte stillhighswitch = 51;
        //private byte stillelement = 1;
        //private byte stilldrainvalve = 1;
        //private byte rvfluidpump = 1;
        //private byte rvdrainvalve = 1;
        //private byte rvfullswitch = 1;
        //private byte vacuumpump = 6 + 21;
        //private byte fanset1 = 1;
        //private byte fanset2 = 1;
        //private byte fancontroller1 = 1;
        //private byte fancontroller2 = 1;

        ////Analog IO Pins
        //private byte sensorpressure = 55;
        //private byte sensorcolumntemp = 54;

        //DEV VALUES
        //Digital IO Pins
        private byte fvemptyswitch = 50;
        private byte fvcompleteswitch = 51;
        private byte stillfluidpump = 22;
        private byte stillfillvalve = 23;
        private byte stilllowswitch = 52;
        private byte stillhighswitch = 53;
        private byte stillelement = 27;
        private byte stilldrainvalve = 26;
        private byte rvfluidpump = 24;
        private byte rvdrainvalve = 26;
        private byte rvfullswitch = 1;
        private byte rvemptyswitch = 1;
        private byte vacuumpump = 27;
        private byte fanset1 = 1;
        private byte fanset2 = 1;
        private byte fancontroller1 = 1;
        private byte fancontroller2 = 1;

        //Analog IO Pins
        private byte sensorpressure = 55;
        private byte sensorcolumntemp = 54;

        //System Targets (I.E. Target Pressure to Maintain)
        private double targetpressure = 100; //Target value in raw ADC units
        private double tgtpreshysteresisbuffer = 0.5; //How far under the target to actually pump until to prevent the pump from turning on and off rapidly


        //System Settings
        private string units = "Metric";

        public byte FVEmptySwtich
        {
            get
            {
                return fvemptyswitch;
            }
            set
            {
                
                    fvemptyswitch = value;
            }
        }
        public byte FVCompleteSwitch
        {
            get
            {
                return fvcompleteswitch;
            }
            set
            {
                
                    fvcompleteswitch = value;
            }
        }
        public byte StillFluidPump
        {
            get
            {
                return stillfluidpump;
            }
            set
            {
                
                    stillfluidpump = value;
            }
        }
        public byte StillFillValve
        {
            get
            {
                return stillfillvalve;
            }
            set
            {
                
                    stillfillvalve = value;
            }
        }
        public byte StillLowSwitch
        {
            get
            {
                return stilllowswitch;
            }
            set
            {
                
                    stilllowswitch = value;
            }
        }
        public byte StillHighSwitch
        {
            get
            {
                return stillhighswitch;
            }
            set
            {
                
                    stillhighswitch = value;
            }
        }
        public byte StillElement
        {
            get
            {
                return stillelement;
            }
            set
            {
                
                    stillelement = value;
            }
        }
        public byte StillDrainValve
        {
            get
            {
                return stilldrainvalve;
            }
            set
            {
                
                    stilldrainvalve = value;
            }
        }
        public byte RVFluidPump
        {
            get
            {
                return rvfluidpump;
            }
            set
            {
                
                    rvfluidpump = value;
            }
        }
        public byte RVDrainValve
        {
            get
            {
                return rvdrainvalve;
            }
            set
            {
                
                    rvdrainvalve = value;
            }
        }
        public byte RVFullSwitch
        {
            get
            {
                return rvfullswitch;
            }
            set
            {
                
                    rvfullswitch = value;
            }
        }
        public byte RVEmptySwitch
        {
            get
            {
                return rvemptyswitch;
            }
            set
            {
                
                    rvemptyswitch = value;
            }
        }
        public byte VacuumPump
        {
            get
            {
                return vacuumpump;
            }
            set
            {
                
                    vacuumpump = value;
            }
        }
        public byte FanSet1
        {
            get
            {
                return fanset1;
            }
            set
            {
                
                    fanset1 = value;
            }
        }
        public byte FanSet2
        {
            get
            {
                return fanset2;
            }
            set
            {
                
                    fanset2 = value;
            }
        }
        public byte FanController1
        {
            get
            {
                return fancontroller1;
            }
            set
            {
                
                    fancontroller1 = value;
            }
        }
        public byte FanController2
        {
            get
            {
                return fancontroller2;
            }
            set
            {
                
                    fancontroller2 = value;
            }
        }
        public byte SensorPressure
        {
            get
            {
                return sensorpressure;
            }
            set
            {
                
                    sensorpressure = value;
            }
        }
        public byte SensorColumnTemp
        {
            get
            {
                return sensorcolumntemp;
            }
            set
            {
                
                    sensorcolumntemp = value;
            }
        }


        public double TargetPressure
        {
            get
            {
                return targetpressure;
            }
            set
            {
                
                    targetpressure = value;
            }
        }
        public double TgtPresHysteresisBuffer
        {
            get
            {
                return tgtpreshysteresisbuffer;
            }
            set
            {
                
                    tgtpreshysteresisbuffer = value;
            }
        }

        public string Units
        {
            get
            {
                return units;
            }
            set
            {
                    units = value;
            }
        }

        SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString);
        public SqlConnection sqlConnection
        {

            get
            {
                return sqlconnection;
            }
            set
            {
            }
        }

    }
}
