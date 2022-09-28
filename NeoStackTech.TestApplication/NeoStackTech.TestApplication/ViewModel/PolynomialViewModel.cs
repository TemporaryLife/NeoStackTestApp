using Microsoft.VisualStudio.PlatformUI;
using System.Collections.Generic;

namespace NeoStackTech.TestApplication.ViewModel
{
    /// <summary>
    /// Предоставляет модель полинома.
    /// </summary>
    public class PolynomialViewModel : ObservableObject
    {
        /// <summary>
        /// Коэффициент А.
        /// </summary>
        private string _coefficientA;

        /// <summary>
        /// Коэффициент B.
        /// </summary>
        private string _coefficientB;

        /// <summary>
        /// Коэффициент C.
        /// </summary>
        private double _coefficientC;

        /// <summary>
        /// Инициализирует объект класса <see cref="PolynomialViewModel"/>.
        /// </summary>
        /// <param name="coefficientsList">Cписок коэффициентов С.</param>
        public PolynomialViewModel(string name, int power, List<double> coefficientsList)
        {
            CoefficientA = "0";
            CoefficientB = "0";

            Name = name;
            Power = power;
            CoefficientsList = coefficientsList;
        }

        /// <summary>
        /// Коэффициент А.
        /// </summary>
        public string CoefficientA
        {
            get => _coefficientA;
            set
            {
                if (value.Length > 0)
                {
                    if (double.TryParse(value, out double res))
                    {
                        SetProperty(ref _coefficientA, value);
                    }
                }
                else
                {
                    SetProperty(ref _coefficientA, "0");
                }               
            }
        }

        /// <summary>
        /// Коэффициент B.
        /// </summary>
        public string CoefficientB
        {
            get => _coefficientB;
            set
            {
                if (value.Length > 0)
                {
                    if (double.TryParse(value, out double res))
                    {
                        SetProperty(ref _coefficientB, value);
                    }
                }
                else
                {
                    SetProperty(ref _coefficientB, "0");
                }
            }
        }

        /// <summary>
        /// Коэффициент C.
        /// </summary>
        public double CoefficientC
        {
            get => _coefficientC;
            set => SetProperty(ref _coefficientC, value);
        }

        /// <summary>
        /// Список коэффициентов C.
        /// </summary>
        public List<double> CoefficientsList { get; set; }

        /// <summary>
        /// Имя полинома.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Максимальная степень полинома.
        /// </summary>
        public int Power { get; set; }
    }
}