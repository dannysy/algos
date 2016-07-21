using Brackets;
using Deck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeckTests
{
    [TestClass]
    public class BracketTests
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual("{}[[([{[]}])]]", BracketParser.IsGood("{}[[([{[]}])]]"));
            Assert.AreEqual("{}[[([{[]}])]]", BracketParser.IsGood("}[[([{[]}"));
            Assert.AreEqual("IMPOSSIBLE", BracketParser.IsGood("{][[[[{}[]"));
            Assert.AreEqual("", BracketParser.IsGood(""));
        }
    }
}