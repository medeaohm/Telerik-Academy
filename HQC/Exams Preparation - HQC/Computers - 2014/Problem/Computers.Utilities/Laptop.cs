namespace Computers.Utilities
{
    using System.Collections.Generic;
    using Components;

    public class Laptop : Computer
    {
        private const string BatteryStatusMessage = "Battery status: {0}%";

        private readonly IBattery battery;

        public Laptop(ICpu cpu, IRam ram, IEnumerable<HardDriver> hardDrives, IVideoCard videoCard, IBattery battery)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.battery = battery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            this.Motherboard.DrawOnVideoCard(string.Format(BatteryStatusMessage, this.battery.Percentage));
        }
    }
}
