﻿using Microsoft.VisualStudio.PlatformUI;
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
        private double _coefficientA;

        /// <summary>
        /// Коэффициент B.
        /// </summary>
        private double _coefficientB;

        /// <summary>
        /// Коэффициент C.
        /// </summary>
        private double _coefficientC;

        /// <summary>
        /// Инициализирует объект класса <see cref="Polynomial"/>.
        /// </summary>
        /// <param name="coefficientsList">Cписок коэффициентов С.</param>
        public Polynomial(string name,int power,List<double> coefficientsList)
        {
            Name = name;
            Power = power;
            CoefficientsList = coefficientsList;
        }

        /// <summary>
        /// Имя полинома.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Коэффициент А.
        /// </summary>
        public double CoefficientA
        {
            get => _coefficientA;
            set => SetProperty(ref _coefficientA, value);
        }

        /// <summary>
        /// Коэффициент B.
        /// </summary>
        public double CoefficientB
        {
            get => _coefficientB;
            set => SetProperty(ref _coefficientB, value);
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
        /// Максимальная степень полинома.
        /// </summary>
        public int Power { get; set; }
    }
}