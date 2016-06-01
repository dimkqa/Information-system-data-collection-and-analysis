using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfSysDCAA.Core.Processing.Devices;

namespace InfSysDCAA.Core.Processing.Test
{
    /// <summary>
    /// Производит тестирование параметров.
    /// </summary>
    public class Testing
    {
        /// <summary>
        /// Содержит данные текущих измерений
        /// </summary>
        private TemporaryDevicesStructure.TmpDevice[] RawDeviceStructure;
        /// <summary>
        /// Содержит константные параметры для каждого устройства
        /// </summary>
        private ConstantDeviceStruct.TmpDevice[] ConstDeviceStructure;

        /// <summary>
        /// Число устройств теста
        /// </summary>
        private int CountDevices;

        /// <summary>
        /// Конструктор задаёт параметры класса и подготавлвает их для дальнейшего использования
        /// </summary>
        /// <param name="deviceRaw"> Массив структур данных, расшифрованный из файла с иходными данными </param>
        /// <param name="deviceConst">Массив структур данных, взятых из файла настроек (XML),
        /// изначально содержит данные вместе с допуском</param>
        public Testing(TemporaryDevicesStructure.TmpDevice[] deviceRaw, ConstantDeviceStruct.TmpDevice[] deviceConst)
        {
            if (deviceRaw.Count() != deviceConst.Count())
            {
                throw new Exception("Размеры структур исходных и постоянных данных не совпадают");
            }
            else
            {
                CountDevices = deviceRaw.Count();
                RawDeviceStructure = deviceRaw;
                ConstDeviceStructure = deviceConst;
            }
        }

        /// <summary>
        /// Иницирует тестирование
        /// </summary>
        public void StartTest()
        {
            PrepareTupleResult();
            for (int i = 0; i < CountDevices; i++)
            {
                TestReceiverDifferentialInputVoltage(RawDeviceStructure[i].ReceiverDifferentialInputVoltage,
                    ConstDeviceStructure[i].ReceiverDifferentialInputVoltage);
            }
        }

        /// <summary>
        /// Получить результаты теста
        /// </summary>
        public void GetResultTest()
        {
            
        }

        /// <summary>
        /// Тестирование приёмника 
        /// </summary>
        /// <param name="RawData">Обработанные исходные данные</param>
        /// <param name="ConstData">Обработанные постоянные данные</param>
        private void TestReceiverDifferentialInputVoltage(List<double> RawData, List<double> ConstData)
        {
            bool[] resultTest = new bool[3];
            //текущее среднее > минимум-допуск И текущее среднее < максимум+допуск
            if (RawData[2] > ConstData[0] && RawData[2] < ConstData[3])
            {
                resultTest[0] = true;
            }
            else
            {
                resultTest[0] = false;
            }
            //текущее мин < минимум-допуск или текущее мин < минимум+допуск
            if (RawData[0] < ConstData[0] || RawData[0] < ConstData[2])
            {
                resultTest[1] = true;
            }
            else
            {
                resultTest[1] = false;
            }
            //текущее макс > максимум-допуск или текущее макс > максимум+допуск
            if (RawData[1] > ConstData[1] || RawData[1] > ConstData[3])
            {
                resultTest[2] = true;
            }
            else
            {
                resultTest[2] = false;
            }
        }

        /// <summary>
        /// Тестирование передатчика
        /// </summary>
        private void TestTransmitterDifferentialOutputVoltage()
        {

        }

        /// <summary>
        /// Тестирование передатчика
        /// </summary>
        private void TestTransmitterRiseRecessionSignalTime()
        {

        }

        /// <summary>
        /// Тестирование требований по питанию +5В
        /// </summary>
        private void TestPowerReqPlusFiveVoltage()
        {

        }

        /// <summary>
        /// Тестирование требований по питанию -12В
        /// </summary>
        private void TestPowerReqMinusTwelveVoltage()
        {

        }

        /// <summary>
        /// Тестирование требований по питанию +12В Пауза
        /// </summary>
        private void TestPowerReqPlusTwelvePauseVoltage()
        {

        }

        /// <summary>
        /// Тестирование требований по питанию +12В 25%
        /// </summary>
        private void TestPowerReqPlusTwelve25Voltage()
        {

        }

        /// <summary>
        /// Тестирование требований по питанию +12В 50%
        /// </summary>
        private void TestPowerReqPlusTwelve50Voltage()
        {
        }

        /// <summary>
        /// Тестирование требований по питанию +12В 100%
        /// </summary>
        private void TestPowerReqPlusTwelve100Voltage()
        {

        }

        /// <summary>
        /// Тестирование требований температуры
        /// </summary>
        private void TestTemperature()
        {

        }

        /// <summary>
        /// Подготовка хранилища для результатов
        /// </summary>
        private void PrepareTupleResult()
        {
            
        }

    }
}
