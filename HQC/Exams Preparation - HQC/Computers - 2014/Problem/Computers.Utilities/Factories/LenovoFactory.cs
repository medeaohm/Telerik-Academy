namespace Computers.Utilities.Factories
{
    using System.Collections.Generic;
    using Components;

    public class LenovoFactory : IComputerFactory
    {
        public const string Name = "Lenovo";

        public PersonalComputer CreatePC()
        {
            return new PersonalComputer(new Cpu64(2), new Ram(4), new[] { new HardDriver(2000) }, new MonochromeVideoCard());
        }

        public Laptop CreateLaptop()
        {
            return new Laptop(new Cpu64(2), new Ram(16), new[] { new HardDriver(1000) }, new ColorFullVideoCard(), new Battery());
        }

        public Server CreateServer()
        {
            return new Server(
                new Cpu128(2),
                new Ram(8),
                new List<IHardDriver>
                    {
                        new RaidArray(new List<IHardDriver> { new HardDriver(500), new HardDriver(500) })
                    });
        }
    }
}
