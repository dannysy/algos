using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriorityQ;

namespace DeckTests.Sorts
{
    [TestClass]
    public class MinHeapTests
    {
        [TestMethod]
        public void MinHeapTest1()
        {
            var minHeap = new MinHeap(100);
            var list = new List<int>(100);
            var random = new Random();
            foreach (var i in Enumerable.Range(1, 99))
            {
                var priority = random.Next(0, 1000);
                list.Add(priority);
                minHeap.InsertWithPriority(priority);
            }
            Assert.AreEqual(99, minHeap.Length);
            foreach (var i in Enumerable.Range(1, 99))
            {
                var min = list.Min();
                Assert.AreEqual(min, minHeap.GetNext());
                list.Remove(min);
            }
        }
    }
}