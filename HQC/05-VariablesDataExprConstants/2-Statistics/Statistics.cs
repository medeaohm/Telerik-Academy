namespace Statistics
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] array, int count)
        {
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                double currentValue = array[i];
                sum += currentValue;
                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                }

                if (currentValue < minValue)
                {
                    minValue = currentValue;
                }
            }

            this.PrintNumber(maxValue);

            this.PrintNumber(minValue);

            double average = sum / count;
            
            this.PrintNumber(average);
        }

        private void PrintNumber(double number)
        {
            Console.WriteLine(number);
        }
    }
}
