using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Processing.Direct_dimension
{
    /// <summary>
    /// Класс осуществляет обработку прямых измерений, полученных
    /// из файла данных.
    /// </summary>
    public class Options_list
    {
        /// <summary>
        /// Среднее значение 
        /// </summary>
        private double Average
        {
            get { return ListInApp.Average(); }
            set { }
        }
        /// <summary>
        /// Максимальное значение
        /// </summary>
        private double Maximum
        {
            get { return ListInApp.Max(); }
            set { }
        }

        private List<double> ListInApp { get; set; }

        /// <summary>
        /// Минимальное значение
        /// </summary>
        private double Minimum
        {
            get { return ListInApp.Min(); }
            set {  }
        }

        /// <summary>
        /// Необходимо передавать в этот метод текущий лист данных, и допуск к эти данны в соответствии с инвентарным номером.
        /// </summary>
        public Options_list(List<double> list)
        {
            ListInApp = list;
        }

        /// <summary>
        /// Метод находит минимальное значение выборки данных
        /// </summary>
        /// <returns>Возвращает минимальное значение выборки данных типа double</returns>
        public double MinimumInList()
        {
            return Minimum;
        }

        /// <summary>
        /// Метод находит максимальное значение выборки данных
        /// </summary>
        /// <returns>Возвращает максимальное значение выборки данных типа double</returns>
        public double MaximumInList()
        {
            return Maximum;
        }

        /// <summary>
        /// Метод находит среднее значение выборки данных
        /// </summary>
        /// <returns>Возвращает среднее значение выборки данных типа double</returns>
        public double AverageInList()
        {
            return Average;
        }
    }
}
