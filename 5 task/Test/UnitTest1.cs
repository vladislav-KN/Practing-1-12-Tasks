using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5_task;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.result(0);
            Program.result(1);
            Program.result(10);
        }
    }
}
