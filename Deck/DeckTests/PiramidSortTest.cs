using System;
using System.Linq;
using System.Text;
using CommonUtils.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriorityQ;
using Sort;

namespace DeckTests
{
    [TestClass]
    public class PiramidSortTest
    {
        [TestMethod]
        public void PyramidSort()
        {
            var sorted = SortUtils.PyramidSort(new[] {3, 2, 1}, 3);
            Assert.IsTrue(sorted.AreEqual(new[] {1, 2, 3}));
            sorted = SortUtils.PyramidSort(new[] { 1, 1, 1 }, 3);
            Assert.IsTrue(sorted.AreEqual(new[] { 1, 1, 1 }));
            sorted = SortUtils.PyramidSort(new[] { 123, 34, 14, 63, 45, 21, 11, 4 }, 8);
            Assert.IsTrue(sorted.AreEqual(new[] { 4, 11, 14, 21, 34, 45, 63, 123 }));
            Random rnd = new Random();
            var array = new int[100];
            for (int i = 0; i < 100; i++)
                array[i] = rnd.Next(1000);
            sorted = SortUtils.PyramidSort(array, 100);
            Array.Sort(array);
            Assert.IsTrue(sorted.AreEqual(array));
        }

        [TestMethod]
        public void SolveCurveTest()
        {
            var result = SolveCurve(new [] { new XYPoint(0, 0), new XYPoint(1, 1), new XYPoint(1, 0), new XYPoint(0, 1) }, 4);
            var expected = "0 0\r\n" + "0 1\r\n" + "1 0\r\n" + "1 1\r\n";
            Assert.AreEqual(expected, result);
            result = SolveCurve(new[] { new XYPoint(0, 0), new XYPoint(0, 0), new XYPoint(0, 0), new XYPoint(0, 0) }, 4);
            expected = "0 0\r\n" + "0 0\r\n" + "0 0\r\n" + "0 0\r\n";
            Assert.AreEqual(expected, result);
            result = SolveCurve(new[] { new XYPoint(0, 0), new XYPoint(0, 0), new XYPoint(1, 1), new XYPoint(1, 1) }, 4);
            expected = "0 0\r\n" + "0 0\r\n" + "1 1\r\n" + "1 1\r\n";
            Assert.AreEqual(expected, result);
        }

        private string SolveCurve(XYPoint[] points, int count)
        {
            var sorted = SortUtils.XYPyramidSort(points);
            var result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.AppendLine(sorted[i].ToString());
            }
            return result.ToString();
        }
    }
}