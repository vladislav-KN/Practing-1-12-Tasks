using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_task;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool ok = Program.Compleat(0,0);
            Assert.IsTrue(ok);
            ok = Program.Compleat(1, 2);
            Assert.IsTrue(!ok);
            ok = Program.Compleat(-0.786, 0.382);
            Assert.IsTrue(ok);
        }
    }
}
