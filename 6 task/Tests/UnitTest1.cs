using Microsoft.VisualStudio.TestTools.UnitTesting;
using _6_task;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.Numbers(0, 0, 0, 0, 0, 0, 0, 0);
            Program.Numbers(1, 2, 3, 2, 3, 1, 2, 3);
            Program.Numbers(4, 5, -1,32, 32, 3, 32, 32);
            Program.Numbers(-7, -3, -1, 32, 32, 3, 32, 32);
            Program.Numbers(1, 1, 1, 32, 32, 3, 32, 32);
            Program.Numbers(0, 0, 0, 3, 4, 2, 3, 4);
            Program.Numbers(-7, -3, -1, -1, -4, -4, -1, -4);
            
        }
    }
}
