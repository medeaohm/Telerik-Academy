namespace Computers.Utilities.Factories
{
    using System.Collections.Generic;
    using Components;

    public class HPFactory : IComputerFactory
    {
        public const string Name = "HP";

        public PersonalComputer CreatePC()
        {
            return new PersonalComputer(new Cpu32(2), new Ram(2), new[] { new HardDriver(500) }, new ColorFullVideoCard());
        }

        public Laptop CreateLaptop()
        {
            return new Laptop(new Cpu64(2), new Ram(4), new[] { new HardDriver(500) }, new ColorFullVideoCard(), new Battery());
        }

        public Server CreateServer()
        {
            return new Server(
                new Cpu32(4),
                new Ram(32),
                new List<IHardDriver>
                    {
                        new RaidArray(new List<IHardDriver> { new HardDriver(1000), new HardDriver(1000) })
                    });
        }
    }
}
