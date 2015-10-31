namespace PetStore.Importer
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;

    public class SpeciesDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var countiesIds = data.Countries.Select(c => c.Id).ToList();

            var uniqueNames = new HashSet<string>();
            var countriesToBeAdded = new List<int>();

            while (uniqueNames.Count < count)
            {
                uniqueNames.Add(random.GetRandomString(random.GetRandomNumber(5, 50)).ToLower());
            }

            foreach (var countryId in countiesIds)
            {
                var countriesCount = random.GetRandomNumber((int)(0.15 * countiesIds.Count), (int)(0.35 * countiesIds.Count));
                for (int i = 0; i < countriesCount; i++)
                {
                    countriesToBeAdded.Add(countryId);
                }
            }

            var j = 0;
            foreach (var uniqueName in uniqueNames)
            {
                var specie = new Species { CountryId = countriesToBeAdded[j], Name = uniqueName };
                data.Species.Add(specie);
                j++;
            }
        }
    }
}
