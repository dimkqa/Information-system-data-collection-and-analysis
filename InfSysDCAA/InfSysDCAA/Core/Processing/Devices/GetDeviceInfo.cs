using System;
using System.Windows.Forms;
using InfSysDCAA.Core.XML.Devices.Reader;

namespace InfSysDCAA.Core.Processing.Devices
{
    /// <summary>
    /// Получает эталонные значения плат, которые находятся в XML-файле
    /// </summary>
    public class GetDeviceInfo
    {
        /// <summary>
        /// Массив структур с параметрами
        /// </summary>
        public ConstantDeviceStruct.TmpDevice[] XmlDeviceExport;

        /// <summary>
        /// Содержит структуру устройства из XML
        /// </summary>
        private ReaderParamsXML _xmlReaderParamDevice;

        /// <summary>
        /// Инвентарные номера устройств
        /// </summary>
        public string[] InventoryNumbers
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
                XmlDeviceExport = _xmlReaderParamDevice.XmlDeviceExport;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /// 1. Найти файл по инвентаному номеру (обратиться в ReaderParamsXML.cs, передав туда инвентарный номер).
            /// 2. Распарсить файл в листы
            /// 3. Вернуть листы отсюда в вызов.
            /// 4. Если Файла с таким инвентарным номером нет, то выдать ошибку 
        }
    }
}
