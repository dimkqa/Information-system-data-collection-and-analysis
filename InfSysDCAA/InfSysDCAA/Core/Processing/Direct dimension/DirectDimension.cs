using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Processing.Direct_dimension
{
    /// <summary>
    /// Класс отвечает за обработку результатов измерений
    /// </summary>
    public class DirectDimension
    {

        /// <summary>
        /// Результат обработки вместе с погрешностью
        /// </summary>
        public double ResultDimension {
            get { return rd; }
            set { rd = value; }
        }
        /// <summary>
        /// Результаты обработки вместе с погрешностью
        /// </summary>
        private double rd;

        /// <summary>
        /// Погрешность измерения, берется из файла
        /// </summary>
        public double Epsilon { get; set; }

        public DirectDimension()
        {
            
        }
    }
}
