using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatingTests
{
    /// <summary>
    /// Предоставляет функционал для тестирования метода расчета значения функции.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculatingX1_Y1_A1_B1_C1_Power1()
        {
            double x = 1, y = 1, a = 1, b = 1, c = 1;
            int power = 1;
            double expected = 3;

            double actual = GetFunctionValue(a, b, c, x, y, power);

            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void TestCalculatingX2_Y4_A4_B2_C3_Power3()
        {
            double x = 2, y = 4, a = 4, b = 2, c = 3;
            int power = 3;
            double expected = 67;

            double actual = GetFunctionValue(a, b, c, x, y, power);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestCalculatingX2P5_Y4P5_A4_B2_C3_Power3()
        {
            double x = 2.5, y = 4.5, a = 4, b = 2, c = 3;
            int power = 3;
            double expected = 106;

            double actual = GetFunctionValue(a, b, c, x, y, power);

            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Тестируемый метод.
        /// </summary>
        private static double GetFunctionValue(double a, double b, double c, double x, double y, int power)
        {
            double xPart = a * Math.Pow(x, power);
            double yPart = b * Math.Pow(y, power - 1);

            return xPart + yPart + c;
        }
    }
}
