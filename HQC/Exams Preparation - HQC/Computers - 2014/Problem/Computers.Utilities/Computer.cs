namespace Computers.Utilities
{
    using Components;
    using System.Collections.Generic;

    public abstract class Computer
    {
        protected Computer(
            ICpu cpu,
            IRam ram,
            IEnumerable<IHardDriver> hardDrives,
            IVideoCard videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            this.Motherboard = new Motherboard(this.Cpu, this.Ram, this.VideoCard);
        }

        public Motherboard Motherboard {get; set;}

        protected IEnumerable<IHardDriver> HardDrives
        {
            get; set;
        }

        protected IVideoCard VideoCard
        {
            get; set;
        }

        protected ICpu Cpu
        {
            get; set;
        }

        protected IRam Ram
        {
            get; set;
        }
    }
}
