namespace PetStore.Importer
{
    using System.Collections.Generic;
    using Data;

    public class CategoriesDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var category = new Category { Name = random.GetRandomString(random.GetRandomNumber(5, 20)) };
                data.Categories.Add(category);
            }
        }
    }
}
