using Microsoft.VisualStudio.TestTools.UnitTesting;
using _10_task;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] items = new int[0];
            Tree test = new Tree(items);
            items = new int[1] { 3 };
            test = new Tree(items);
            items = new int[10] { 3, 5, 6, 23, -3, 52, 23, 523, 34,-12};
            test = new Tree(items);
            test.Run();
            Point s = new Point();
            s = new Point(1);
            Assert.AreEqual(s.ToString(),"1 ") ;
        }
    }
}
