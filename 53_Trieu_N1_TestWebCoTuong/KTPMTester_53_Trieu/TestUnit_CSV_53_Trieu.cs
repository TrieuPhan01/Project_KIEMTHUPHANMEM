using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTPM_53_Trieu;

namespace KTPMTester_53_Trieu
{
    [TestClass]
    public class TestUnit_CSV_53_Trieu

    {
        public TestContext TestContext { get; set; }
        private prefix_53_Trieu testPrefix_53_Trieu;


        [TestMethod]
        public void MotChuoiNullHoacRong_53_Trieu()//TC1: 1 Chuoi rong hoac null
        {
            //TC: 1 Chuoi rong
            testPrefix_53_Trieu = new prefix_53_Trieu("", "antidote", "antibiotic", "antiseptic");
            string expected_53_Trieu = "Error";
            string actual_53_Trieu = testPrefix_53_Trieu.LongestCommonPrefix_53_Trieu();
            Assert.AreEqual(expected_53_Trieu, actual_53_Trieu, "1 Chuỗi rỗng - Kết quả mong muốn và thực tế không giống nhau! ");

            //TC: 1 Chuoi Null
            prefix_53_Trieu testPrefix2_53_Trieu = new prefix_53_Trieu(null, "misunderstand", "miscalculate", "misplace");
            string expected2_53_Trieu = "Error";
            string actual2_53_Trieu = testPrefix2_53_Trieu.LongestCommonPrefix_53_Trieu();
            Assert.AreEqual(expected2_53_Trieu, actual2_53_Trieu, "1 Chuỗi null - Kết quả mong muốn và thực tế không giống nhau! ");
        }

        [TestMethod]
        public void MotChuoiLaTienToChung_53_Trieu()//TC2: Co 1 chuoi la tien to chung cua cac chuoi khac
        {
            testPrefix_53_Trieu = new prefix_53_Trieu("multimedia", "multi", "multinational", "multipurpose");
            string expected_53_Trieu = "multi";
            string actual_53_Trieu = testPrefix_53_Trieu.LongestCommonPrefix_53_Trieu();
            Assert.AreEqual(expected_53_Trieu, actual_53_Trieu);

        }

        [TestMethod]
        public void CoTienToChung_53_Trieu()//TC4: Co tien to chung
        {
            testPrefix_53_Trieu = new prefix_53_Trieu("unrest", "undoing", "unseen", "unheard");
            string expected_53_Trieu = "un";
            string actual_53_Trieu = testPrefix_53_Trieu.LongestCommonPrefix_53_Trieu();
            Assert.AreEqual(expected_53_Trieu, actual_53_Trieu);

        }


        [TestMethod]
        public void KhongCoTienToChung_53_Trieu()//TC4: Khong co tien to chung
        {
            testPrefix_53_Trieu = new prefix_53_Trieu("antibiotic", "coexist", "pretest", "rebuild");
            string expected_53_Trieu = "No result";
            string actual_53_Trieu = testPrefix_53_Trieu.LongestCommonPrefix_53_Trieu();
            Assert.AreEqual(expected_53_Trieu, actual_53_Trieu);
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data_53_Trieu\DaTaUnitTest_53_Trieu.csv", "DaTaUnitTest_53_Trieu#csv", DataAccessMethod.Sequential)]


        [TestMethod]
        public void TestWithDataSource_53_Trieu()// Test bang file CSV
        {
            string a_53_Trieu = string.Format(TestContext.DataRow[0].ToString());
            string b_53_Trieu = string.Format(TestContext.DataRow[1].ToString());
            string c_53_Trieu = string.Format(TestContext.DataRow[2].ToString());
            string d_53_Trieu = string.Format(TestContext.DataRow[3].ToString());
            string expected_53_Trieu = string.Format(TestContext.DataRow[4].ToString());

            testPrefix_53_Trieu = new prefix_53_Trieu(a_53_Trieu, b_53_Trieu, c_53_Trieu, d_53_Trieu);
            string actual_53_Trieu = testPrefix_53_Trieu.LongestCommonPrefix_53_Trieu();
            Assert.AreEqual(expected_53_Trieu, actual_53_Trieu);
        }
    }
}
