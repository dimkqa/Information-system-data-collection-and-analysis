using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using InfSysDCAA.Core.Processing.Devices;
using InfSysDCAA.Core.Processing;

namespace InfSysDCAA.Core.Processing.Files
{
    /// <summary>
    /// Класс для обработки файла с данными.
    /// Производит парсинг файла.
    /// </summary>
    public class SourceProcessing
    {
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
                //Узнаем сколько устройств было в тесте
                CountDevicesInTheTest = reader.ReadInt32();
                //Вернемся к началу файла
                reader.BaseStream.Position = 0;
                //Узнаем сколько всего байт в файле на все устройства
                DevicesStruct.LengthAllDevicesBytes = DevicesStruct.LengthDeviceInBytes * CountDevicesInTheTest;

                //Создаём и инициализируем поля структуры
                TemporaryDevicesStructure.TmpDevice[] t = new TemporaryDevicesStructure.TmpDevice[CountDevicesInTheTest];

                for (int i = 0; i < CountDevicesInTheTest; i++)
                {
                    t[i].ReceiverDifferentialInputVoltage = new List<double>();
                    t[i].TransmitterDifferentialOutputVoltage = new List<double>();
                    t[i].TransmitterRiseRecessionSignalTime = new List<double>();
                    t[i].PowerReqPlusFiveVoltage = new List<double>();
                    t[i].PowerReqMinusTwelveVoltage = new List<double>();
                    t[i].PowerReqPlusTwelvePauseVoltage = new List<double>();
                    t[i].PowerReqPlusTwelve25Voltage = new List<double>();
                    t[i].PowerReqPlusTwelve50Voltage = new List<double>();
                    t[i].PowerReqPlusTwelve100Voltage = new List<double>();
                    t[i].Temperature = new List<double>();
                }

                //Число устройств
                CounterDevices = 0;
                //В цикле будем считывать данные устройств пока не дойдем до конца файла
                while (reader.BaseStream.Position != DevicesStruct.LengthAllDevicesBytes)
                {
                    //Читаем 4 байта разделителя
                    reader.ReadInt32();
                    //Читаем инвентарный номер
                    t[CounterDevices].InventoryNumber = reader.ReadString();
                    //Смещение на начало сегмента
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    //Читаем данные приёмника
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        t[CounterDevices].ReceiverDifferentialInputVoltage.Add(reader.ReadDouble());
                    }
                    //Читаем данные передатчика
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        t[CounterDevices].TransmitterDifferentialOutputVoltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        t[CounterDevices].TransmitterRiseRecessionSignalTime.Add(reader.ReadDouble());
                    }
                    //Читаем требования по питанию
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        t[CounterDevices].PowerReqPlusFiveVoltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        t[CounterDevices].PowerReqMinusTwelveVoltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        t[CounterDevices].PowerReqPlusTwelvePauseVoltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        t[CounterDevices].PowerReqPlusTwelve25Voltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        t[CounterDevices].PowerReqPlusTwelve50Voltage.Add(reader.ReadDouble());
                    }
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        t[CounterDevices].PowerReqPlusTwelve100Voltage.Add(reader.ReadDouble());
                    }
                    //Читаем данные по температуре
                    CurrentPosition = (int)reader.BaseStream.Position - 1;
                    while (reader.BaseStream.Position <= CurrentPosition + 800)
                    {
                        t[CounterDevices].Temperature.Add(reader.ReadDouble());
                    }
                    CounterDevices++;
                }
                ///TODO: Завершить обработку файлов - обсчет прямых измерений
            }
        }
    }
}