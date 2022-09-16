using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTech.TestApplication.Model
{
    /// <summary>
    /// Модель функции для расчёта.
    /// </summary>
    public class Function : ObservableObject
    {
        /// <summary>
        /// Аргумент x.
        /// </summary>
        private double _argumentX;

        /// <summary>
        /// Аргумент y.
        /// </summary>
        private double _argumentY;
        
        /// <summary>
        /// Значение функции для данных аргументов.
        /// </summary>
        private double _functionResult;

        /// <summary>
        /// Аргумент x.
        /// </summary>
        public double ArgumentX
        {
            get => _argumentX;
            set => SetProperty(ref _argumentX, value);
        }

        /// <summary>
        /// Аргумент y.
        /// </summary>
        public double ArgumentY
        {
            get => _argumentY;
            set => SetProperty(ref _argumentY, value);
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
