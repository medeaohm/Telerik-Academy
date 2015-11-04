namespace Hash.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Hash;

    [TestClass]
    public class HashedSetTests
    {
        [TestMethod]
        public void InitialCapacityShouldBeEqualTo16()
        {
            var hash = new HashedSet<int>();
            Assert.AreEqual(16, hash.Capacity);
        }

        [TestMethod]
        public void CountOfEmptyHashTableShouldBe0()
        {
            var hash = new HashedSet<int>();
            Assert.AreEqual(0, hash.Count);
        }

        [TestMethod]
        public void KeysCountShouldWorkProperly()
        {
            var hash = new HashedSet<string>();
            hash.Add("Mitko");
            Assert.AreEqual(1, hash.Count);
        }

        [TestMethod]
        public void AddShouldProperlyWork()
        {
            var hash = new HashedSet<string>();
            hash.Add("Pesho");
            Assert.AreEqual(1, hash.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddWithExistingKeyShouldThrow()
        {
            var hash = new HashedSet<string>();
            hash.Add("Pesho");
            hash.Add("Pesho");
        }

        [TestMethod]
        public void CapacityShouldDuplicateWhenHashTableIsFullForMoreThan75Percent()
        {
            var hash = new HashedSet<int>();
            for (int i = 0; i < 12; i++)
            {
                hash.Add(i);
            }

            Assert.AreEqual(32, hash.Capacity);
        }

        [TestMethod]
        public void FindShouldProperlyWork()
        {
            var hash = new HashedSet<string>();
            hash.Add("Pesho");

            Assert.AreEqual(true, hash.Find("Pesho"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindWithInvalidKeyShouldThrow()
        {
            var hash = new HashedSet<string>();
            hash.Add("Mimi");

            var value = hash.Find("Pesho");
        }

        [TestMethod]
        public void RemoveShouldProperlyWork()
        {
            var hash = new HashedSet<int>();
            hash.Add(6);
            hash.Remove(6);
            Assert.AreEqual(0, hash.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveWithInvalidKeyShouldThrow()
        {
            var hash = new HashedSet<string>();
            hash.Remove("Pesho");
        }

        [TestMethod]
        public void ClearShouldProperlyWork()
        {
            var hash = new HashedSet<int>();
            hash.Add(2);
            hash.Clear();
            Assert.AreEqual(0, hash.Count);
            Assert.AreEqual(16, hash.Capacity);
        }
    }
}
