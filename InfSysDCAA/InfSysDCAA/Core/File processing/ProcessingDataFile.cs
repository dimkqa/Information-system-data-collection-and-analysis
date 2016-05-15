using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.File_processing
{
    public sealed class ProcessingDataFile
    {
        public string FilePath { get; set; }
        public ProcessingDataFile(string Path)
        {
            FilePath = Path;
        }





        /// <summary>
        /// Структура описывает параметры одного устрйоства целиком:
        /// - Инвентарный номер
        /// - Данные приёмника
        /// - Данные передатчика
        /// - Данные температуры
        /// </summary>
        struct Device
        {
            public string InventoryNumber;
            public List<double> DataTransmitter;
            public Dictionary<string, List<double>> DataReciver;
            public Dictionary<string, List<double>> DataPowerRequirements;
            public List<double> DataTemperature;
        }

        /// <summary>
        /// Производит расшифровку бинарного файла.
        /// Производит чтение файла, пока не наступит его конец
        /// </summary>
        public void DataBinReader()
        {
            byte[] bytes = new byte[1];
            //Что бы узнать, данные скольких устройств лежат в данном файле, необходимо прочитать первые 4 байта файла.
            using (BinaryReader reader = new BinaryReader(File.Open(FilePath, FileMode.Open)))
            {
                reader.Read(bytes, 0, 1);
            }
        }


        //Следующие 4 байта обозначают инвентарный номер устройства

        //Последующие 800 байт занимают измерения
    }
}
