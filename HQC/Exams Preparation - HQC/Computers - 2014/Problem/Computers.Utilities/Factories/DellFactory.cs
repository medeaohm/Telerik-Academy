namespace Computers.Utilities.Factories
{
    using System.Collections.Generic;
    using Components;

    public class DellFactory : IComputerFactory
    {
        public const string Name = "Dell";

        public PersonalComputer CreatePC()
        {
            return new PersonalComputer(new Cpu64(4), new Ram(8), new[] { new HardDriver(1000) }, new ColorFullVideoCard());
        }

        public Laptop CreateLaptop()
        {
            return new Laptop(new Cpu32(4), new Ram(8), new[] { new HardDriver(1000) }, new ColorFullVideoCard(), new Battery());
        }

        public Server CreateServer()
        {
            return new Server(
                new Cpu64(8),
                new Ram(64),
                new List<IHardDriver>
                    {
                        new RaidArray(new List<IHardDriver> { new HardDriver(2000), new HardDriver(2000) })
                    });
        }
    }
}
