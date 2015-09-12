namespace FactoryMethod
{
    using System;
    using System.Collections;

    public class MainApp
    {
        public static void Main()
        {
            // An array of creators 
            Creator[] creators = new Creator[2];
            creators[0] = new Pepsi();
            creators[1] = new CocaCola();

            // Iterate over creators and create products 
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0} by {1}", product.GetType().Name, creator.GetType().Name);
            }
        }
    }
}