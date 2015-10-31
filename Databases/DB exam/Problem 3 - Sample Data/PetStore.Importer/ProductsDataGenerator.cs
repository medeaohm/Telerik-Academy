namespace PetStore.Importer
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using System;

    public class ProductsDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var categoriesIds = data.Categories.Select(c => c.Id).ToList();
            var categoriesToBeAdded = new List<int>();

            foreach (var categorieIds in categoriesIds)
            {
                var categoriesCount = random.GetRandomNumber(7 * categoriesIds.Count, 9 * categoriesIds.Count);

                for (int i = 0; i < categoriesIds.Count; i++)
                {
                    for (int j = 0; j < categoriesCount; j++)
                    {
                        categoriesToBeAdded.Add(categoriesIds[i]);
                    }
                }                
            }

            for (int i = 0; i < count; i++)
            {
                var product = new Product {
                    Price = random.GetRandomNumber(10, 1000),
                    CategoryId = categoriesToBeAdded[i],
                    Name = random.GetRandomString(random.GetRandomNumber(5, 25))
                };

                data.Products.Add(product);
            }
        }
    }
}
