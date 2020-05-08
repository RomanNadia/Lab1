using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            double leght = Program.Line(0, 0, 3, 4);
            Assert.AreEqual(leght, 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double P = Program.Example1(1, 1, 2);
            Assert.AreEqual(P, 4);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double S = Program.Example2(12, 3, 5, 4);
            Assert.AreEqual(S, 6);
        }

   
        
    }
}
