using Microsoft.VisualStudio.PlatformUI;
using System.Collections.Generic;

namespace NeoStackTech.TestApplication.Model
{
    /// <summary>
    /// Предоставляет модель полинома.
    /// </summary>
    public class Polynomial : ObservableObject
    {
        /// <summary>
        /// Коэффициент А.
        /// </summary>
        private int _coefficientA;

        /// <summary>
        /// Коэффициент B.
        /// </summary>
        private int _coefficientB;

        /// <summary>
        /// Коэффициент C.
        /// </summary>
        private int _coefficientC;

        /// <summary>
        /// Инициализирует объект класса <see cref="Polynomial"/>.
        /// </summary>
        /// <param name="coefficientsList">Cписок коэффициентов С.</param>
        public Polynomial(List<int> coefficientsList)
        {
            CoefficientsList = coefficientsList;
        }

        /// <summary>
        /// Коэффициент А.
        /// </summary>
        public int CoefficientA
        {
            get => _coefficientA;
            set => SetProperty(ref _coefficientA, value);
        }

        /// <summary>
        /// Коэффициент B.
        /// </summary>
        public int CoefficientB
        {
            get => _coefficientB;
            set => SetProperty(ref _coefficientB, value);
        }

        /// <summary>
        /// Коэффициент C.
        /// </summary>
        public int CoefficientC
        {
            get => _coefficientC;
            set => SetProperty(ref _coefficientC, value);
        }

        /// <summary>
        /// Список коэффициентов C.
        /// </summary>
        public List<int> CoefficientsList { get; set; }
    }
}