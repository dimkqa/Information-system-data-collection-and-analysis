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
        /// Массив результатов теста, каждая структура содержит информацию об устройстве
        /// и результатах теста для этого устройства.
        /// </summary>
        public TestDataStructure.TestDataStruct[] TestResultDataStruct;

        /// <summary>
        /// Содержит данные текущих измерений
        /// </summary>
        private TemporaryDevicesStructure.TmpDevice[] RawDeviceStructure;
        
        /// <summary>
        /// Содержит константные параметры для каждого устройства
        /// </summary>
        private ConstantDeviceStruct.TmpDevice[] ConstDeviceStructure;

        private TestSituation testSituation;
    
        /// <summary>
        /// Пояснения к возможным исходам теста
        /// </summary>
        List<string> Cases = new List<string>
        {
            {"Параметры устройства в норме"},
            {"Параметр"},
            { "Отклонение от стандартного значения: выход за минимально допустимое значение парамтера"},

            {"Выход за максимально допустимое значение"},
            {"Тест не пройден, возникли проблемы"},
            {"Тест успешно пройден"}
        };

        /// <summary>
        /// Число устройств в конкретном тесте
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
            PrepareDataResult();
            for (int i = 0; i < CountDevices; i++)
            {
                TestResultDataStruct[i].DeviceInventNumber = 
                    RawDeviceStructure[i].InventoryNumber;
                TestResultDataStruct[i].DeviceName = 
                    GetDeviceInfoDB.GetDeviceName(RawDeviceStructure[i].InventoryNumber);
                TestResultDataStruct[i].DeviceDescription =
                    GetDeviceInfoDB.GetDeviceDescription(RawDeviceStructure[i].InventoryNumber);
                TestResultDataStruct[i].DeviceManufacturer =
                    GetDeviceInfoDB.GetDeviceManufacturer(RawDeviceStructure[i].InventoryNumber);

                TestResultDataStruct[i].ReceiverDifferentialInputVoltage =
                    TestReceiverDifInVolt(RawDeviceStructure[i].ReceiverDifferentialInputVoltage,
                        ConstDeviceStructure[i].ReceiverDifferentialInputVoltage);
            }
        }

        /// <summary>
        /// Тестирование приёмника 
        /// Три условия:
        /// 1. Текущее значение больше самого минимального и текущее значение меньше самого максимальногоЖ
        // min-eps <= current <= max+eps
        /// 2. Текущее минимальное значение находится в диапазоне допустимых минимальных значений
        // min-eps <= minimum <= min+eps
        /// 3. Текущее максимальное значение находится в диапазоне допустимых максимальных значений
        // max-eps <= maximum <=max+eps
        /// </summary>
        /// <param name="RawData">Обработанные исходные данные</param>
        /// <param name="ConstData">Обработанные постоянные данные</param>
        private Tuple<bool[], List<string>> TestReceiverDifInVolt(List<double> RawData, List<double> ConstData)
        {
            List<string> info = new List<string>();
            bool [] thisStatus = new bool[3];
            if (RawData[2] >= ConstData[0] && RawData[2] <= ConstData[3])
            {
                thisStatus[0] = true;
            }
            else
            {
                thisStatus[0] = false;
            }
            if (RawData[0] >= ConstData[0] && RawData[0] <= ConstData[2])
            {
                thisStatus[0] = true;
            }
            else
            {
                thisStatus[0] = false;
            }
            if (RawData[1] >= ConstData[1] || RawData[1] <= ConstData[3])
            {
            }
            else
            {
                thisStatus[0] = false;
            }
            return Tuple.Create<bool[], List<string>>(thisStatus, info);
        }

        /// <summary>
        /// Тестирование передатчика
        /// </summary>
        private void TestTransDiffOutVolt()
        {

        }

        /// <summary>
        /// Тестирование передатчика
        /// </summary>
        private void TestTransSignalTime()
        {

        }

        /// <summary>
        /// Тестирование требований по питанию +5В
        /// </summary>
        private void TestPowerReqPlusFiveVolt()
        {

        }

        /// <summary>
        /// Тестирование требований по питанию -12В
        /// </summary>
        private void TestPowerReqMinusTwelveVolt()
        {

        }

        /// <summary>
        /// Тестирование требований по питанию +12В Пауза
        /// </summary>
        private void TestPowerReqPlusTwelvePauseVolt()
        {

        }

        /// <summary>
        /// Тестирование требований по питанию +12В 25%
        /// </summary>
        private void TestPowerReqPlusTwelve25Volt()
        {

        }

        /// <summary>
        /// Тестирование требований по питанию +12В 50%
        /// </summary>
        private void TestPowerReqPlusTwelve50Volt()
        {
        }

        /// <summary>
        /// Тестирование требований по питанию +12В 100%
        /// </summary>
        private void TestPowerReqPlusTwelve100Volt()
        {

        }

        /// <summary>
        /// Тестирование требований температуры
        /// </summary>
        private void TestTemperature()
        {

        }

        /// <summary>
        /// Подготовка и инициализация хранилища для сохранения результатов тестирования
        /// </summary>
        private void PrepareDataResult()
        {
            TestResultDataStruct = new TestDataStructure.TestDataStruct[CountDevices];
            for (int i = 0; i < CountDevices; i++)
            {
                TestResultDataStruct[i].ReceiverDifferentialInputVoltage = new Tuple<bool[], List<string>>(new bool[3], new List<string>());
               /* TestResultDataStruct[i].TransmitterDifferentialOutputVoltage = new List<string>();
                TestResultDataStruct[i].TransmitterRiseRecessionSignalTime = new List<string>();
                TestResultDataStruct[i].PowerReqPlusFiveVoltage = new List<string>();
                TestResultDataStruct[i].PowerReqMinusTwelveVoltage = new List<string>();
                TestResultDataStruct[i].PowerReqPlusTwelvePauseVoltage = new List<string>();
                TestResultDataStruct[i].PowerReqPlusTwelve25Voltage = new List<string>();
                TestResultDataStruct[i].PowerReqPlusTwelve50Voltage = new List<string>();
                TestResultDataStruct[i].PowerReqPlusTwelve100Voltage = new List<string>();
                TestResultDataStruct[i].Temperature = new List<string>();*/
                TestResultDataStruct[i].DeviceStatusDescription = new List<string>();
                TestResultDataStruct[i].DeviceDataDescriptionTest = new List<string>();
            }
        }

    }
}
