using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7_task;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNextSet()
        {
            int[] a = new int[4] { 1, 1, 1, 1 };
            Assert.IsTrue(Program.NextSet(ref a, 4, 4));
            int h = 0;
            int k = 3;
            for (int i = 0; i < a.Length; i++,k--)
            {
                
                h += ((int)Math.Pow(10, k)) * a[i];
                
            }
            Assert.AreEqual(h, 1112);
            a = new int[4] { 1, 1, 1, 4 };
            Assert.IsTrue(Program.NextSet(ref a, 4, 4));
            h = 0;
            k = 3;
            for (int i = 0; i < a.Length; i++, k--)
            {

                h += ((int)Math.Pow(10, k)) * a[i];

            }
            Assert.AreEqual(h, 1121);
            a = new int[4] { 4, 4, 4, 4 };
            Assert.IsTrue(!Program.NextSet(ref a, 4, 4));
            h = 0;
            k = 3;
            for (int i = 0; i < a.Length; i++, k--)
            {

                h += ((int)Math.Pow(10, k)) * a[i];

            }
            Assert.AreEqual(h, 4444);
            a = new int[4] { 4, 3, 4, 4 };
            Assert.IsTrue(Program.NextSet(ref a, 4, 4));
            h = 0;
            k = 3;
            for (int i = 0; i < a.Length; i++, k--)
            {

                h += ((int)Math.Pow(10, k)) * a[i];

            }
            Assert.AreEqual(h, 4411);
            a = new int[4] { 3, 4, 4, 4 };
            Assert.IsTrue(Program.NextSet(ref a, 4, 4));
            h = 0;
            k = 3;
            for (int i = 0; i < a.Length; i++, k--)
            {

                h += ((int)Math.Pow(10, k)) * a[i];

            }
            Assert.AreEqual(h, 4111);

        }
        [TestMethod]
        public void TestGenerate()
        {
            List<string> mass = new List<string> { "s", "ss"};
            Program.Generate(0,mass);
            mass = new List<string> { };
            Program.Generate(1, mass);
            mass = new List<string> { "s" };
            Program.Generate(3, mass);
            mass = new List<string> { "ns", "f", "w" };
            Program.Generate(3, mass);
        }
    }
}
