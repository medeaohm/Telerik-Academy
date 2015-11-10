namespace FindProductsInPriceRange
{
    using System;

    public class RandomGenerator : IRandomGenerator
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private readonly Random random;

        public RandomGenerator()
        {
            this.random = new Random();
        }

        public decimal GetRandomNumber(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }

        public string GetRandomString(int length)
        {
            var chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = Letters[(int)this.GetRandomNumber(0, Letters.Length - 1)];
            }

            return new string(chars);
        }
    }
}
