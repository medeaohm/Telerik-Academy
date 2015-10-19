namespace Computers.Utilities.Components
{
    public class Battery : IBattery
    {
        private const int DefaultCharge = 50;

        public Battery()
        {
            this.Percentage = DefaultCharge;
        }

        public int Percentage { get; set; }

        public void Charge(int percentage)
        {
            this.Percentage += percentage;

            if (this.Percentage > 100)
            {
                this.Percentage = 100;
            }
            else if (this.Percentage < 0)
            {
                this.Percentage = 0;
            }
        }
    }
}
