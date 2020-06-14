using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4_task;

namespace Tests_4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double resCheck = Program.result(1);
            Assert.AreEqual(0, resCheck);
            resCheck = Program.result(0.00000001);
            Assert.AreEqual(0.8667603954672813, resCheck);
            resCheck = Program.result(0.000000000000001);
            Assert.AreEqual(0.8667603991738613, resCheck);
        }
    }
}
