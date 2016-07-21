using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            
        }
    }
}