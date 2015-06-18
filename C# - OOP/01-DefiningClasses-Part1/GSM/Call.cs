namespace GSM
{
    using System;
    using System.Text;

    class Call
    {
        private DateTime dateTime;
        private string contactName;
        private string contactNumber;
        private double duration;

        public Call(DateTime dateTime, string contactName, string contactNumber, double duration)
        {
            this.DateAndTime = dateTime;
            this.ContactName = contactName;
            this.ContactNumber = contactNumber;
            this.Duration = duration;
        }

        public DateTime DateAndTime
        {
            get { return this.dateTime; }
            private set 
            {
                this.dateTime = value;
            } 
        }

        public string ContactName
        {
            get { return this.contactName; }
            private set { this.contactName = value; }
        }

        public string ContactNumber
        {
            get { return this.contactNumber; }
            private set { this.contactNumber = value; }
        }

        public double Duration 
        {
            get { return this.duration; } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Duration cannot be negative");
                }
                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Call: ");
            result.AppendLine("Date and Time " + this.dateTime);
            result.AppendLine(this.contactName + " - " + this.contactNumber);
            result.AppendLine("Duration: " + this.duration.ToString());
            return result.ToString();
        }
    }
}
