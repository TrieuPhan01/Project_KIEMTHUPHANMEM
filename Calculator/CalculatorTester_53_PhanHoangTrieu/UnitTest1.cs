using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;

namespace CalculatorTester_53_PhanHoangTrieu
{
    [TestClass]
    public class UnitTest1
    {
        private Caculaton c;
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
            c = new Caculaton(10, 5);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= 15
        public void Test_Cong_53_PhanHoangTrieu()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        // sv thực hiện tiếp cho các TC tiếp theo……
        [TestMethod]
        public void Test_Tru_53_PhanHoangTrieu()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Nhan_53_PhanHoangTrieu()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Chia_53_PhanHoangTrieu()
        {
            int expected, actual;
            c = new Caculaton(10, 5);
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero_53_PhanHoangTrieu()
        {       
            c = new Caculaton(10,0);
            c.Execute("/");
        }
    }
}
