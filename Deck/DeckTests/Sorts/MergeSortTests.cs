using CommonUtils.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;
using Sort.Tasks;

namespace DeckTests.Sorts
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void MergeSortTest1()
        {
            var sorted = SortUtils.MergeSort(new[] { 3, 2, 1 }, 3);
            Assert.IsTrue(sorted.AreEqual(new[] { 1, 2, 3 }));
            sorted = SortUtils.MergeSort(new[] { 1, 1, 1 }, 3);
            Assert.IsTrue(sorted.AreEqual(new[] { 1, 1, 1 }));
            sorted = SortUtils.MergeSort(new[] { 123, 34, 14, 63, 45, 21, 11, 4 }, 8);
            Assert.IsTrue(sorted.AreEqual(new[] { 4, 11, 14, 21, 34, 45, 63, 123 }));
        }

        [TestMethod]
        public void SectionPaintingTest1()
        {
            var xyPoints = new[]
            {
                new PointWithType(PointWithType.PointType.Start, 2), new PointWithType(PointWithType.PointType.End, 5),
                new PointWithType(PointWithType.PointType.Start, 1), new PointWithType(PointWithType.PointType.End, 3),
                new PointWithType(PointWithType.PointType.Start, 3), new PointWithType(PointWithType.PointType.End, 4),
                new PointWithType(PointWithType.PointType.Start, 7), new PointWithType(PointWithType.PointType.End, 9),
            };
            var sorted =
                SortUtils.MergeSort(
                    xyPoints, 8);
            var length = SectionPaintingMerge.CountSections(sorted);
            Assert.AreEqual(4, length);
            xyPoints = new[]
            {
                new PointWithType(PointWithType.PointType.Start, 1), new PointWithType(PointWithType.PointType.End, 4),
                new PointWithType(PointWithType.PointType.Start, 7), new PointWithType(PointWithType.PointType.End, 8),
                new PointWithType(PointWithType.PointType.Start, 2), new PointWithType(PointWithType.PointType.End, 5),
            };
            sorted =
                SortUtils.MergeSort(
                    xyPoints, 6);
            length = SectionPaintingMerge.CountSections(xyPoints);
            Assert.AreEqual(3, length);
            xyPoints = new[]
            {
                new PointWithType(PointWithType.PointType.Start, 1), new PointWithType(PointWithType.PointType.End, 10),
                new PointWithType(PointWithType.PointType.Start, 2), new PointWithType(PointWithType.PointType.End, 3),
                new PointWithType(PointWithType.PointType.Start, 4), new PointWithType(PointWithType.PointType.End, 8),
                new PointWithType(PointWithType.PointType.Start, 6), new PointWithType(PointWithType.PointType.End, 7),
            };
            sorted =
                SortUtils.MergeSort(
                    xyPoints, 8);
            length = SectionPaintingMerge.CountSections(xyPoints);
            Assert.AreEqual(4, length);
        }
    }
}