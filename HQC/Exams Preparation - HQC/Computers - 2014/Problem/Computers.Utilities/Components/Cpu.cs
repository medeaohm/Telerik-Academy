namespace Computers.Utilities.Components
{
    using System;

    public abstract class Cpu : MotherboardComponents, ICpu
    {
        private const string NumberTooLowMessage = "Number too low.";

        private const string NumberTooHighMessage = "Number too high.";

        private const string SquareOfMessage = "Square of {0} is {1}.";

        private static readonly Random Random = new Random();

        public Cpu(byte numberOfCores)
        {
            this.NumberOfCores = numberOfCores;
        }

        public byte NumberOfCores { get; set; }

        public void SquareNumber()
        {
            var data = this.Motherboard.LoadRamValue();
            if (data < 0)
            {
                this.Motherboard.DrawOnVideoCard(NumberTooLowMessage);
            }
            else if (data > this.GetMaxNumber())
            {
                this.Motherboard.DrawOnVideoCard(NumberTooHighMessage);
            }
            else
            {
                var value = data * data;
                this.Motherboard.DrawOnVideoCard(string.Format(SquareOfMessage, data, value));
            }
        }

        public void GenerateRandomNumber(int min, int max)
        {
            int randomNumber = Random.Next(min, max + 1);
          
            this.Motherboard.SaveRamValue(randomNumber);
        }

        internal abstract int GetMaxNumber();
    }
}
