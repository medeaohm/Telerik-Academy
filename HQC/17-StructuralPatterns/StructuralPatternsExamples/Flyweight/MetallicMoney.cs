using System;

namespace Flyweight
{
    public class MetallicMoney : IMoney
    {
        public EnMoneyType MoneyType
        {
            get
            {
                return EnMoneyType.Metallic;
            }
        }

        public void GetDisplayOfMoneyFalling(int moneyValue)
        {
            //This method would display graphical representation of a metallic currency like a gold coin.
            Console.WriteLine(string.Format("Displaying a graphical object of {0} currency of value ${1} falling from sky.", 
                MoneyType.ToString(), moneyValue));
        }
    }
}
