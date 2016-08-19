using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tree;

namespace DeckTests
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void BinaryTreeTest1()
        {
            var comparer = Comparer<int>.Default;
            var bTree = new BinaryTree<int>(comparer);
            var enumerator = new BinaryTreePostOrderEnumerator<int>(bTree);
            bTree.AddNode(2);
            bTree.AddNode(1);
            bTree.AddNode(3);
            enumerator.MoveNext();
            Assert.AreEqual(1, enumerator.Current);
            enumerator.MoveNext();
            Assert.AreEqual(3, enumerator.Current);
            enumerator.MoveNext();
            Assert.AreEqual(2, enumerator.Current);
        }

        [TestMethod]
        public void BinaryTreeTest2()
        {
            var comparer = Comparer<int>.Default;
            var bTree = new BinaryTree<int>(comparer);
            var enumerator = new BinaryTreePostOrderEnumerator<int>(bTree);
            bTree.AddNode(1);
            bTree.AddNode(2);
            bTree.AddNode(3);
            bTree.AddNode(4);
            enumerator.MoveNext();
            Assert.AreEqual(4, enumerator.Current);
            enumerator.MoveNext();
            Assert.AreEqual(3, enumerator.Current);
            enumerator.MoveNext();
            Assert.AreEqual(2, enumerator.Current);
            enumerator.MoveNext();
            Assert.AreEqual(1, enumerator.Current);
        }
    }
}