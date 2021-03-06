﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriorityQ;

namespace DeckTests.Sorts
{
    [TestClass]
    public class PrirityQueueTests
    {
        [TestMethod]
        public void Test1()
        {
            var priorityQueue = new PriorityQueue(100);
            var list = new List<int>(100);
            var random = new Random();
            foreach (var i in Enumerable.Range(1, 99))
            {
                var priority = random.Next(0, 1000);
                list.Add(priority);
                priorityQueue.InsertWithPriority(priority);
            }
            Assert.AreEqual(99, priorityQueue.Length);
            foreach (var i in Enumerable.Range(1, 99))
            {
                var maxI = list.Max();
                Assert.AreEqual(maxI, priorityQueue.GetNext());
                list.Remove(maxI);
            }
        }

        [TestMethod]
        public void Test2()
        {
            var priorityQueue = new PriorityQueue(10);
            var list = new List<int>(10);
            foreach (var i in Enumerable.Range(1, 10))
            {
                list.Add(i);
                priorityQueue.InsertWithPriority(i);
            }
            Assert.AreEqual(10, priorityQueue.Length);
            foreach (var i in Enumerable.Range(1, 10))
            {
                var maxI = list.Max();
                Assert.AreEqual(maxI, priorityQueue.GetNext());
                list.Remove(maxI);
            }
        }

