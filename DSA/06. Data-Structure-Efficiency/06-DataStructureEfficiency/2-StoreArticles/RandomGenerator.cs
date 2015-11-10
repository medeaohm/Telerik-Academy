namespace RandomGenerator
{
    using System;

    public class RandomGenerator
    {
        private const string Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        private readonly Random random;

        public RandomGenerator()
        {
            this.random = new Random();
        }

        public decimal GetRandomNumber(int min, int max)
        {
            return this.random.Next(min*1000, max*1000 + 1)/1000;
        }

        public string GetRandomString(int length)
        {
            var chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = Letters[((int)this.GetRandomNumber(0, Letters.Length - 1))];
            }

            return new string(chars);
        }
    }
}
