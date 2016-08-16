using System;
using CommonUtils.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;

namespace DeckTests.Sorts
{
    [TestClass]
    public class LsdRadixSortTests
    {
        [TestMethod]
        public void LsdRadixSort1()
        {
            var sorted = SortUtils.LsdRadixSort(new[] { 3, 2, 1 }, 3);
            Assert.IsTrue(sorted.AreEqual(new[] { 1, 2, 3 }));
            sorted = SortUtils.LsdRadixSort(new[] { 1, 1, 1 }, 3);
            Assert.IsTrue(sorted.AreEqual(new[] { 1, 1, 1 }));
            sorted = SortUtils.LsdRadixSort(new[] { 123, 34, 14, 63, 45, 21, 11, 4 }, 8);
            Assert.IsTrue(sorted.AreEqual(new[] { 4, 11, 14, 21, 34, 45, 63, 123 }));
        }

        [TestMethod]
        public void LsdRadixSort2()
        {
            for (int j = 0; j < 100; j++)
            {
                Random rnd = new Random();
                var array = new int[1000000];
                var copy = new int[1000000];
                for (int i = 0; i < 1000000; i++)
                    array[i] = rnd.Next(1000000);
                array.CopyTo(copy, 0);
                Array.Sort(copy);
                SortUtils.LsdRadixSort(array, 1000000).AreEqual(copy);
            }
        }

        [TestMethod]
        public void RadixSort1()
        {
            var array = new[] { 3, 2, 1 };
            SortUtils.LsdRadixBitSort(array, 3);
            Assert.IsTrue(array.AreEqual(new[] { 1, 2, 3 }));
            var ints = new[] { 1, 1, 1 };
            var intsCopy = new[] { 1, 1, 1 };
            Array.Sort(intsCopy);
            SortUtils.LsdRadixBitSort(ints, 3);
            Assert.IsTrue(intsCopy.AreEqual(ints));
            var array1 = new[] { 123, 34, 14, 63, 45, 21, 11, 4 };
            var array1Copy = new[] { 123, 34, 14, 63, 45, 21, 11, 4 };
            Array.Sort(array1Copy);
            SortUtils.LsdRadixBitSort(array1, 8);
            Assert.IsTrue(array1.AreEqual(array1Copy));
        }

        [TestMethod]
        public void RadixSort2()
        {
            for (int j = 0; j < 100; j++)
            {
                Random rnd = new Random();
                var array = new int[1000000];
                var copy = new int[1000000];
                for (int i = 0; i < 1000000; i++)
                    array[i] = rnd.Next(1000000);
                array.CopyTo(copy, 0);
                Array.Sort(copy);
                SortUtils.LsdRadixBitSort(array, 1000000);
                array.AreEqual(copy);
            }
        }
    }
}