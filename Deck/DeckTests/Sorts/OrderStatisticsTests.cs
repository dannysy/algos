using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;
using Sort.Tasks;

namespace DeckTests.Sorts
{
    [TestClass]
    public class OrderStatisticsTests
    {
        [TestMethod]
        public void OrderStatisticTest1()
        {
            var array = "3 6 5 7 2 9 8 10 4 1".Split(' ').Select(int.Parse).ToArray();
            var kstatDc = OrderStatistics.KstatDc(array, 10, 0);
            Assert.AreEqual(1, kstatDc);
        }

        [TestMethod]
        public void OrderStatisticTest2()
        {
            var array = "182 173 788 9 991 735 523 562 337 798 641 129 709 659 449 749 20 960 831 279 652 526 660 243 912 377 30 105 871 435 578 330 289 145 985 700 49 606 455 978 794 740 198 313 454 383 150 914 698 551 21 549 794 116 659 656 513 544 97 614 704 418 690 902 220 311 839 564 674 749 699 413 504 852 484 912 327 347 788 528 227 115 407 319 413 28 536 173 485 328 186 504 509 841 273 376 49 296 92 143".Split(' ').Select(int.Parse).ToArray();
            var kstatDc = OrderStatistics.KstatDc(array, 100, 6);
            SortUtils.QuickSort(array, 100);
            Assert.AreEqual(array[6], kstatDc);
        }

        [TestMethod]
        public void OrderStatisticTest3()
        {
            for (int j = 0; j < 100; j++)
            {
                Random rnd = new Random();
                var array = new int[100];
                var copy = new int[100];
                var copyDebug = new int[100];
                for (int i = 0; i < 100; i++)
                    array[i] = rnd.Next(1000);
                array.CopyTo(copy, 0);
                array.CopyTo(copyDebug, 0);
                SortUtils.QuickSort(array, 100);
                var kstatDc = OrderStatistics.KstatDc(copy, 100, 6);
                Assert.AreEqual(array[6], kstatDc);
            }
        }
    }
}