namespace Computers.Utilities.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RaidArray : IHardDriver
    {
        private const string NoHardDriveInTheRaidArrayMessage = "No hard drive in the RAID array!";

        private readonly IEnumerable<IHardDriver> hardDrives;

        public RaidArray()
        {
            this.hardDrives = new List<IHardDriver>();
        }

        public RaidArray(IEnumerable<IHardDriver> hardDrives)
        {
            this.hardDrives = hardDrives;
        }

        public int Capacity
        {
            get
            {
                if (!this.hardDrives.Any())
                {
                    return 0;
                }

                return this.hardDrives.First().Capacity;
            }
        }

        public IEnumerable<IHardDriver> HardDrives
        {
            get
            {
                return this.hardDrives;
            }
        }

        public void SaveData(int address, string newData)
        {
            foreach (var hardDrive in this.hardDrives)
            {
                hardDrive.SaveData(address, newData);
            }
        }

        public string LoadData(int address)
        {
            if (!this.hardDrives.Any())
            {
                throw new InvalidOperationException(NoHardDriveInTheRaidArrayMessage);
            }

            return this.hardDrives.First().LoadData(address);
        }
    }
}
