using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;

namespace DeckTests
{
    [TestClass]
    public class PasteSortTest
    {
        [TestMethod]
        public void PSTest()
        {
            var array = new[] {3, 4, 5, 6, 2, 1};
            var sorted = SortUtils.PasteSort(array, 6);
            var answer = new[]{ 1, 2, 3, 4, 5, 6};
            for (int i = 0; i < 6; i++)
            {
                Assert.AreEqual(answer[i], sorted[i]);
            }
        }

        [TestMethod]
        public void PSTest2()
        {
            var array = new[] { 2, 1, 0, 0 };
            var sorted = SortUtils.PasteSort(array, 4);
            var answer = new[] { 0, 0, 1, 2 };
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(answer[i], sorted[i]);
            }
        }

        [TestMethod]
        public void PSTest3()
        {
            var array = new[] { 2 };
            var sorted = SortUtils.PasteSort(array, 1);
            var answer = new[] { 2 };
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(answer[i], sorted[i]);
            }
        }

    }
}