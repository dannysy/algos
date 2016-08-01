using CommonUtils.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;

namespace DeckTests
{
    [TestClass]
    public class MergeSortTest
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
    }
}