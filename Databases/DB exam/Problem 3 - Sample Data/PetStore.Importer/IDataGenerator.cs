namespace PetStore.Importer
{
    using PetStore.Data;

    public interface IDataGenerator
    {
        void GenerateData(PetStoreEntities data, IRandomGenerator random, int count);
    }
}
