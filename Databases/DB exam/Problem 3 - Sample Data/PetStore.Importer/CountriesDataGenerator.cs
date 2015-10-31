namespace PetStore.Importer
{
    using System.Collections.Generic;
    using Data;

    public class CountriesDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var uniqueNames = new HashSet<string>();

            while (uniqueNames.Count < count)
            {
                uniqueNames.Add(random.GetRandomString(random.GetRandomNumber(5, 50)));
            }

            foreach (var uniqueName in uniqueNames)
            {
                var country = new Country { Name = uniqueName };
                data.Countries.Add(country);
            }
        }
    }
}
