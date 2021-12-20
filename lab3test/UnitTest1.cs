using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab3stp;

namespace lab3test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Program.MaxOfThree(1, 2, 3));
            Assert.AreEqual(4, Program.MaxOfThree(4, 2, 1));
            Assert.AreEqual(6, Program.MaxOfThree(4, 6, 1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 172349;
            Assert.AreEqual(19, Program.SummEvenDigit(a));
            int b = 1;
            Assert.AreEqual(-1, Program.SummEvenDigit(b));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4, Program.SearchMinDigit(46598));
            Assert.AreEqual(2, Program.SearchMinDigit(2));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var a = new int[] { 3, 1, 5 };
            var b = new int[] { 3, 1, 1 };
            var c = new int[] { 3, 3, 7 };
            var mas = new int[][] { a, b, c };
            Assert.AreEqual(18, Program.GetSumOddElements(mas));
            var a1 = new int[] { 4, 0, 2 };
            var b1 = new int[] { 3, 6, 8 };
            var c1 = new int[] { 5, 3, 2 };
            var mas1 = new int[][] { a1, b1, c1 };
            Assert.AreEqual(0, Program.GetSumOddElements(mas1));
        }
    }
}
