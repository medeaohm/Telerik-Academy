namespace Computers.Utilities.Components
{
    public interface IHardDriver
    {
        int Capacity
        {
            get;       
        }

        void SaveData(int address, string newData);

        string LoadData(int address);
    }
}
