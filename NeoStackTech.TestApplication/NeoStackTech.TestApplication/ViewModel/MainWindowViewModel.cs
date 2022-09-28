using GalaSoft.MvvmLight.Command;
using Microsoft.VisualStudio.PlatformUI;
using NeoStackTech.TestApplication.Helpers;
using NeoStackTech.TestApplication.Services;
using System.Collections.ObjectModel;
using System.Timers;

namespace NeoStackTech.TestApplication.ViewModel
{
    /// <summary>
    /// Представляет модель представления для главного окна приложения.
    /// </summary>
    public class MainWindowViewModel : ObservableObject
    {

        /// <summary>
        /// Выбранный полином.
        /// </summary>
        private PolynomialViewModel _selectedPolynomial;

        /// <summary>
        /// Инициализирует объект класса <see cref="MainWindowViewModel"/>.
        /// </summary>
        public MainWindowViewModel()
        {
            Polynomials = PolynomialList.GetInstance().PolynomialCollection;
            Functions = new ObservableCollection<FunctionViewModel>();

            AddColumnCommand = new RelayCommand(AddColumn);
            UpdateCoefficientsCommand = new RelayCommand(CheckAndUpdateCoefficient);
        }

        /// <summary>
        /// Команда добавления строки.
        /// </summary>
        public RelayCommand AddColumnCommand { get; }

        /// <summary>
        /// Команда обновления коэффициентов.
        /// </summary>
        public RelayCommand UpdateCoefficientsCommand { get; }

        /// <summary>
        /// Количество добавленных пользователем функций для расчёта.
        /// </summary>
        public ObservableCollection<FunctionViewModel> Functions { get; set; }

        /// <summary>
        /// Набор возможных полиномов.
        /// </summary>
        public ObservableCollection<PolynomialViewModel> Polynomials { get; set; }

        /// <summary>
        /// Выбранный полином.
        /// </summary>
        public PolynomialViewModel SelectedPolynomial
        {
            get => _selectedPolynomial;
            set => SetProperty(ref _selectedPolynomial, value);
        }

        /// <summary>
        /// Добавляет строку в таблицу.
        /// </summary>
        private void AddColumn()
        {
            FunctionViewModel newFunction = new FunctionViewModel();
            Functions.Add(newFunction);

            CheckAndUpdateCoefficient();
        }

        /// <summary>
        /// Проверяет на корректность и обновляет коэффициенты.
        /// </summary>
        private void CheckAndUpdateCoefficient()
        {

            if (SelectedPolynomial != null)
            {
                foreach (FunctionViewModel function in Functions)
                {

                    var coefficientA = double.Parse(SelectedPolynomial.CoefficientA);
                    var coefficientB = double.Parse(SelectedPolynomial.CoefficientB);
                    var argumentX = double.Parse(function.ArgumentX);
                    var argumentY = double.Parse(function.ArgumentY);

                    function.FunctionResult = CalculateFunctionValueService.GetFunctionValue(
                                                                   coefficientA,
                                                                   coefficientB,
                                                                   SelectedPolynomial.CoefficientC,
                                                                   argumentX,
                                                                   argumentY,
                                                                   SelectedPolynomial.Power);
                }
            }
        }
    }
}