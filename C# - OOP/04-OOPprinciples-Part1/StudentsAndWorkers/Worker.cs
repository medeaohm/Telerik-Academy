namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private double weekSalary;
        private double hoursPerDay;

        public Worker (string firstName, string lastname, double weekSalary, double hoursPerDay)
            : base (firstName, lastname)
        {
            this.WeekSalary = weekSalary;
            this.HoursPerDay = hoursPerDay;
        }

        public double WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public double HoursPerDay
        {
            get { return hoursPerDay; }
            set { hoursPerDay = value; }
        }


        public double MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.HoursPerDay); // five work 
        }

        public override string ToString()
        {
            return string.Format("{0} - {1:F3}", base.ToString(), this.MoneyPerHour());
        }

    }
}
