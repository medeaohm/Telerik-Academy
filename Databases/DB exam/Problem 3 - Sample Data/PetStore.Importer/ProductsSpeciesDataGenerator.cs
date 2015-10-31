namespace PetStore.Importer
{
    using System;
    using System.Linq;
    using PetStore.Data;
    using System.Collections.Generic;

    public class ProductsSpeciesDataGenerator : IDataGenerator
    {
        public void GenerateData(PetStoreEntities data, IRandomGenerator random, int count)
        {
            var productsIds = data.Products.Select(p => p.Id).ToList();
            var speciesIds = data.Species.Select(s => s.Id).ToList();

            foreach (var employeeId in productsIds)
            {
                var productsSpeciesCount = random.GetRandomNumber((int)(count * 0.5), (int)(count * 1.5));
                var currentProduct = new HashSet<int>();

                while (currentProduct.Count < productsSpeciesCount)
                {
                    var randomSpecieId = speciesIds[random.GetRandomNumber(0, speciesIds.Count - 1)];
                    currentProduct.Add(randomSpecieId);
                }

                //foreach (var productId in currentProduct)
                //{
                //    var endDateTimeSpan = random.GetRandomNumber(-500, 1000);
                //    var startDateTimeSpan = endDateTimeSpan + random.GetRandomNumber(1, 500);

                //    data.Products.Add(new ProjectsEmployee
                //    {
                //        EmployeeId = employeeId,
                //        ProjectId = projectId,
                //    });
                //}
            }
        }
    }
}
