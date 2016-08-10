using System;
using CommonUtils.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;

namespace DeckTests.Sorts
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void QuickSortTest1()
        {
            var sorted = SortUtils.QuickSort(new[] { 3, 2, 1 }, 3);
            Assert.IsTrue(sorted.AreEqual(new[] { 1, 2, 3 }));
            sorted = SortUtils.QuickSort(new[] { 1, 1, 1 }, 3);
            Assert.IsTrue(sorted.AreEqual(new[] { 1, 1, 1 }));
            sorted = SortUtils.QuickSort(new[] { 123, 34, 14, 63, 45, 21, 11, 4 }, 8);
            Assert.IsTrue(sorted.AreEqual(new[] { 4, 11, 14, 21, 34, 45, 63, 123 }));
            sorted = SortUtils.QuickSort(new[] { 11, 34, 14, 63, 45, 21, 123, 4 }, 8);
            Assert.IsTrue(sorted.AreEqual(new[] { 4, 11, 14, 21, 34, 45, 63, 123 }));
        }

        [TestMethod]
        public void QuickSortTest2()
        {
            for (int j = 0; j < 100; j++)
            {
                Random rnd = new Random();
                var array = new int[100];
                for (int i = 0; i < 100; i++)
                    array[i] = rnd.Next(1000);
                var sorted = SortUtils.QuickSort(array, 100);
                Array.Sort(array);
                Assert.IsTrue(sorted.AreEqual(array));
            }
        }
    }
}