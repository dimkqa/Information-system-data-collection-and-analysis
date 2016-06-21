using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using InfSysDCAA.Core.Processing.Devices;
using InfSysDCAA.Core.Processing;
using InfSysDCAA.Core.Processing.Test;

namespace InfSysDCAA.Core.Processing.Files
{
    /// <summary>
    /// Класс для обработки файла с данными.
    /// Производит парсинг файла.
    /// </summary>
    public class SourceProcessing
    {
        /// <summary>
        /// Содержит структуры для передачи в тест.
        /// </summary>
        public static TemporaryDevicesStructure.TmpDevice[] RawStructDevice { get; set; }

        /// <summary>
        /// Содержит структуры для считывания в них исходных данных
        /// </summary>
        private static TemporaryDevicesStructure.TmpDevice[] RawTmpStructDevice { get; set; }

        /// <summary>
        /// Полный путь до файла
        /// </summary>
        public static string FullPathToFile { get; set; }
        /// <summary>
        /// Число устройств в тесте
        /// </summary>
        private static int CountDevicesInTheTest { get; set; }
        /// <summary>
        /// Текущая позиция в файле во время чтения
        /// </summary>
        private static int CurrentPosition { get; set; }
        /// <summary>
        /// Счётчик устройств
        /// </summary>
        private static int CounterDevices { get; set; }

        /// <summary>
        /// Консруктор принимает полный путь до файла.
        /// Задаётся в окне выбора файла
        /// </summary>
        /// <param name="fullPathToFile">String - полный путь до файла</param>
        public SourceProcessing(string fullPathToFile)
        {
            FullPathToFile = fullPathToFile;
        }

        /// <summary>
        /// Производит чтение и парсинг файла с данными
        /// Рассортировывает данные в предоставленые контейнеры 
        /// </summary>
        public static void ReaderBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(FullPathToFile, FileMode.Open), Encoding.ASCII))
            {
                // TODO: проверка файла на размеры
                //Узнаем сколько устройств было в тесте
                CountDevicesInTheTest = reader.ReadInt32();
                //Вернемся к началу файла
                reader.BaseStream.Position = 0;
                //Узнаем сколько всего байт в файле на все устройства
                DevicesStruct.LengthAllDevicesBytes = DevicesStruct.LengthDeviceInBytes * CountDevicesInTheTest;

                //Создаём и инициализируем поля структуры
                InitStructure(CountDevicesInTheTest);

                //Число устройств
                CounterDevices = 0;
                //В цикле будем считывать данные устройств пока не дойдем до конца файла
                while (reader.BaseStream.Position != DevicesStruct.LengthAllDevicesBytes)
                {
                    //Читаем 4 байта разделителя
                    reader.ReadInt32();
                    //Читаем инвентарный номер
                    RawTmpStructDevice[CounterDevices].InventoryNumber = reader.ReadString();
                    //Смещение на начало сегмента
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    //Читаем данные приёмника
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        RawTmpStructDevice[CounterDevices].ReceiverDifferentialInputVoltage.Add(reader.ReadDouble());
                    }
                    //Читаем данные передатчика
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        RawTmpStructDevice[CounterDevices].TransmitterDifferentialOutputVoltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        RawTmpStructDevice[CounterDevices].TransmitterRiseRecessionSignalTime.Add(reader.ReadDouble());
                    }
                    //Читаем требования по питанию
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        RawTmpStructDevice[CounterDevices].PowerReqPlusFiveVoltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        RawTmpStructDevice[CounterDevices].PowerReqMinusTwelveVoltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        RawTmpStructDevice[CounterDevices].PowerReqPlusTwelvePauseVoltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        RawTmpStructDevice[CounterDevices].PowerReqPlusTwelve25Voltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        RawTmpStructDevice[CounterDevices].PowerReqPlusTwelve50Voltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        RawTmpStructDevice[CounterDevices].PowerReqPlusTwelve100Voltage.Add(reader.ReadDouble());
                    }
                    //Читаем данные по температуре
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        RawTmpStructDevice[CounterDevices].Temperature.Add(reader.ReadDouble());
                    }
                    CounterDevices++;
                }
                CopyStructure();
                ///TODO: Здесь могут быть прямые измерения
            }
        }

        /// <summary>
        /// Производит копирование структуры
        /// </summary>
        private static void CopyStructure()
        {
            RawStructDevice = RawTmpStructDevice;
        }

        public static string[] getArrayInventoryNumber()
        {
            string [] strInv = new string[CountDevicesInTheTest];
            for (int i = 0; i < CountDevicesInTheTest; i++)
            {
                strInv[i] = RawTmpStructDevice[i].InventoryNumber;
            }
            return strInv;
        }

        /// <summary>
        /// Инициализирует структуры устройств для записи данных из файла и для передачи в тест
        /// </summary>
        /// <param name="countDeviceTest">Int, число параметров</param>
        private static void InitStructure(int countDeviceTest)
        {
            RawStructDevice = new TemporaryDevicesStructure.TmpDevice[countDeviceTest];
            RawTmpStructDevice = new TemporaryDevicesStructure.TmpDevice[countDeviceTest];
            for (int i = 0; i < countDeviceTest; i++)
            {
                RawTmpStructDevice[i].ReceiverDifferentialInputVoltage = new List<double>();
                RawStructDevice[i].ReceiverDifferentialInputVoltage = new List<double>();
                RawTmpStructDevice[i].TransmitterDifferentialOutputVoltage = new List<double>();
                RawStructDevice[i].TransmitterDifferentialOutputVoltage = new List<double>();
                RawTmpStructDevice[i].TransmitterRiseRecessionSignalTime = new List<double>();
                RawStructDevice[i].TransmitterRiseRecessionSignalTime = new List<double>();
                RawTmpStructDevice[i].PowerReqPlusFiveVoltage = new List<double>();
                RawStructDevice[i].PowerReqPlusFiveVoltage = new List<double>();
                RawTmpStructDevice[i].PowerReqMinusTwelveVoltage = new List<double>();
                RawStructDevice[i].PowerReqMinusTwelveVoltage = new List<double>();
                RawTmpStructDevice[i].PowerReqPlusTwelvePauseVoltage = new List<double>();
                RawStructDevice[i].PowerReqPlusTwelvePauseVoltage = new List<double>();
                RawTmpStructDevice[i].PowerReqPlusTwelve25Voltage = new List<double>();
                RawStructDevice[i].PowerReqPlusTwelve25Voltage = new List<double>();
                RawTmpStructDevice[i].PowerReqPlusTwelve50Voltage = new List<double>();
                RawStructDevice[i].PowerReqPlusTwelve50Voltage = new List<double>();
                RawTmpStructDevice[i].PowerReqPlusTwelve100Voltage = new List<double>();
                RawStructDevice[i].PowerReqPlusTwelve100Voltage = new List<double>();
                RawTmpStructDevice[i].Temperature = new List<double>();
                RawStructDevice[i].Temperature = new List<double>();
            }
        }
    }
}