namespace Computers.Utilities.Components
{
    public interface ICpu : IMotherboardComponent
    {
        byte NumberOfCores { get; set; }

        void SquareNumber();

        void GenerateRandomNumber(int min, int max);
    }
}
