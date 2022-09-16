using NeoStackTech.TestApplication.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTech.TestApplication.Helpers
{
    /// <summary>
    /// Предоставляет набор возможных полиномов.
    /// </summary>
    public class PolynomialList
    {
        /// <summary>
        /// Единственная сущность класса <see cref="PolynomialList"/>.
        /// </summary>
        private static PolynomialList _instance;

        /// <summary>
        /// Набор возможных полиномов.
        /// </summary>
        public ObservableCollection<Polynomial> PolynomialCollection { get; set; }

        /// <summary>
        /// Инициализирует объект класcа <see cref="PolynomialList"/>.
        /// </summary>
        private PolynomialList()
        {
            PolynomialCollection = new ObservableCollection<Polynomial>()
            {
                new Polynomial("Линейная", 1, new List<int> {1,2,3,4,5}),
                new Polynomial("Квадратичная", 2, new List<int> {10,20,30,40,50}),
                new Polynomial("Кубическая", 3, new List<int> {100,200,300,400,500}),
                new Polynomial("4-ой степени", 4, new List<int> {1000,2000,3000,4000,5000}),
                new Polynomial("5-ой степени", 5, new List<int> {10000,20000,30000,40000,50000}),
            };
        }

        /// <summary>
        /// Возвращает сущность класса <see cref="PolynomialList"/>.
        /// </summary>
        /// <returns>Экземпляр <see cref="PolynomialList"/>.</returns>
        public static PolynomialList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PolynomialList();
            }
            return _instance;
        }
    }
}
