namespace Computers.Utilities
{
    using System.Collections.Generic;
    using Components;

    public class Server : Computer
    {
        public Server(ICpu cpu, IRam ram, IEnumerable<IHardDriver> hardDrives)
            : base(cpu, ram, hardDrives, new MonochromeVideoCard())
        {
        }

        public void Process(int data)
        {
            this.Motherboard.SaveRamValue(data);
            this.Cpu.SquareNumber();
        }
    }
}
