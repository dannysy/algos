using System;
using System.Linq;
using CommonUtils.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriorityQ;

namespace DeckTests
{
    [TestClass]
    public class XYPriorityQueueTests
    {
        [TestMethod]
        public void XYPointCompareTest()
        {
            var first = new XYPoint(1, 1);
            var second = new XYPoint(1, 1);
            Assert.AreEqual(0, first.CompareTo(second));
            first = new XYPoint(1, 3);
            second = new XYPoint(1, 1);
            Assert.AreEqual(1, first.CompareTo(second));
            first = new XYPoint(5, 1);
            second = new XYPoint(1, 1);
            Assert.AreEqual(1, first.CompareTo(second));
            first = new XYPoint(1, 1);
            second = new XYPoint(1, 3);
            Assert.AreEqual(-1, first.CompareTo(second));
            first = new XYPoint(1, 1);
            second = new XYPoint(5, 1);
            Assert.AreEqual(-1, first.CompareTo(second));
        }

        [TestMethod]
        public void XYpriorityQueueTest()
        {
            var xyPoints = new[] {new XYPoint(1, 0), new XYPoint(1, 1), new XYPoint(0, 0), new XYPoint(0, 1)};
            var sortedXyPoints = new[] { new XYPoint(1, 1), new XYPoint(1, 0), new XYPoint(0, 0), new XYPoint(0, 1) };
            var xyPriorityQueue = new XYPriorityQueue(xyPoints);
            Assert.IsTrue(sortedXyPoints.AreEqual(xyPriorityQueue.ToArray()));
            xyPoints = new[] { new XYPoint(0, 0), new XYPoint(0, 0), new XYPoint(0, 0), new XYPoint(0, 0) };
            xyPriorityQueue = new XYPriorityQueue(xyPoints);
            foreach (var xyPoint in xyPoints)
            {
                Assert.IsTrue(xyPriorityQueue.GetNext().CompareTo(xyPoint) == 0);
            }
            xyPoints = new[] { new XYPoint(123, 2), new XYPoint(14, 23), new XYPoint(223, 4), new XYPoint(0, 0) };
            xyPriorityQueue = new XYPriorityQueue(xyPoints);
            Array.Sort(xyPoints);
            foreach (var xyPoint in xyPoints.Reverse())
            {
                Assert.IsTrue(xyPriorityQueue.GetNext().CompareTo(xyPoint) == 0);
            }
        }
    }
}