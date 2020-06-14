using Microsoft.VisualStudio.TestTools.UnitTesting;
using _9_task;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CircularLinkedList<int> list = new CircularLinkedList<int>();
            Program.FillUp(1,out list);
            Assert.IsTrue(list.Remove(1));
            list = new CircularLinkedList<int>();
            Program.FillUp(0, out list);
            Assert.IsFalse(list.Remove(1));
            list = new CircularLinkedList<int>();
            Program.FillUp(12, out list);
            Assert.AreEqual(list.Count,12);
            Assert.IsTrue(list.Remove(2));
            Assert.IsFalse(list.Remove(2));
            Assert.IsTrue(list.Remove(1));
            Assert.IsTrue(list.Remove(12));
            Assert.IsTrue(list.Contains(3));
            Assert.IsFalse(list.Contains(2));
            Assert.IsTrue(list.Contains(11));
            Assert.IsTrue(list.Contains(6));
            int k = 0;
            foreach(int i in list)
            {
                Assert.AreEqual(list.GetId(i), k);
                k++;
            }
            Assert.AreEqual(list.GetId(31), -1);
            NextList<int> nextList = new NextList<int>();
            list.Clear();
        }
    }
}
