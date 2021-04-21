using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExternalClientLib;


namespace SobTaskUTest
{
    [TestClass]
    public class SobTest1     //Каждый из дальнейших тестов преставляет собой проверку типа "ожидание/реальность". Подаем значения и сверяем полученный в ходе отработки результата с ожидаемым результатом.
    {                         //Половина тестов отрабатывают успешно, а половина нет, потому что я так же провожу проверку на исключения.
        [TestMethod]
        public void TestMethod1_True_Triang()
        {
            double Test_A = 10;
            double Test_B = 13;
            double Test_C = 19;

            double expected_S = 60.794736614282655;
            Triangle three = new Triangle(Test_A, Test_B, Test_C);
            double actual_S = three.Area();
            Assert.AreEqual(expected_S, actual_S, 0.001, "Area not calculated successfully!");
        }

        [TestMethod]
        public void TestMethod2_True_Triang()
        {
            double Test_A = 15;
            double Test_B = 12;
            double Test_C = 25;

            double expected_S = 63.2771680782255;
            Triangle three = new Triangle(Test_A, Test_B, Test_C);
            double actual_S = three.Area();
            Assert.AreEqual(expected_S, actual_S, 0.001, "Area not calculated successfully!");
        }

        [TestMethod]
        public void TestMethod_Triang_Not_Equal_Exeption()
        {
            double Test_A = 15;
            double Test_B = 12;
            double Test_C = 25;

            double expected_S = 64.2771680782255;
            Triangle three = new Triangle(Test_A, Test_B, Test_C);
            double actual_S = three.Area();
            Assert.AreEqual(expected_S, actual_S, 0.001, "Area not calculated successfully!");
        }

        [TestMethod]
        public void TestMethod_Triang_Zero_Exeption()
        {
            double Test_A = 15;
            double Test_B = 12;
            double Test_C = 0;

            double expected_S = 63.2771680782255;
            Triangle three = new Triangle(Test_A, Test_B, Test_C);
            double actual_S = three.Area();
            Assert.AreEqual(expected_S, actual_S, 0.001, "Area not calculated successfully!");
        }

        [TestMethod]
        public void TestMethod1_True_Circ()
        {
            double Test_R = 5;
            double expected_S = 78.5398163375;
            Circle circ = new Circle(Test_R);
            double actual_S = circ.Area();
            Assert.AreEqual(expected_S, actual_S, 0.001, "Area not calculated successfully!");
        }

        [TestMethod]
        public void TestMethod2_True_Circ()
        {
            double Test_R = 23;
            double expected_S = 1661.9025137015;
            Circle circ = new Circle(Test_R);
            double actual_S = circ.Area();
            Assert.AreEqual(expected_S, actual_S, 0.001, "Area not calculated successfully!");
        }

        [TestMethod]
        public void TestMethod_Circ_Zero_Exeption()
        {
            double Test_R = 0;
            double expected_S = 1661.9025137015;
            Circle circ = new Circle(Test_R);
            double actual_S = circ.Area();
            Assert.AreEqual(expected_S, actual_S, 0.001, "Area not calculated successfully!");
        }

        [TestMethod]
        public void TestMethod_Circ_Not_Equal_Exeption()
        {
            double Test_R = 23;
            double expected_S = 1650.9025137015;
            Circle circ = new Circle(Test_R);
            double actual_S = circ.Area();
            Assert.AreEqual(expected_S, actual_S, 0.001, "Area not calculated successfully!");
        }
    }
}
