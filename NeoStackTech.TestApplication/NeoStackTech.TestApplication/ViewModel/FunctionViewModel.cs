using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTech.TestApplication.ViewModel
{
    /// <summary>
    /// Модель функции для расчёта.
    /// </summary>
    public class FunctionViewModel : ObservableObject
    {
        /// <summary>
        /// Аргумент x.
        /// </summary>
        private string _argumentX;

        /// <summary>
        /// Аргумент y.
        /// </summary>
        private string _argumentY;

        /// <summary>
        /// Значение функции для данных аргументов.
        /// </summary>
        private double _functionResult;

        /// <summary>
        /// Инициализирует объект класса <see cref="FunctionViewModel"/>.
        /// </summary>
        public FunctionViewModel()
        {
            ArgumentX = "0";
            ArgumentY = "0";
        }

        /// <summary>
        /// Аргумент x.
        /// </summary>
        public string ArgumentX
        {
            get => _argumentX;
            set
            {
                if (value.Length > 0)
                {
                    if (double.TryParse(value, out double res))
                    {
                        SetProperty(ref _argumentX, value);
                    }
                }
                else
                {
                    SetProperty(ref _argumentX, "0");
                }
            }
        }

        /// <summary>
        /// Аргумент y.
        /// </summary>
        public string ArgumentY
        {
            get => _argumentY;
            set
            {
                if (value.Length > 0)
                {
                    if (double.TryParse(value, out double res))
                    {
                        SetProperty(ref _argumentY, value);
                    }
                }
                else
                {
                    SetProperty(ref _argumentY, "0");
                }
            }
        }

        /// <summary>
        /// Значение функции для данных аргументов.
        /// </summary>
        public double FunctionResult
        {
            get => _functionResult;
            set => SetProperty(ref _functionResult, value);
        }
    }
}
