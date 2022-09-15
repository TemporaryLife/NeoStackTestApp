using NeoStackTech.TestApplication.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTech.TestApplication.Helpers
{
    public class PolynomialList
    {
        private PolynomialList _instance;

        public ObservableCollection<Polynomial> PolynomialCollection { get; set; }

        private PolynomialList()
        {
            PolynomialCollection = new ObservableCollection<Polynomial>()
            {
                new Polynomial(new List<int> {1,2,3,4,5}),
                new Polynomial(new List<int> {10,20,30,40,50}),
                new Polynomial(new List<int> {100,200,300,400,500}),
                new Polynomial(new List<int> {1000,2000,3000,4000,5000}),
                new Polynomial(new List<int> {10000,20000,30000,40000,50000}),
            };
        }

        public static PolynomialList GetInstance()
        {
            if (_instance == null)
            {
                return new PolynomialList();
            }
            return _instance;
        }
    }
}
