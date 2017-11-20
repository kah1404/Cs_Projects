using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestGenerics
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStack()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Push(4);

            var asArray = stack.ToArray();
            Assert.AreEqual(4, asArray[0]);
            Assert.AreEqual(4, stack.Peek());
        }

        [TestMethod]
        public void TestQueue()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Clear();
            queue.Enqueue(4);

            var asArray = queue.ToArray();

            Assert.AreEqual(4, asArray[0]);
            Assert.AreEqual(4, queue.Peek());

            //Trace.WriteLine(asArray);
        }

        [TestMethod]
        public void TestList()
        {
            var list = new List<int> {1, 2, 3};

            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void HashSetIntersectWith()
        {
            var set1 = new HashSet<int> {1, 2, 3};
            var set2 = new HashSet<int> {2, 3, 4};

            set1.IntersectWith(set2);

            //Du får tilbake fellesnevnerene
            Assert.IsTrue(set1.SetEquals(new []{2,3}));
        }

        [TestMethod]
        public void HashSetUnionWith()
        {
            var set1 = new HashSet<int> {1, 2, 3};
            var set2 = new HashSet<int> {2, 3, 4};

            set1.UnionWith(set2);

            //Du setter sammen begge
            Assert.IsTrue(set1.SetEquals(new []{1,2,3,4}));
        }

        [TestMethod]
        public void HashSetSymmericExceptWith()
        {
            var set1 = new HashSet<int> {1, 2, 3};
            var set2 = new HashSet<int> {2, 3, 4};

            set1.SymmetricExceptWith(set2);

            //Du får tilbake det som er enkelt nevner for begge.
            Assert.IsTrue(set1.SetEquals(new []{1,4}));
        }

        [TestMethod]
        public void LinkedListAddAfter()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("world");
            list.AddAfter(list.First, "there");


            Assert.AreEqual("there", list.First.Next.Value);
        }
        [TestMethod]
        public void LinkedListRemoveLast()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("world");
            list.RemoveLast();


            Assert.AreEqual(list.First, list.Last);
        }
        [TestMethod]
        public void LinkedListRemoveFirst()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("world");
            list.RemoveFirst();

            Assert.AreEqual(list.First, list.Last);
        }
        [TestMethod]
        public void LinkedListFindItem()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("world");

            Assert.IsTrue(list.Contains("Hello"));
        }
        [TestMethod]
        public void DictionaryTest()
        {
            var map = new Dictionary<int, string>
            {
                {1, "One"} ,
                {2, "Two"}
            };

            Assert.AreEqual("One", map[1]);
            Assert.IsTrue(map.ContainsKey(1));
        }
    }
}
