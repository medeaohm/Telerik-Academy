namespace FindProductsInPriceRange
{
    public interface IRandomGenerator
    {
        decimal GetRandomNumber(int min, int max);

        string GetRandomString(int length);
    }
}
