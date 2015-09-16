using System;

namespace Flyweight
{
    class PaperMoney : IMoney
    {
        public EnMoneyType MoneyType
        {
            get
            {
                return EnMoneyType.Paper;
            }
        }

        public void GetDisplayOfMoneyFalling(int moneyValue) //GetExtrinsicState()
        {
            // This method would display a graphical representation of a paper currency.
            Console.WriteLine(string.Format("Displaying a graphical object of {0} currency of value ${1} falling from sky.", 
                MoneyType.ToString(), moneyValue));
        }
    }
}
