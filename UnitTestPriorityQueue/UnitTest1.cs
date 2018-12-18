using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibPriorityQueue;

namespace UnitTestPriorityQueue
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_PriorityQueueCount()
        {
            MockObject m1 = new MockObject("a", 20);
            MockObject m2 = new MockObject("b", 220);
            MockObject m3 = new MockObject("c", 203);
            MockObject m4 = new MockObject("d", 240);
            MockObject m5 = new MockObject("e", 2);

            PriorityQueue<MockObject> pQueue = new PriorityQueue<MockObject>();
            pQueue.Enqueue(m1);
            pQueue.Enqueue(m2);
            pQueue.Enqueue(m3);
            pQueue.Enqueue(m4);
            pQueue.Enqueue(m5);

            Assert.AreEqual(5, pQueue.Count(), "Error");

        }

        [TestMethod]
        public void Test_Dequeue()
        {
            MockObject m1 = new MockObject("a", 20);
            MockObject m2 = new MockObject("b", 220);
            MockObject m3 = new MockObject("c", 203);
            MockObject m4 = new MockObject("d", 240);
            MockObject m5 = new MockObject("e", 2);

            PriorityQueue<MockObject> pQueue = new PriorityQueue<MockObject>();
            pQueue.Enqueue(m1);
            pQueue.Enqueue(m2);
            pQueue.Enqueue(m3);
            pQueue.Enqueue(m4);
            pQueue.Enqueue(m5);

            Assert.AreEqual(m4, pQueue.Dequeue(), "Most Priority Object not equal");
            Assert.AreEqual(m3, pQueue.Dequeue(), "Most Priority Object not equal");
        }

    }
}
