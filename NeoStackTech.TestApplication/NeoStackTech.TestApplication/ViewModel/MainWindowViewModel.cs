using Microsoft.VisualStudio.PlatformUI;
using NeoStackTech.TestApplication.Helpers;
using NeoStackTech.TestApplication.Model;
using System.Collections.ObjectModel;

namespace NeoStackTech.TestApplication.ViewModel
{
    /// <summary>
    /// Представляет модель представления для главного окна приложения.
    /// </summary>
    public class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<Polynomial> Polynomials { get; set; }

        public MainWindowViewModel()
        {
            Polynomials = PolynomialList.GetInstance().PolynomialCollection;
        }
    }
}