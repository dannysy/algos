using Deck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeckTests
{
    [TestClass]
    public class DeckTaskTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var deck = new Deck<int>();
            var result = Runner.GetResult(new [] {"1", "44"}, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new [] { "3", "50" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new [] { "2", "44" }, deck);
            Assert.AreEqual("YES", result);
            result = Runner.GetResult(new[] { "2", "50" }, deck);
            Assert.AreEqual("YES", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var deck = new Deck<int>();
            var result = Runner.GetResult(new[] { "2", "50" }, deck);
            Assert.AreEqual("NO", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var deck = new Deck<int>();
            var result = Runner.GetResult(new[] { "2", "-1" }, deck);
            Assert.AreEqual("YES", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var deck = new Deck<int>();
            var result = Runner.GetResult(new[] { "1", "44" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "3", "50" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "2", "44" }, deck);
            Assert.AreEqual("YES", result);
            result = Runner.GetResult(new[] { "2", "50" }, deck);
            Assert.AreEqual("YES", result);
            result = Runner.GetResult(new[] { "2", "-1" }, deck);
            Assert.AreEqual("YES", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var deck = new Deck<int>();
            var result = Runner.GetResult(new[] { "1", "50" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "2", "-1" }, deck);
            Assert.AreEqual("NO", result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var deck = new Deck<int>();
            var result = Runner.GetResult(new[] { "1", "50" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "4", "50" }, deck);
            Assert.AreEqual("YES", result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var deck = new Deck<int>();
            var result = Runner.GetResult(new[] { "3", "50" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "4", "50" }, deck);
            Assert.AreEqual("YES", result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var deck = new IntArrayDeck(100000);
            var result = Runner.GetResult(new[] { "1", "44" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "3", "50" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "2", "44" }, deck);
            Assert.AreEqual("YES", result);
            result = Runner.GetResult(new[] { "2", "50" }, deck);
            Assert.AreEqual("YES", result);
        }

        [TestMethod]
        public void TestMethod22()
        {
            var deck = new IntArrayDeck(100000);
            var result = Runner.GetResult(new[] { "2", "50" }, deck);
            Assert.AreEqual("NO", result);
        }

        [TestMethod]
        public void TestMethod33()
        {
            var deck = new IntArrayDeck(100000);
            var result = Runner.GetResult(new[] { "2", "-1" }, deck);
            Assert.AreEqual("YES", result);
        }

        [TestMethod]
        public void TestMethod44()
        {
            var deck = new IntArrayDeck(100000);
            var result = Runner.GetResult(new[] { "1", "44" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "3", "50" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "2", "44" }, deck);
            Assert.AreEqual("YES", result);
            result = Runner.GetResult(new[] { "2", "50" }, deck);
            Assert.AreEqual("YES", result);
            result = Runner.GetResult(new[] { "2", "-1" }, deck);
            Assert.AreEqual("YES", result);
        }

        [TestMethod]
        public void TestMethod55()
        {
            var deck = new IntArrayDeck(100000);
            var result = Runner.GetResult(new[] { "1", "50" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "2", "-1" }, deck);
            Assert.AreEqual("NO", result);
        }

        [TestMethod]
        public void TestMethod66()
        {
            var deck = new IntArrayDeck(100000);
            var result = Runner.GetResult(new[] { "1", "50" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "4", "50" }, deck);
            Assert.AreEqual("YES", result);
        }

        [TestMethod]
        public void TestMethod77()
        {
            var deck = new IntArrayDeck(100000);
            var result = Runner.GetResult(new[] { "3", "50" }, deck);
            Assert.AreEqual("", result);
            result = Runner.GetResult(new[] { "4", "50" }, deck);
            Assert.AreEqual("YES", result);
        }
    }
}
