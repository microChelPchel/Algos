using AlgosCore.StructData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgosCore.Test
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void CreateQueueTest()
        {
            Queue<int> queue = new Queue<int>();
            Assert.IsNotNull(queue);
            Assert.IsFalse(queue.IsEmpty());
            Assert.AreEqual(queue.GetCount(), 1);

            int count = 3;
            queue = new Queue<int>(count);
            Assert.IsNotNull(queue);
            Assert.IsFalse(queue.IsEmpty());
            Assert.AreEqual(queue.GetCount(), count);
        }


        [TestMethod]
        public void EnqueueTest()
        {
            Queue<int> queue = new Queue<int>(2);
            queue.Enqueue(1);
            queue.Enqueue(2);
            //stack overflow
            queue.Enqueue(3);
            Assert.IsNotNull(queue);
            Assert.IsFalse(queue.IsEmpty());
            Assert.AreEqual(queue.GetCount(), 3);
        }



    }
}