        [TestMethod]
        public void Test3()
        {
            var steps = VovaLogic.Solve(3, Enumerable.Range(1, 3).ToArray(), 3);
            Assert.AreEqual(3, steps);
            var array =
                "34 20 33 8 35 10 9 6 7 18 3 24 35 14 8 27 34 7 22 13 18 4 28 12 26 15 34 11 7 13 12 33 24 24 18 20 3 7 13 9 8 10 14 22 26 15 7 12 24 13 23 35 18 19 34 21 9 27 17 22 17 28 22 33 31 29 30 29 32 17 28 5 7 4 15 22 7 4 6 20 9 24 35 28 29 13 17 5 32 23 30 12 9 12 6 30 8 35 14 15 30 31 8 29 28 23 1 6 3 30 14 8 10 15 35 17 12 19 25 15 9 5 3 28 20 10 1 23 32 5 26 35 32 10 27 3 32 11 24 25 21 8 9 20 2 25 7 11 24 7 35 7 3 9 11 15 14 21 16 33"
                    .Split(' ');
            var intArray = new List<int>(160);
            Array.ForEach(array, s => intArray.Add(int.Parse(s)));
            steps = VovaLogic.Solve(160, intArray.ToArray(), 35);
            Assert.AreEqual(181, steps);
            array =
                "2 5 6 4 6 3 3 3 1 2 3 3 5 5 3 5 2 5 3 4 1 2 1 2 6 2 5 3 5 4 6 3 6 3 5 4 5 5 1 2 1 1 3 6 1 4 5 6 2 4 4 3 4 3 4 1 6 6 1 2 1 4 6 1 3 1 5 5 6 1 4 5 5 1 4 1 5 3 3 6 4 5 1 5 2 6 4 3 1 6 6 3 1 5 3 1 3 4 5 4 5 3 5 3 2 5 1 1 3 5 1 1 6 6 3 3 6 4 6 4 3 5 4 2 3 6 1 6 4 2 4 6 3 5 5 2 2 4 6 4 6 5 5 2 6 3 3 6 1 6 6 1 6 1 5 2 2 1 5 5 1 6 2 1 1 6 1 5 5 5 1 2 4 3 3 5 1 5 4 4 5 1 5 3 4 1 5 6 3 4 6 1 3 6 1 2 4 4 2 4 4 4 1 5 6 2 6 5 2 1 6 2 2 4 4 4 5 2 2 6 5 1 6 2 3 2 5 5 6 4 2 4 3 2 3 1 5 3 2 5 1 5 3 6 6 4 5 1 6 1 3 3 2 3 4 6 4 2 1 3 6 3 4 6 3 6 1 1 1 6 1 1 5 3 1 6 1 5 2 5 6 3 4 5 5 5 6 3 3 4 1 2 5 5 6 1 5 4 1 6 6 6 5 6 4 5 4 4 1 4 3 6 5 5 5 6 6 3 1 2 6 3 4 4 3 5 4 4 2 5 3 4 1 6 2 1 4 2 3 4 4 1 3 4 5 5 3 1 2 1 4 5 5 5 4 2 4 4 5 2 1 6 3 5 1 5 5 4 6 3 4 5 1 3 5 3 6 5 3 5 2 4 5 2 5 1 2 1 4 1 1 4 4 4 3 2 5 3 3 2 3 3 6 5 2 3 3 5 3 1 3 2 1 2 5 5 4 2 1 1 4 3 6 3 4 1 4 6 1 2 2 6 5 4 6 5 6 5 1 1 6 6 2 3 5 5 1 4 1 3 3 2 3 4 3 2 2 5 5 5 6 1 6 5 5 6 5 4 4 2 1 3 2 5 5 6 1 6 2 3 4 5 6 3 4 6 3 2 5 2 1 4 3 3 5 2 1 6 1 2 1 1 1 3 4 4 5 2 2 2 4 4 2 3 1 6 6 1 6 2 2 4 3 5 1 5 3 3 2 6 5 5 2 2 2 5 4 5 4 1 5 1 6 2 5 2 4 3 4 5 6 1 3 2 2 3 5 1 2 1 1 4 3 2 4 2 6 1 4 4 4 5 3 4 3 6 2 3 3 6 2 1 1 2 5 1 3 4 4 5 2 4 1 6 1 5 3 4 2 3 1 4 6 6 4 1 1 4 2 6 4 1 4 3 4 1 5 3 2 3 6 3 1 6 4 2 5 4 5 3 3 5 1 5 3 2 3 6 4 3 2 4 3 5 5 1 6 3 1 6 4 5 6 3 5 6 4 5 6 1 5 6 4 2 1 2 4 6 6 4 4 4 4 3 2 5 2 1 4 6 5 2 1 4 2 4 2 3 4 2 4 6 1 6 3 3 3 4 3 1 6 1 2 1 1 6 5 2 2 3 5 1 6 3 2 1 1 1 4 5 6 5 6 3 2 3 4 2 5 2 1 1 1 3 6 2 6 2 1 4 6 2 4 1 5 4 5 3 6 3 3 1 6 4 4 2 2 3 6 4 3 4 5 3 1 2 3 6 1 4 4 2 6 4 1 1 1 3 4 6 6 1 6 1 3 3 3 3 1 6 3 6 2 1 2 1 6 4 1 5 6 5 4 1 2 2 5 4 2 4 1 5 3 3 5 1 2 3 2 4 4 5 3 3 3 6 6 1 1 3 6 5 6 2 3 4 5 2 2 5 6 4 6 2 2 6 2 4 2 5 4 6 5 3 6 2 6 3 5 3 5 4 6 2 4 6 4 6 2 6 6 1 5 6 2 6 3 1 1 1 2 1 4 2 5 6 1 4 5 6 1 4 2 3 1 4 4 6 2 6 3 5 6 2 2 2 6 6 3 2 6 3 3 5 2 3 5 3 2 3 6 6 3 2 2 2 2 1 5 6 6 6 5 5 2 6 4 6 1 2 1 2 6 5 1 6 4 1 4 4 4 4 6 2 5 1 3 4 3 1 3 5 6 1 3 4 3 1 4 1 6 3 2 1 1 2 2 4 6 1 5 4 4 5 4 1 4 6 2 6 6 3 5 3 6 3 5 6 2 5 2 4 6 2 4 1 5 4 6 1 1 4 4 6 4 5 1 4 3 5 2 1 3 3 2 4 4 4 5 2 3 3 3 1 6 1 5 2 6 2 4 6 5 2 4 1 4 4 1 3 4 4 3 4 1 5 4 5 2 5 5 5 3 6 2 2 4 6 5 1 4 2 4 4 4 3 2 2 4 1 5 1 1 1 4 2 6 6 1 5 4 4 6 2 2 5 4 1 2 4 4 6 1 4 2 5 1 6 3 2 6 3 1 4 1 2 4 4 5 3 4 1 4 5 5 3 5 6 6 3 6 3 5 6 5 3 6 5 4 3 5 4 6 3 3 4 1 5 6 2 4 3 6 3 6 3 6 3 4 4 2 2 6 1 4 2 5 4 3 3 1 5 1 5 3 5 3 4 6 2 5 5 6 6 6 1 5 1 2 3 5 6 3 4 4 1 5 3 3 3 5 5 5 4 1 3 5 4 1 4 5 3 4 6 1 1 3 3 4 6 4 2 2 1 3 1 5 4 5 2 2 1 4 3 2 4 3 1 5 4 1 3 5 3 3 3 6 6 6 1 3 2 6 4 6 1 6 2 4 1 6 2 4 1 6 3 1 6 4 3 2 6 1 3 4 5 4 2 1 3 2 3 5 3 5 5 5 2 1 6 1 1 1 6 2 3 4 5 4 1 4 5 6 3 5 3 1 3 3 5 3 4 2 3 2 2 4 2 1 4 5 4 3 1 3 2 5 5 4 2 6 3 5 6 5 3 3 6 5 6 5 6 6 5 6 4 4 2 4 1 5 1 2 3 1 3 3 5 4 1 4 2 6 1 2 1 5 2 5 6 1 3 5 1 1 6 5 4 2 5 4 5 5 3 4 6 2 1 2 2 4 6 1 6 4 3 3 6 4 4 3 6 5 6 3 1 6 6 5 6 6 1 6 6 6 1 3 5 4 2 2 2 4 6 1 1 4 2 6 3 4 3 1 3 3 1 4 5 5 5 2 2 2 1 1 3 5 2 1 4 5 3 5 1 3 2 6 3 3 6 4 2 4 2 1 1 5 3 2 6 3 2 1 6 3 2 6 1 6 2 6 4 5 1 6 5 3 3 3 4 6 4 4 3 3 6 2 5 1 1 6 5 5 3 2 1 6 1 1 5 2 5 1 2 4 3 5 6 1 1 6 5 4 4 3 2 1 2 1 4 4 6 5 5 2 1 6 2 4 1 2 3 6 3 1 6 5 3 6 5 3 6 3 6 4 6 5 4 1 6 6 3 1 3 6 5 6 2 2 5 4 3 4 4 5 2 2 2 1 5 4 1 1 2 4 2 3 3 6 1 1 6 4 3 6 5 1 2 5 2 2 4 3 3 2 3 4 3 2 4 1 6 2 1 3 3 3 2 1 1 6 4 4 6 3 5 5 2 5 3 5 2 5 5 6 1 2 1 5 3 6 4 6 4 2 5 1 5 4 4 3 4 2 6 6 4 3 1 3 1 3 1 6 2 6 3 6 1 5 1 2 3 4 4 2 3 3 2 4 3 6 1 6 1 4 1 1 6 5 5 5 2 5 2 6 5 3 3 6 1 1 2 4 1 6 3 5 1 5 1 6 2 5 4 1 5 3 3 6 6 2 5 4 1 1 3 5 1 5 6 3 4 5 5 4 3 4 5 4 3 2 1 4 3 6 2 1 4 2 6 1 2 6 1 5 2 5 3 1 6 1 4 4 6 4 3 1 4 4 2 2 1 5 4 2 3 6 4 4 1 2 4 6 6 4 4 5 2 6 2 1 1 6 3 4 2 1 6 5 4 5 4 2 2 1 4 6 6 4 3 6 2 3 3 2 5 5 4 1 3 5 6 1 3 4 1 5 5 5 4 1 3 4 1 6 2 1 4 4 6 4 5 4 3 3 5 3 5 4 1 3 2 4 3 1 6 6 2 1 3 6 3 3 5 4 2 2 1 3 5 6 6 4 3 2 6 6 4 5 1 3 3 1 6 1 3 6 1 4 3 1 4 1 3 5 1 5 5 6 5 5 1 3 4 4 6 6 1 6 3 4 6 4 5 2 6 5 3 4 4 1 3 6 6 1 6 2 4 2 1 6 4 4 6 5 4 4 5 3 6 1 2 1 4 5 2 4 5 5 6 4 3 2 4 1 1 2 4 1 5 6 1 6 1 5 3 3 5 5 5 6 1 6 6 1 4 3 6 4 1 1 2 1 6 3 4 2 1 1 4 6 2 3 3 4 1 1 3 6 2 5 1 2 2 5 5 6 6 3 5 5 5 4 3 1 2 6 2 1 3 4 3 1 3 5 2 6 5 4 5 5 2 5 1 2 3 3 6 6 5 6 3 3 2 5 1 5 2 5 3 5 3 2 1 6 4 4 2 5 3 4 1 1 6 1 6 2 4 4 5 2 1 2 2 3 4 2 4 4 3 4 3 2 4 5 1 4 6 2 3 3 4 5 4 3 3 5 3 6 4 2 4 3 3 6 2 5 6 5 4 2 3 5 3 2 3 5 6 2 6 5 1 3 5 6 2 6 4 1 1 5 5 1 6 2 4 4 2 4 6 3 5 4 5 2 3 5 5 2 5 5 6 6 6 6 4 4 2 5 6 5 1 2 2 6 4 4 3 5 3 4 1 6 3 1 4 2 4 6 6 1 4 5 1 6 5 2 5 5 6 4 6 1 2 5 1 6 3 3 6 1 3 2 5 2 6 6 5 4 1 4 2 3 6 1 4 2 2 5 1 4 3 5 5 1 4 4 2 6 4 1 1 6 2 1 6 4 3 3 2 5 1 6 5 2 1 5 4 1 5 3 4 3 4 4 2 2 6 6 2 1 1 3 2 4 1 6 4 4 2 1 1 1 3 1 6 5 1 1 5 5 5 6 5 2 1 4 6 6 5 1 2 3 5 1 2 6 6 5 4 4 3 1 6 4 1 2 6 4 6 4 6 6 2 5 4 6 2 3 4 2 5 1 6 1 5 4 5 4 4 1 1 3 4 2 6 2 2 5 5 3 2 5 1 3 6 2 4 5 5 2 1 3 2 5 2 5 1 1 4 5 3 1 3 5 2 2 6 2 5 1 3 2 4 2 1 5 2 1 1 2 5 3 3 6 1 1 6 1 5 5 5 1 1 3 3 5 6 4 6 4 5 2 6 4 4 4 6 3 4 6 2 4 5 4 5 5 5 1 5 1 5 3 4 3 3 1 5 2 4 4 3 6 5 5 2 1 4 6 4 4 1 2 3 4 3 1 3 2 5 4 2 2 2 3 6 4 5 1 2 4 6 4 3 3 3 4 4 6 3 2 2 4 2 2 4 4 4 4 2 3 1 1 1 2 5 4 3 6 4 1 5 4 4 2 3 4 1 5 1 5 5 1 6 3 2 5 5 4 6 4 2 1 1 5 3 3 5 3 2 1 6 1 2 2 3 5 6 4 2 6 1 1 1 2 1 5 1 6 2 2 3 6 2 5 5 1 4 3 1 3 2 4 3 1 5 5 4 5 4 2 1 2 4 5 3 2 3 4 6 3 1 2 4 6 6 6 5 2 5 1 4 3 6 1 3 3 6 2 2 6 2 3 4 2 6 4 5 6 1 5 2 5 6 5 2 3 4 1 2 5 3 5 3 1 1 5 5 5 6 4 4 3 3 3 1 3 1 5 5 3 2 6 2 4 3 1 5 3 5 4 1 4 1 5 2 5 5 4 5 1 2 4 5 4 6 3 2 4 2 6 2 1 5 1 2 3 2 2 1 1 2 5 3 2 4 5 2 3 1 3 1 1 5 5 1 5 6 2 5 5 3 3 3 5 1 1 4 1 2 2 4 5 4 3 4 1 3 1 4 5 2 6 5 1 2 3 1 4 2 2 6 4 2 5 6 2 2 3 4 5 5 1 6 2 6 5 5 5 4 4 5 6 1 6 1 2 5 5 2 6 1 6 4 1 2 3 2 2 6 1 1 1 3 4 5 3 3 2 1 4 3 5 3 2 3 1 5 6 5 4 3 1 5 3 2 3 3 5 4 4 4 2 1 4 1 1 5 2 2 2 4 2 4 2 2 1 1 5 5 5 5 2 1 4 1 2 3 3 3 1 5 6 2 2 5 1 3 6 1 4 6 5 5 1 1 6 4 1 3 4 2 3 6 3 5 2 3 4 4 2 5 6 5 3 6 4 3 1 1 6 3 3 3 3 3 2 6 4 6 1 2 1 4 5 4 5 5 2 2 3 3 5 3 2 6 6 1 1 3 1 5 2 4 6 4 6 3 6 4 6 4 3 5 3 3 2 5 3 3 1 6 6 1 3 5 1 6 1 1 5 2 4 2 5 1 1 4 3 5 5 2 2 1 2 4 2 5 2 6 4 2 6 5 4 2 6 3 6 4 2 5 4 6 1 6 1 2 1 1 4 2 2 2 6 6 6 5 5 1 2 1 4 2 3 1 4 1 2 2 4 2 4 3 4 5 5 1 2 5 1 1 4 2 3 4 6 6 2 6 6 1 5 1 2 3 3 6 2 1 2 5 3 5 6 3 2 6 4 3 3 2 6 3 1 2 6 2 1 6 4 5 1 2 2 6 5 4 2 1 4 6 3 1 4 2 1 6 5 4 2 1 2 2 2 2 1 2 4 2 2 3 4 4 4 4 5 2 4 2 2 6 4 4 3 6 5 6 4 2 1 3 3 3 3 6 4 5 3 5 1 3 2 1 5 2 2 2 4 2 1 3 2 3 5 4 6 6 6 5 1 3 2 2 1 2 4 3 2 2 6 4 6 6 1 6 5 6 4 5 3 1 5 4 2 1 6 1 4 3 3 3 3 2 6 6 6 2 6 4 2 1 2 6 6 3 4 4 1 3 1 3 6 4 3 1 2 1 4 5 3 2 5 1 1 6 4 1 6 3 4 3 6 2 5 2 6 2 2 1 3 3 6 5 1 2 1 1 3 1 5 3 2 1 2 2 6 1 6 5 5 1 3 1 6 3 6 6 6 2 6 6 1 1 3 5 2 6 3 1 6 3 6 5 1 5 6 5 6 2 4 2 5 4 3 2 4 5 2 2 2 4 5 4 4 3 6 4 5 5 2 1 1 5 2 1 4 2 1 5 1 6 1 4 2 5 4 3 4 6 6 6 1 6 5 3 2 1 2 5 5 1 2 2 6 1 2 6 3 5 5 3 3 3 5 5 4 3 1 1 3 6 6 6 4 6 2 3 3 3 3 6 6 3 4 4 6 5 2 3 5 4 2 2 2 6 4 5 6 1 2 1 4 6 4 3 3 3 5 6 5 6 2 5 6 2 3 1 6 3 4 2 6 1 5 3 3 1 4 6 3 5 1 4 5 6 3 1 4 2 4 6 3 6 5 6 1 1 1 3 1 1 5 5 1 1 3 3 6 2 4 5 6 6 6 5 6 3 1 2 6 3 1 1 5 5 1 6 2 2 3 1 4 5 3 1 5 2 2 6 2 2 3 3 5 2 3 2 6 6 6 2 3 1 1 3 6 5 5 5 5 2 2 3 2 3 2 5 1 6 1 3 5 2 5 4 6 4 6 2 4 6 4 3 6 6 3 3 4 5 3 2 6 4 6 2 3 3 2 5 2 6 5 3 3 4 5 1 1 5 5 5 2 5 5 5 2 4 6 4 2 1 4 1 4 6 5 5 2 4 5 6 4 6 6 2 5 2 1 3 2 1 2 4 6 5 4 5 5 4 3 5 3 2 3 5 6 1 2 5 1 6 6 6 3 5 6 5 6 3 4 2 2 4 4 4 5 5 1 6 6 3 1 4 4 3 4 4 4 5 6 4 6 3 3 6 2 3 6 1 6 6 2 6 5 3 4 4 1 5 5 6 2 6 4 5 5 4 4 6 5 2 4 1 1 4 1 1 3 3 3 2 6 6 2 6 6 4 5 4 4 5 6 2 5 2 1 4 3 4 2 5 6 2 2 4 6 3 4 2 4 4 2 4 1 6 5 3 1 2 2 6 4 6 5 2 1 2 6 6 4 4 2 6 2 1 5 3 6 1 5 4 6 3 2 1 6 5 2 5 3 6 5 5 1 6 2 1 3 1 2 5 4 5 2 2 2 3 6 4 1 1 3 1 1 3 1 2 4 5 2 3 5 3 6 2 4 4 3 1 5 6 6 1 5 5 2 1 5 6 4 5 5 6 2 6 6 6 2 5 2 4 5 2 1 1 5 4 4 6 3 2 4 2 1 3 6 3 2 1 3 5 5 4 4 6 4 1 5 3 4 1 6 4 6 1 1 4 2 2 5 4 6 5 5 2 5 4 3 3 6 6 5 3 2 5 1 5 1 1 3 3 3 6 5 2 6 3 6 1 4 2 6 6 2 5 4 2 6 4 5 3 6 3 6 6 1 1 3 6 4 6 2 1 2 3 1 5 5 6 1 5 5 1 1 3 3 3 5 3 5 4 5 4 2 2 2 1 2 2 5 5 2 1 4 3 5 5 2 4 6 1 6 2 1 5 6 4 2 3 5 2 3 5 5 4 3 3 6 3 2 5 5 4 2 6 2 1 1 6 5 5 6 4 6 2 3 1 6 2 1 3 1 3 1 2 3 4 3 5 1 1 3 6 1 3 3 2 6 6 2 1 2 1 1 4 4 5 2 2 6 3 3 1 6 2 4 3 6 5 4 3 1 3 3 2 4 4 5 4 6 4 3 2 3 3 1 4 6 6 4 4 5 6 4 4 6 3 5 1 2 5 4 1 4 3 2 5 3 5 1 4 1 2 3 5 6 2 2 5 5 3 1 1 5 2 5 5 1 6 1 6 1 6 1 5 3 6 2 4 2 4 5 1 2 5 1 1 5 1 4 3 3 5 5 3 6 3 1 6 2 2 1 6 6 5 4 4 3 3 5 4 6 6 1 3 5 3 1 2 3 3 3 3 4 3 3 2 2 3 3 3 6 6 3 5 4 5 6 4 4 2 3 4 6 4 3 4 3 1 6 6 5 1 2 2 5 3 3 4 5 2 2 1 2 5 6 1 4 2 5 4 6 1 2 1 5 3 4 2 3 4 2 4 5 6 1 1 1 3 1 3 5 6 4 3 6 3 3 4 3 6 5 4 1 2 6 2 1 3 2 1 1 3 5 3 5 3 6 1 6 6 4 3 1 4 3 2 2 5 4 3 6 2 1 5 2 6 3 1 4 6 3 2 5 5 6 1 6 3 3 4 6 6 5 2 3 1 1 6 5 5 4 1 4 2 6 2 6 2 2 4 6 6 1 6 1 2 4 1 2 4 1 4 1 2 6 6 2 6 4 6 1 1 3 2 1 3 3 1 6 3 5 4 4 4 2 1 5 6 3 3 5 2 5 6 2 1 1 4 4 5 2 3 3 3 6 6 6 5 6 2 3 3 3 3 3 3 5 1 5 2 2 1 1 6 5 5 1 6 1 2 1 2 2 4 2 3 2 2 2 3 5 1 6 1 3 3 4 3 1 1 4 5 1 4 3 2 3 6 2 3 5 1 6 3 2 2 3 2 2 4 5 5 4 6 5 4 4 5 3 4 2 3 2 3 3 3 6 2 5 1 2 5 5 6 5 3 6 5 2 3 3 5 1 4 1 5 1 5 4 3 3 1 6 4 6 6 1 3 3 2 5 3 5 6 4 3 4 5 5 3 6 6 3 3 1 2 3 3 3 5 3 1 6 3 1 5 5 4 5 2 1 1 6 2 5 5 2 2 1 4 6 2 4 4 4 6 2 6 4 1 4 1 5 3 2 2 6 2 6 5 3 4 6 4 4 2 2 2 6 6 5 2 1 4 5 4 3 1 3 6 3 5 2 2 6 3 2 5 2 1 2 5 6 4 4 2 6 1 2 2 5 5 3 2 1 4 1 2 4 3 5 3 4 3 5 4 2 1 6 1 1 4 3 4 4 5 5 6 2 1 4 2 3 2 5 4 3 5 4 3 5 1 2 3 5 4 2 4 3 3 3 6 3 3 2 4 4 2 4 3 5 3 3 4 6 2 4 4 6 3 4 5 6 5 3 6 2 1 1 5 5 5 2 6 6 4 5 3 3 6 1 6 2 3 4 2 3 3 2 6 2 4 3 1 2 4 1 1 6 1 1 5 4 2 3 4 6 3 4 1 4 5 3 1 2 5 5 3 3 5 1 6 1 3 5 4 1 4 1 4 1 1 6 1 5 6 1 1 3 4 3 6 3 2 6 4 5 4 5 3 4 2 4 6 6 6 3 6 3 1 1 5 5 2 6 5 4 3 4 2 4 3 3 4 3 4 6 4 1 5 6 3 3 3 2 3 5 6 3 2 6 5 6 2 3 1 2 4 5 2 5 2 3 3 3 3 4 6 5 2 6 5 2 3 2 4 4 4 3 3 4 6 5 3 2 4 4 5 1 4 4 5 4 1 3 6 5 1 4 3 3 6 4 3 5 3 3 4 6 4 1 1 2 6 5 1 6 1 2 4 1 5 6 1 6 2 2 5 4 3 6 5 3 2 6 1 1 6 1 1 6 1 4 4 4 4 5 4 4 1 1 5 6 1 6 6 2 1 2 1 1 5 6 2 2 2 6 4 1 3 3 6 6 5 4 4 4 1 3 6 6 3 1 3 1 3 4 3 6 3 3 2 2 6 1 4 3 6 6 2 3 6 6 5 5 3 2 3 1 5 2 1 2 4 3 3 5 6 1 1 5 5 4 6 2 1 3 4 6 4 6 6 6 2 4 4 1 6 2 5 5 3 5 2 2 4 2 3 3 3 1 2 4 1 5 1 4 5 2 4 1 2 4 2 2 3 6 4 5 4 2 4 5 5 3 6 6 1 1 1 4 6 6 5 6 3 6 3 4 2 3 1 2 1 4 1 5 2 4 2 6 4 2 6 5 1 3 2 4 6 3 1 4 5 5 6 4 6 5 3 2 2 1 2 4 6 5 2 3 2 2 2 2 5 1 5 4 1 3 3 5 6 2 3 1 2 6 1 1 2 4 5 2 4 6 1 6 6 2 2 6 2 4 5 1 1 4 4 5 2 1 3 1 5 1 3 2 4 4 4 1 4 2 6 6 1 2 6 3 3 1 6 2 2 6 6 1 1 5 5 6 6 1 5 6 6 4 1 2 3 3 3 1 4 5 5 4 2 4 4 1 5 4 5 4 4 2 2 1 5 4 5 4 2 5 6 2 4 3 6 2 1 2 4 6 1 1 1 4 3 2 5 2 6 4 1 6 6 1 4 3 6 2 2 4 4 1 3 1 3 5 3 6 1 1 4 6 4"
                    .Split(' ');
            intArray = new List<int>();
            Array.ForEach(array, s => intArray.Add(int.Parse(s)));
            steps = VovaLogic.Solve(intArray.Count, intArray.ToArray(), 6);
            Assert.AreEqual(5112, steps);
            array = "4 3 5".Split(' ');
            intArray = new List<int>();
            Array.ForEach(array, s => intArray.Add(int.Parse(s)));
            steps = VovaLogic.Solve(3, intArray.ToArray(), 6);
            Assert.AreEqual(5, steps);
        }
    }
}