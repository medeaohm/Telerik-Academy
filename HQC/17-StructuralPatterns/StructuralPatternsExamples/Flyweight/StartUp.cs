using System;

namespace Flyweight
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            const int ONE_MILLION = 10000; // <--- Suppose this is one million :)

            int[] currencyDenominations = new[] { 1, 5, 10, 20, 50, 100 };

            MoneyFactory moneyFactory = new MoneyFactory();

            int sum = 0;

            while (sum <= ONE_MILLION)
            {
                IMoney graphicalMoneyObj = null;
                Random rand = new Random();
                int currencyDisplayValue = currencyDenominations[rand.Next(0, currencyDenominations.Length)];

                if (currencyDisplayValue == 1 || currencyDisplayValue == 5)
                {
                    graphicalMoneyObj = moneyFactory.GetMoneyToDisplay(EnMoneyType.Metallic);
                }
                else
                {
                    graphicalMoneyObj = moneyFactory.GetMoneyToDisplay(EnMoneyType.Paper);
                }
                    
                graphicalMoneyObj.GetDisplayOfMoneyFalling(currencyDisplayValue);
                sum = sum + currencyDisplayValue;
            }

            Console.WriteLine("Total Objects created=" + MoneyFactory.ObjectsCount.ToString());
            Console.ReadLine();
        }
    }
}
