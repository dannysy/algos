using System;
using System.Text;
using BinarySearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinSearchUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            var result1 = RunMethod("15 32 37 41".Split(' '), "10".Split(' '));
            Assert.AreEqual(result1, "0");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result2 = RunMethod("10 20 30".Split(' '), "9 15 35".Split(' '));
            Assert.AreEqual(result2, "0 0 2");
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result3 = RunMethod("15 32 37 41 45 56 64 65 72 93".Split(' '), "53 7 97 80 21 10 75 46 62 52".Split(' '));
            Assert.AreEqual(result3, "5 0 9 8 0 0 8 4 6 5");
        }

        private string RunMethod(string[] array1, string[] array2)
        {
            var result = new StringBuilder();
            foreach (var secondValue in array2)
            {
                var index = Program.BinarySearchNearestElement(array1, secondValue);
                result.Append(index + " ");
            }
            var format = result.ToString();
            return format.Remove(format.Length - 1);
        }
    }
}
