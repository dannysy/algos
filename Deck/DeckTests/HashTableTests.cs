using System.Collections;
using HashTable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeckTests
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void HashTableTest1()
        {
            var ht = new OAHashTable<int, int>(4);
            ht.Put(1, 1);
            Assert.IsTrue(ht.ContainsKey(1));
            Assert.IsTrue(!ht.ContainsKey(2));
            Assert.IsTrue(ht.Delete(1));
            Assert.IsTrue(!ht.Delete(1));
            ht.Put(1, 1);
            ht.Put(2, 1);
            ht.Put(3, 1);
            ht.Put(4, 1);
            Assert.IsTrue(ht.ContainsKey(4));
        }

        [TestMethod]
        public void HashTableTest2()
        {
            var ht = new OAHashTable<string, string>(4);
            Assert.AreEqual("OK", Output(ht.Put("hello", "hello")));
            Assert.AreEqual("OK", Output(ht.Put("bye", "bye")));
            Assert.AreEqual("OK", Output(ht.ContainsKey("bye")));
            Assert.AreEqual("FAIL", Output(ht.Put("bye", "bye")));
            Assert.AreEqual("OK", Output(ht.Delete("bye")));
            Assert.AreEqual("FAIL", Output(ht.ContainsKey("bye")));
            Assert.AreEqual("OK", Output(ht.ContainsKey("hello")));
        }

        public string Output(bool condition)
        {
            return condition ? "OK" : "FAIL";
        }
    }
}