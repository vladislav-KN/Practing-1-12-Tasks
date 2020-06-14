using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8_task;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.Run(2);
            Program.Run(3);
            Program.Run(18);
            Program.Run(50);
        }
    }
}
