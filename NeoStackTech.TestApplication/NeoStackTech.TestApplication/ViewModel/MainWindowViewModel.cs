using GalaSoft.MvvmLight.Command;
using Microsoft.VisualStudio.PlatformUI;
using NeoStackTech.TestApplication.Helpers;
using NeoStackTech.TestApplication.Model;
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
        /// Период срабатывания таймера <see cref="_calculatingTimer"/>.
        /// </summary>
        private const int CALCULATING_TIMER_ELAPSED_PERIOD_MILLISECONDS = 1000;

        /// <summary>
        /// Выбранный полином.
        /// </summary>
        private Polynomial _selectedPolynomial;

        /// <summary>
        /// Таймер вызова расчёта значений функций.
        /// </summary>
        private Timer _calculatingTimer;

        /// <summary>
        /// Набор возможных полиномов.
        /// </summary>
        public ObservableCollection<Polynomial> Polynomials { get; set; }

        /// <summary>
        /// Количество добавленных пользователем функций для расчёта.
        /// </summary>
        public ObservableCollection<Function> Functions { get; set; }

        /// <summary>
        /// Выбранный полином.
        /// </summary>
        public Polynomial SelectedPolynomial
        {
            get => _selectedPolynomial;
            set => SetProperty(ref _selectedPolynomial, value);
        }

        /// <summary>
        /// Команда добавления строки.
        /// </summary>
        public RelayCommand AddColumnCommand { get; }

        /// <summary>
        /// Инициализирует объект класса <see cref="MainWindowViewModel"/>.
        /// </summary>
        public MainWindowViewModel()
        {
            Polynomials = PolynomialList.GetInstance().PolynomialCollection;
            Functions = new ObservableCollection<Function>();

            ConfigureCalculatingTimer();
            _calculatingTimer?.Start();

            AddColumnCommand = new RelayCommand(AddColumn);
        }

        /// <summary>
        /// Настраивает таймер расчёта значений функции.
        /// </summary>
        private void ConfigureCalculatingTimer()
        {
            _calculatingTimer = new Timer();
            _calculatingTimer.Interval = CALCULATING_TIMER_ELAPSED_PERIOD_MILLISECONDS;
            _calculatingTimer.Elapsed += CalculatingTimerElapsed;
        }

        /// <summary>
        /// Добавляет строку в таблицу.
        /// </summary>
        private void AddColumn()
        {
            Function newFunction = new Function();
            Functions.Add(newFunction);
        }

        /// <summary>
        /// Расчитывает значение функции для каждой строки. Вызывается при срабатывании таймера <see cref="_calculatingTimer"/>.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>
        private void CalculatingTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (SelectedPolynomial != null)
            {
                foreach (Function function in Functions)
                {
                    function.FunctionResult = CalculateFunctionValueService.GetFunctionValue(
                                                                   SelectedPolynomial.CoefficientA,
                                                                   SelectedPolynomial.CoefficientB,
                                                                   SelectedPolynomial.CoefficientC,
                                                                   function.ArgumentX,
                                                                   function.ArgumentY,
                                                                   SelectedPolynomial.Power);
                }
            }
        }
    }
}