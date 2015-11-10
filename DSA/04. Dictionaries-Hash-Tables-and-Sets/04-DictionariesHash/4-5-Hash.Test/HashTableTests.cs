namespace Hash.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Hash;

    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void InitialCapacityShouldBeEqualTo16()
        {
            var table = new HashTable<int, int>();
            Assert.AreEqual(16, table.Capacity);
        }

        [TestMethod]
        public void CountOfEmptyHashTableShouldBe0()
        {
            var table = new HashTable<int, int>();
            Assert.AreEqual(0, table.Count);
        }

        [TestMethod]
        public void KeysCountShouldWorkProperly()
        {
            var table = new HashTable<string, int>();
            table.Add("Mitko", 8);
            Assert.AreEqual(1, table.Keys.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IndexerWithInvalidIndexShouldThrow()
        {
            var table = new HashTable<string, int>();
            table.Add("Mimi", 3);
            var value = table[string.Empty];
        }

        [TestMethod]
        public void AddShouldProperlyWork()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            Assert.AreEqual(1, table.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddWithExistingKeyShouldThrow()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            table.Add("Pesho", 6);
        }

        [TestMethod]
        public void CapacityShouldDuplicateWhenHashTableIsFullForMoreThan75Percent()
        {
            var table = new HashTable<string, int>();
            for (int i = 0; i < 12; i++)
            {
                table.Add("Pesho" + i, i);
            }

            Assert.AreEqual(32, table.Capacity);
        }

        [TestMethod]
        public void FindShouldProperlyWork()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);

            Assert.AreEqual(6, table.Find("Pesho"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindWithInvalidKeyShouldThrow()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);

            var value = table.Find("Peho");
        }

        [TestMethod]
        public void RemoveShouldProperlyWork()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            table.Remove("Pesho");
            Assert.AreEqual(0, table.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveWithInvalidKeyShouldThrow()
        {
            var table = new HashTable<string, int>();
            table.Remove("Pesho");
        }

        [TestMethod]
        public void ClearShouldProperlyWork()
        {
            var table = new HashTable<string, int>();
            table.Add("Pesho", 6);
            table.Clear();
            Assert.AreEqual(0, table.Count);
            Assert.AreEqual(16, table.Capacity);
        }
    }
}
