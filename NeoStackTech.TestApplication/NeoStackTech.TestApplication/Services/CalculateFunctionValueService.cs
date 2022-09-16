using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTech.TestApplication.Services
{
    /// <summary>
    /// Предоставляет функционал расчёта значений функции.
    /// </summary>
    public static class CalculateFunctionValueService
    {
        /// <summary>
        /// Возвращает значение требуемой функции.
        /// </summary>
        /// <param name="a">Коэффициент при x.</param>
        /// <param name="b">Коэффициент при y. </param>
        /// <param name="c">Свободный коэффициент.</param>
        /// <param name="x">Аргумент x.</param>
        /// <param name="y">Аргумент y.</param>
        /// <param name="power">Максимальная степень полинома.</param>
        /// <returns>Значение функции.</returns>
        public static double GetFunctionValue(double a, double b, double c, double x, double y, int power)
        {
            double xPart = a * Math.Pow(x, power);
            double yPart = b * Math.Pow(y, power - 1);

            return xPart+yPart+c;
        }
    }
}
