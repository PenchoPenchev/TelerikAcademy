namespace _07.CreateGSMTest
{
    using System;
    using System.Collections.Generic;
    
    public class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;

        public Battery()
        {

        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, double? hoursIdle)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk)
            : this(model, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType type)
            : this(model, hoursIdle, hoursTalk)
        {
            this.Type = type;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double? HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public double? HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public BatteryType Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
