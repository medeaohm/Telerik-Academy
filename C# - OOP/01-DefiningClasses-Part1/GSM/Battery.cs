namespace GSM
{
    using System;
    using System.Text;

    class Battery
    {
        private BatteryType batteryType;
        private decimal hoursTalk;
        private decimal hoursIdle;

        public Battery(BatteryType batteryType): base()
        {
            this.BatteryType = batteryType;
        }

        public Battery(BatteryType batteryType, decimal hoursTalk, decimal hoursIdle)
            : this(batteryType)
        {
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
        }

        public BatteryType BatteryType 
        { 
            get
            {
                if (BatteryType.Equals(null))
                {
                    throw new NullReferenceException("Battery type cannot be left blank");
                }
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public decimal HoursTalk 
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Talk hours must be a positive number");
                }
                this.hoursTalk = value;
            }
        }

        public decimal HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Idle hours must be a positive number");
                }
                this.hoursIdle = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Information about the Battery:");
            result.AppendLine("Battery Type: " + this.batteryType);
            result.AppendLine("Hours Talk: " + this.hoursTalk.ToString());
            result.AppendLine("Hours Idle: " + this.hoursIdle.ToString());
            return result.ToString();
        }
    }

    public enum BatteryType 
    {
         LiIon,
         NiMH,  
         NiCd,
    }
}
