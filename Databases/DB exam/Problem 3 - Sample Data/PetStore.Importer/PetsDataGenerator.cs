namespace PetStore.Importer
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using System;

    public class PetsDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var speciesIds = data.Species.Select(s => s.Id).ToList();
            var speciesToBeAdded = new List<int>();

            foreach (var specieIds in speciesIds)
            {
                var speciesCount = random.GetRandomNumber((int)(0.3 * speciesIds.Count), (int)(0.7 * speciesIds.Count));

                for (int i = 0; i < speciesIds.Count; i++)
                {
                    for (int j = 0; j < speciesCount; j++)
                    {
                        speciesToBeAdded.Add(speciesIds[i]);
                    }
                }                
            }

            for (int i = 0; i < count; i++)
            {
                var pet = new Pet 
                {
                    Price = random.GetRandomNumber(5, 2500),
                    ColorId = random.GetRandomNumber(1, 4),
                    SpecieId = speciesToBeAdded[i],
                    DateOfBirth = DateTime.Now.AddDays(-random.GetRandomNumber(60,1800)),
                };

                data.Pets.Add(pet);
            }
        }
    }
}
