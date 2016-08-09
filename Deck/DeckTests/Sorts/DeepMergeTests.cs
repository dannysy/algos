using System;
using System.Collections.Generic;
using CommonUtils.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;

namespace DeckTests.Sorts
{
    [TestClass]
    public class DeepMergeTests
    {
        [TestMethod]
        public void DeepMergeTest1()
        {
            var firstArr = new[] { 0, 3, 1, 2, 4, 7, 6, 8, 9, 5 };
            var secondArr = new[] { 13, 12, 10, 11, 14, 16, 17, 19, 15, 18 };
            var arrList = new List<int[]>(2);
            arrList.Add(SortUtils.MergeSort(firstArr, 10));
            arrList.Add(SortUtils.MergeSort(secondArr, 10));
            var merged = SortUtils.DeepMerge(arrList, 2, 10);
            var array = new [] { 0, 3, 1, 2, 4, 7, 6, 8, 9, 5, 13, 12, 10, 11, 14, 16, 17, 19, 15, 18 };
            Array.Sort(array);
            Assert.IsTrue(array.AreEqual(merged));
        }
    }
}