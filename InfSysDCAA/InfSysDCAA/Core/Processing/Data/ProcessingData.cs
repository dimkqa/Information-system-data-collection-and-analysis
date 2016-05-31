using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Core.Processing.Files;
using InfSysDCAA.Core.Processing.Devices;
using InfSysDCAA.Core.Processing.Test;

namespace InfSysDCAA.Core.Processing.Data
{
    /// <summary>
    /// Класс осуществляет работу с данными. 
    /// Инициирует и проводит тест.
    /// </summary>
    public class ProcessingData
    {
        private string FileName { get; set; }

        public ProcessingData(string fileName)
        {
            FileName = fileName;
            StartProcessing();
        }
        /// <summary>
        /// Запускает обработку файла, инициирует и проводит тестирование
        /// </summary>
        private void StartProcessing()
        {
            try
            {
                SourceProcessing processing = new SourceProcessing(FileName);
                SourceProcessing.ReaderBinaryFile();
                GetDeviceInfo infoDev = new GetDeviceInfo(SourceProcessing.getArrayInventoryNumber());
                Testing startTesting = new Testing(SourceProcessing.RawStructDevice, infoDev.XmlDeviceExport);
                //TODO: ДОДЕЛАТЬ обработку и возврат массива со структурами из XML. Проведение теста.
                //Вызов метода из теста.
                //Необходимо получить листы параметров из XML
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
