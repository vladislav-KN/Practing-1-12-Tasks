using Microsoft.VisualStudio.TestTools.UnitTesting;
using _12_task;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            Program.compleat(1);
            Program.compleat(2);
            Program.compleat(1000);
            Tree j = new Tree();
            j = new Tree(3);
            ulong s = 0;
            Assert.AreEqual(j.ToString(), "3 ");
            j.insert(new Tree(2),ref s);
            j.insert(new Tree(1), ref s);
            j.insert(new Tree(5), ref s); 
            j.insert(new Tree(7), ref s);
            j.insert(new Tree(-7), ref s);
            j.Run(j);
        }
    }
}
