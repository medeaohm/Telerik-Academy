namespace Computers.Utilities.Factories
{
    public interface IComputerFactory
    {
        PersonalComputer CreatePC();

        Laptop CreateLaptop();

        Server CreateServer();
    }
}
