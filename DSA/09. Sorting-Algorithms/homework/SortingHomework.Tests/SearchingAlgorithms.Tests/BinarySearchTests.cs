using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingHomework.Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void BinarySearch()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 7, 0 });

            bool result = collection.BinarySearch(7);

            Assert.AreEqual(result, true);
        }


        [TestMethod]
        public void BinarySearchNonExisting()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            bool result = collection.BinarySearch(-1);

            Assert.IsFalse(result);
        }

    }
}