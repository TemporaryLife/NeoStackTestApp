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
            var x = 1;
            var y = 1;
            var a = 1;
            var b = 1;
            var c = 1;
            var power = 1;
            var expected = 3;

            var actual = GetFunctionValue(a, b, c, x, y, power);

            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void TestCalculatingX2_Y4_A4_B2_C3_Power3()
        {
            var x = 2;
            var y = 4;
            var a = 4;
            var b = 2;
            var c = 3;
            var power = 3;
            var expected = 67;

            var actual = GetFunctionValue(a, b, c, x, y, power);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestCalculatingX2P5_Y4P5_A4_B2_C3_Power3()
        {
            var x = 2.5;
            var y = 4.5;
            var a = 4;
            var b = 2;
            var c = 3;
            var power = 3;
            var expected = 106;

            var actual = GetFunctionValue(a, b, c, x, y, power);

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
