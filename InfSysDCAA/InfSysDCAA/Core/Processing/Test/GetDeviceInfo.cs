using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Core.Directory;
using InfSysDCAA.Core.XML.Devices.Reader;

namespace InfSysDCAA.Core.Processing.Test
{
    /// <summary>
    /// Получает эталонные значения плат, которые находятся в XML-файле
    /// </summary>
    public class GetDeviceInfo
    {
        /// <summary>
        /// Содержит структуру устройства из XML
        /// </summary>
        private ReaderParamsXML _xmlReaderParamDevice;

        public  string[] InventoryNumbers
        {
            get { return InvNumbers; }
            private set { InvNumbers = value; }
        }
        private string[] InvNumbers;

        /// <summary>
        /// Принимает массив инвентарных номеров
        /// </summary>
        /// <param name="InventoryNumbers">string[], массив инвентарных номеров</param>
        public GetDeviceInfo(string[] InventNumbers)
        {
            InventoryNumbers = InventNumbers;
            try
            {
                _xmlReaderParamDevice = new ReaderParamsXML(InventoryNumbers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            /// 1. Найти файл по инвентаному номеру (обратиться в ReaderParamsXML.cs, передав туда инвентарный номер).
            /// 2. Распарсить файл в листы
            /// 3. Вернуть листы отсюда в вызов.
            /// 4. Если Файла с таким инвентарным номером нет, то выдать ошибку 
        }

        public double GetDataWithLimit()
        {
            double s = 0.0;
            return s;
        }
    }
}
