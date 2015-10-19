using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputersTests
{
    using Computers.Utilities.Components; 

    [TestClass]
    public class LaptopBatteryChargeTests
    {
        private Battery battery;

        [TestInitialize]
        public void CreateNewBattery()
        {
            this.battery = new Battery();
        }

        [TestMethod]
        public void ChargeBatteryWith10ShouldRetourn60()
        {
            CreateNewBattery();
            this.battery.Charge(10);

            Assert.AreEqual(this.battery.Percentage, 60);
        }

        [TestMethod]
        public void ChargeBatteryWith0ShouldRetourn50()
        {
            CreateNewBattery();
            this.battery.Charge(0);

            Assert.AreEqual(this.battery.Percentage, 50);
        }

        [TestMethod]
        public void ChargeBatteryWithMinus10ShouldRetourn40()
        {
            CreateNewBattery();
            this.battery.Charge(-10);

            Assert.AreEqual(this.battery.Percentage, 40);
        }

        [TestMethod]
        public void ChargeBatteryWith60ShouldRetourn100()
        {
            CreateNewBattery();
            this.battery.Charge(60);

            Assert.AreEqual(this.battery.Percentage, 100);
        }

        [TestMethod]
        public void ChargeBatteryWithMinus60ShouldRetourn0()
        {
            CreateNewBattery();
            this.battery.Charge(-60);

            Assert.AreEqual(this.battery.Percentage, 0);
        }
    }
}
