namespace Singleton
{
    using System;
    using Singleton;

    public class StartupSingleton
    {
        public static void Main()
        {
            Singleton singleton = Singleton.Instance;
            Console.WriteLine();
        }
    }
}
