namespace PetStore.ConsoleClient
{
    using Importer;
    using Data;
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var dataGeneratorExecutors = new List<DataGeneratorExecutor>
                                             {
                                                 new DataGeneratorExecutor(new CountriesDataGenerator(), 20),
                                                 new DataGeneratorExecutor(new CategoriesDataGenerator(), 50),
                                                 new DataGeneratorExecutor(new SpeciesDataGenerator(), 100),
                                                 new DataGeneratorExecutor(new PetsDataGenerator(), 5000),
                                                 new DataGeneratorExecutor(new ProductsDataGenerator(), 20000),
                                             };

            foreach (var dataGeneratorExecutor in dataGeneratorExecutors)
            {
                using (var data = new PetStoreEntities())
                {
                    //data.Configuration.AutoDetectChangesEnabled = true;
                    //// data.Configuration.ProxyCreationEnabled = false;

                    Console.WriteLine("Staring {0}...", dataGeneratorExecutor.DataGenerator.GetType().Name);
                    dataGeneratorExecutor.Execute(data, RandomGenerator.Instance);
                    Console.WriteLine("Saving {0}...", dataGeneratorExecutor.DataGenerator.GetType().Name);
                    data.SaveChanges();
                    Console.WriteLine("Finished {0}.", dataGeneratorExecutor.DataGenerator.GetType().Name);
                }
            }
        }
    }
}
