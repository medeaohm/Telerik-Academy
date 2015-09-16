namespace Flyweight
{
    public interface IMoney
    {
        EnMoneyType MoneyType
        {
            get;
        }

        void GetDisplayOfMoneyFalling(int moneyValue);
    }
}
