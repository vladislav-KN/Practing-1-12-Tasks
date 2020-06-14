using Microsoft.VisualStudio.TestTools.UnitTesting;
using _11_task;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.deshifr(0, Program.shifr(0, "dasjfalkshfwuehrwiueh wofh�����������������")), "dasjfalkshfwuehrwiueh wofh�����������������");
            Assert.AreEqual(Program.deshifr(1, Program.shifr(1, "�p��ETZz��")), "�p��ETZz��");
            Assert.AreEqual(Program.deshifr(213, Program.shifr(213, "�p��ETZz��")), "�p��ETZz��");
            Assert.AreEqual(Program.shifr(0, Program.deshifr(0, "dasjfalkshfwuehrwiueh wofh�����������������")), "dasjfalkshfwuehrwiueh wofh�����������������");
            Assert.AreEqual(Program.shifr(1, Program.deshifr(1, "��Aa�p��ETZz��")), "��Aa�p��ETZz��");
            Assert.AreEqual(Program.shifr(213, Program.deshifr(213, "��Aa�p��ETZz��")), "��Aa�p��ETZz��");
        }
    }
}
