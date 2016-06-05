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

        /// <summary>
        /// Содержит текстовые пояснения к тесту
        /// </summary>
        private List<string> explanationsTextResultInfo = new List<string>();

        /// <summary>
        /// Содержит булевый парамтер - успешность прохождения на соответствие
        /// </summary>
        private bool[] thisResultStatus = new bool[3];

        /// <summary>
        /// Содержит список параметров
        /// </summary>
        private List<double> dataParametrsInfo = new List<double>();

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
                /*TestResultDataStruct[i].DeviceName = 
                    GetDeviceInfoDB.GetDeviceName(RawDeviceStructure[i].InventoryNumber);
                TestResultDataStruct[i].DeviceDescription =
                    GetDeviceInfoDB.GetDeviceDescription(RawDeviceStructure[i].InventoryNumber);
                TestResultDataStruct[i].DeviceManufacturer =
                    GetDeviceInfoDB.GetDeviceManufacturer(RawDeviceStructure[i].InventoryNumber);
                    */
                TestResultDataStruct[i].ReceiverDifferentialInputVoltage =
                    TestReceiverDifInVolt(RawDeviceStructure[i].ReceiverDifferentialInputVoltage,
                        ConstDeviceStructure[i].ReceiverDifferentialInputVoltage);
                TestResultDataStruct[i].TransmitterDifferentialOutputVoltage =
                    TestTransDiffOutVolt(RawDeviceStructure[i].TransmitterDifferentialOutputVoltage,
                        ConstDeviceStructure[i].TransmitterDifferentialOutputVoltage);

                TestResultDataStruct[i].TransmitterRiseRecessionSignalTime =
                    TestTransSignalTime(RawDeviceStructure[i].TransmitterRiseRecessionSignalTime,
                        ConstDeviceStructure[i].TransmitterRiseRecessionSignalTime);

                TestResultDataStruct[i].PowerReqPlusFiveVoltage =
                    TestPowerReqPlusFiveVolt(RawDeviceStructure[i].PowerReqPlusFiveVoltage,
                        ConstDeviceStructure[i].PowerReqPlusFiveVoltage);
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
        private Tuple<bool[], List<string>, List<double>> TestReceiverDifInVolt(List<double> RawData, List<double> ConstData)
        {
            clearDataRepository();
            if (RawData[2] >= ConstData[0] && RawData[2] <= ConstData[3])
            {
                thisResultStatus[0] = true;
                explanationsTextResultInfo.Add("Среднее значение параметра находится в допустимых границах");
                dataParametrsInfo.Add(RawData[2]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[3]);
            }
            else
            {
                if (RawData[2] < ConstData[0])
                {
                    thisResultStatus[0] = false;
                    explanationsTextResultInfo.Add("Среднее значение параметра ниже, чем его самое максимальное значение с допуском");
                }
                else
                {
                    thisResultStatus[0] = false;
                    explanationsTextResultInfo.Add("Среднее значение параметра выше, чем его самое максимальное значение с допуском");
                }
                dataParametrsInfo.Add(RawData[2]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[3]);
            }
            if (RawData[0] >= ConstData[0] && RawData[0] <= ConstData[2])
            {
                thisResultStatus[1] = true;
                explanationsTextResultInfo.Add("Минимальное значение параметра находится в допустимых границах");
                dataParametrsInfo.Add(RawData[0]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[2]);
            }
            else
            {
                if (RawData[0] < ConstData[0])
                {
                    thisResultStatus[1] = false;
                    explanationsTextResultInfo.Add("Минимальное значение параметра ниже, чем его самое миниальное значение с допуском");
                }
                else
                {
                    thisResultStatus[1] = false;
                    explanationsTextResultInfo.Add("Минимальное значение параметра выше, чем его самое миниальное значение с допуском");
                }
                dataParametrsInfo.Add(RawData[0]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[2]);
            }
            if (RawData[1] <= ConstData[3])
            {
                thisResultStatus[2] = true;
                explanationsTextResultInfo.Add("Максимальное значение параметра не превышает значения с допуском");
                dataParametrsInfo.Add(RawData[1]); dataParametrsInfo.Add(ConstData[3]);
            }
            else
            {
                if (RawData[1] > ConstData[3])
                {
                    thisResultStatus[2] = false;
                    explanationsTextResultInfo.Add("Максимальное значение параметра выше, чем его самое высокое значение с допуском");
                    dataParametrsInfo.Add(RawData[1]); dataParametrsInfo.Add(ConstData[3]);
                }
            }
            return Tuple.Create<bool[], List<string>, List<double>>(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Тестирование передатчика
        /// </summary>
        private Tuple<bool[], List<string>, List<double>> TestTransDiffOutVolt(List<double> RawData, List<double> ConstData)
        {
            clearDataRepository();
            if (RawData[2] >= ConstData[0] && RawData[2] <= ConstData[3])
            {
                thisResultStatus[0] = true;
                explanationsTextResultInfo.Add("Среднее значение параметра находится в допустимых границах");
                dataParametrsInfo.Add(RawData[2]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[3]);
            }
            else
            {
                if (RawData[2] < ConstData[0])
                {
                    thisResultStatus[0] = false;
                    explanationsTextResultInfo.Add("Среднее значение параметра ниже, чем его самое максимальное значение с допуском");
                }
                else
                {
                    thisResultStatus[0] = false;
                    explanationsTextResultInfo.Add("Среднее значение параметра выше, чем его самое максимальное значение с допуском");
                }
                dataParametrsInfo.Add(RawData[2]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[3]);
            }
            if (RawData[0] >= ConstData[0] && RawData[0] <= ConstData[2])
            {
                thisResultStatus[1] = true;
                explanationsTextResultInfo.Add("Минимальное значение параметра находится в допустимых границах");
                dataParametrsInfo.Add(RawData[0]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[2]);
            }
            else
            {
                if (RawData[0] < ConstData[0])
                {
                    thisResultStatus[1] = false;
                    explanationsTextResultInfo.Add("Минимальное значение параметра ниже, чем его самое миниальное значение с допуском");
                }
                else
                {
                    thisResultStatus[1] = false;
                    explanationsTextResultInfo.Add("Минимальное значение параметра выше, чем его самое миниальное значение с допуском");
                }
                dataParametrsInfo.Add(RawData[0]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[2]);
            }
            if (RawData[1] <= ConstData[3])
            {
                thisResultStatus[2] = true;
                explanationsTextResultInfo.Add("Максимальное значение параметра не превышает значения с допуском");
                dataParametrsInfo.Add(RawData[1]); dataParametrsInfo.Add(ConstData[3]);
            }
            else
            {
                if (RawData[1] > ConstData[3])
                {
                    thisResultStatus[2] = false;
                    explanationsTextResultInfo.Add("Максимальное значение параметра выше, чем его самое высокое значение с допуском");
                    dataParametrsInfo.Add(RawData[1]); dataParametrsInfo.Add(ConstData[3]);
                }
            }
            return Tuple.Create<bool[], List<string>, List<double>>(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Тестирование передатчика
        /// </summary>
        private Tuple<bool[], List<string>, List<double>> TestTransSignalTime(List<double> RawData, List<double> ConstData)
        {
            clearDataRepository();
            if (RawData[2] >= ConstData[0] && RawData[2] <= ConstData[3])
            {
                thisResultStatus[0] = true;
                explanationsTextResultInfo.Add("Среднее значение параметра находится в допустимых границах");
                dataParametrsInfo.Add(RawData[2]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[3]);
            }
            else
            {
                if (RawData[2] < ConstData[0])
                {
                    thisResultStatus[0] = false;
                    explanationsTextResultInfo.Add("Среднее значение параметра ниже, чем его самое максимальное значение с допуском");
                }
                else
                {
                    thisResultStatus[0] = false;
                    explanationsTextResultInfo.Add("Среднее значение параметра выше, чем его самое максимальное значение с допуском");
                }
                dataParametrsInfo.Add(RawData[2]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[3]);
            }
            if (RawData[0] >= ConstData[0])
            {
                thisResultStatus[1] = true;
                explanationsTextResultInfo.Add("Минимальное значение параметра находится в допустимых границах");
                dataParametrsInfo.Add(RawData[0]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[2]);
            }
            else
            {
                if (RawData[0] < ConstData[0])
                {
                    thisResultStatus[1] = false;
                    explanationsTextResultInfo.Add("Минимальное значение параметра ниже, чем его самое миниальное значение с допуском");
                }
                dataParametrsInfo.Add(RawData[0]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[2]);
            }
            if (RawData[1] <= ConstData[3])
            {
                thisResultStatus[2] = true;
                explanationsTextResultInfo.Add("Максимальное значение параметра не превышает значения с допуском");
                dataParametrsInfo.Add(RawData[1]); dataParametrsInfo.Add(ConstData[3]);
            }
            else
            {
                if (RawData[1] > ConstData[3])
                {
                    thisResultStatus[2] = false;
                    explanationsTextResultInfo.Add("Максимальное значение параметра выше, чем его самое высокое значение с допуском");
                    dataParametrsInfo.Add(RawData[1]); dataParametrsInfo.Add(ConstData[3]);
                }
            }
            return Tuple.Create<bool[], List<string>, List<double>>(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Тестирование требований по питанию +5В
        /// </summary>
        private Tuple<bool[], List<string>, List<double>> TestPowerReqPlusFiveVolt(List<double> RawData, List<double> ConstData)
        {
            clearDataRepository();
            if (RawData[0] > 0)
            {
                thisResultStatus[0] = true;
                explanationsTextResultInfo.Add("Минимальное значение параметра находится в допустимых границах");
            }
            else
            {
                thisResultStatus[0] = false;
                explanationsTextResultInfo.Add("Минимальное значение параметра меньше 0!");
            }
            if (RawData[2] <= ConstData[1])
            {
                thisResultStatus[1] = true;
                explanationsTextResultInfo.Add("Среднее значение параметра находится в допустимых границах");
            }
            else
            {
                thisResultStatus[1] = false;
                explanationsTextResultInfo.Add("Среднее значение параметра превышает верхний предел параметра с допуском");
            }
            if (RawData[1] <= ConstData[1])
            {
                thisResultStatus[2] = true;
                explanationsTextResultInfo.Add("Максимальное значение параметра находится в пределах значения параметра с допуском");
            }
            else
            {
                thisResultStatus[2] = false;
                explanationsTextResultInfo.Add("Максимальное значение параметра превышает верхний предел параметра с допуском");
            }
            dataParametrsInfo.Add(RawData[2]); dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[3]);
            return Tuple.Create<bool[], List<string>, List<double>>(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Тестирование требований по питанию -12В
        /// </summary>
        private Tuple<bool[], List<string>, List<double>> TestPowerReqMinusTwelveVolt(List<double> RawData, List<double> ConstData)
        {
            return Tuple.Create<bool[], List<string>, List<double>>(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Тестирование требований по питанию +12В Пауза
        /// </summary>
        private Tuple<bool[], List<string>, List<double>> TestPowerReqPlusTwelvePauseVolt(List<double> RawData, List<double> ConstData)
        {
            return Tuple.Create<bool[], List<string>, List<double>>(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Тестирование требований по питанию +12В 25%
        /// </summary>
        private Tuple<bool[], List<string>, List<double>> TestPowerReqPlusTwelve25Volt(List<double> RawData, List<double> ConstData)
        {
            return Tuple.Create<bool[], List<string>, List<double>>(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Тестирование требований по питанию +12В 50%
        /// </summary>
        private Tuple<bool[], List<string>, List<double>> TestPowerReqPlusTwelve50Volt(List<double> RawData, List<double> ConstData)
        {
            return Tuple.Create<bool[], List<string>, List<double>>(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Тестирование требований по питанию +12В 100%
        /// </summary>
        private Tuple<bool[], List<string>, List<double>> TestPowerReqPlusTwelve100Volt(List<double> RawData, List<double> ConstData)
        {
            return Tuple.Create<bool[], List<string>, List<double>>(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Тестирование требований температуры
        /// </summary>
        private Tuple<bool[], List<string>, List<double>> TestTemperature(List<double> RawData, List<double> ConstData)
        {
            return Tuple.Create<bool[], List<string>, List<double>>(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Подготовка и инициализация хранилища для сохранения результатов тестирования
        /// </summary>
        private void PrepareDataResult()
        {
            TestResultDataStruct = new TestDataStructure.TestDataStruct[CountDevices];
            for (int i = 0; i < CountDevices; i++)
            {
                TestResultDataStruct[i].ReceiverDifferentialInputVoltage =
                    new Tuple<bool[], List<string>, List<double>>(new bool[3], new List<string>(), new List<double>());
                TestResultDataStruct[i].TransmitterDifferentialOutputVoltage =
                    new Tuple<bool[], List<string>, List<double>>(new bool[3], new List<string>(), new List<double>());
                TestResultDataStruct[i].TransmitterRiseRecessionSignalTime =
                    new Tuple<bool[], List<string>, List<double>>(new bool[3], new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqPlusFiveVoltage =
                    new Tuple<bool[], List<string>, List<double>>(new bool[3], new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqMinusTwelveVoltage =
                    new Tuple<bool[], List<string>, List<double>>(new bool[3], new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqPlusTwelvePauseVoltage =
                    new Tuple<bool[], List<string>, List<double>>(new bool[3], new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqPlusTwelve25Voltage =
                    new Tuple<bool[], List<string>, List<double>>(new bool[3], new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqPlusTwelve50Voltage =
                    new Tuple<bool[], List<string>, List<double>>(new bool[3], new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqPlusTwelve100Voltage =
                    new Tuple<bool[], List<string>, List<double>>(new bool[3], new List<string>(), new List<double>());
                TestResultDataStruct[i].Temperature = 
                    new Tuple<bool[], List<string>, List<double>>(new bool[3], new List<string>(), new List<double>());
                TestResultDataStruct[i].DeviceStatusDescription = new List<string>();
                TestResultDataStruct[i].DeviceDataDescriptionTest = new List<string>();
            }
        }

        /// <summary>
        /// Очищает хранилища данных перед каждым параметром
        /// </summary>
        private void clearDataRepository()
        {
            explanationsTextResultInfo.Clear();
            dataParametrsInfo.Clear();
        }
    }
}
