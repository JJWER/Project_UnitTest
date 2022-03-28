using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;

namespace Unit_Test_Project_Lab
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_Assignment_1()
        {
            //ข้อ 1
            AssignmentClass ac = new AssignmentClass();
            int input = 1020;
            string result = ac.greadCalculate(input);
            Assert.AreEqual("A", result);

            result = ac.greadCalculate(80);
            Assert.AreEqual("A", result);

            result = ac.greadCalculate(-1);
            Assert.AreEqual("F", result);

            result = ac.greadCalculate(79);
            Assert.AreEqual("B+", result);

            result = ac.greadCalculate(49);
            Assert.AreEqual("F", result);
        }
        [TestMethod]
        public void Test_Assignment_2()
        {
            //ข้อ 2 
            AssignmentClass ac = new AssignmentClass();
            double result = ac.getDistance(3, 2, 7, 8);
            Assert.AreEqual(7.21, result);

            result = ac.getDistance(-3, 2, 7, -8);
            Assert.AreEqual(14.14, result);

            result = ac.getDistance(-3, -2, -7, -8);
            Assert.AreEqual(7.21, result);

            result = ac.getDistance(3, -2, -7, 8);
            Assert.AreEqual(14.14, result);
        }
        [TestMethod]
        public void Test_Assignment_3()
        {
            /// ข้อ 3 
            AssignmentClass ac = new AssignmentClass();
            int n = ac.GetFactorial(5);
            Assert.AreEqual(120, n);

            n = ac.GetFactorial(1);
            Assert.AreEqual(1, n);

            n = ac.GetFactorial(0);
            Assert.AreEqual(1, n);

            n = ac.GetFactorial(-1);
            Assert.AreEqual(1, n);
        }
        [TestMethod]
        public void Test_Assignment_4()
        {
            // ข้อ 4
            AssignmentClass ac = new AssignmentClass();
            string password = ac.CheckPassword("abc123");
            Assert.AreEqual("false", password);

            password = ac.CheckPassword("abc12345");
            Assert.AreEqual("true", password);

            password = ac.CheckPassword("abcdefgh");
            Assert.AreEqual("false", password);

            password = ac.CheckPassword("12345678");
            Assert.AreEqual("false", password);
        }
    }
}
