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
        private List<bool> thisResultStatus = new List<bool>();

        /// <summary>
        /// Содержит список параметров
        /// </summary>
        private List<double> dataParametrsInfo = new List<double>();

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
                   
                TestResultDataStruct[i].PowerReqPlusFiveVoltage =
                    Test2ConstField(RawDeviceStructure[i].PowerReqPlusFiveVoltage,
                        ConstDeviceStructure[i].PowerReqPlusFiveVoltage);
                TestResultDataStruct[i].PowerReqMinusTwelveVoltage =
                    Test2ConstField(RawDeviceStructure[i].PowerReqMinusTwelveVoltage,
                        ConstDeviceStructure[i].PowerReqMinusTwelveVoltage);

                TestResultDataStruct[i].ReceiverDifferentialInputVoltage =
                    Test4ConstField(RawDeviceStructure[i].ReceiverDifferentialInputVoltage,
                        ConstDeviceStructure[i].ReceiverDifferentialInputVoltage);
                TestResultDataStruct[i].TransmitterDifferentialOutputVoltage =
                    Test4ConstField(RawDeviceStructure[i].TransmitterDifferentialOutputVoltage,
                        ConstDeviceStructure[i].TransmitterDifferentialOutputVoltage);

                TestResultDataStruct[i].TransmitterRiseRecessionSignalTime =
                    Test4ConstField(RawDeviceStructure[i].TransmitterRiseRecessionSignalTime,
                        ConstDeviceStructure[i].TransmitterRiseRecessionSignalTime);
                TestResultDataStruct[i].PowerReqPlusTwelvePauseVoltage =
                    Test4ConstField(RawDeviceStructure[i].PowerReqPlusTwelvePauseVoltage,
                        ConstDeviceStructure[i].PowerReqPlusTwelvePauseVoltage);
                TestResultDataStruct[i].PowerReqPlusTwelve25Voltage =
                    Test4ConstField(RawDeviceStructure[i].PowerReqPlusTwelve25Voltage,
                        ConstDeviceStructure[i].PowerReqPlusTwelve25Voltage);
                TestResultDataStruct[i].PowerReqPlusTwelve50Voltage =
                    Test4ConstField(RawDeviceStructure[i].PowerReqPlusTwelve50Voltage,
                        ConstDeviceStructure[i].PowerReqPlusTwelve50Voltage);
                TestResultDataStruct[i].PowerReqPlusTwelve100Voltage =
                    Test4ConstField(RawDeviceStructure[i].PowerReqPlusTwelve100Voltage,
                        ConstDeviceStructure[i].PowerReqPlusTwelve100Voltage);
                TestResultDataStruct[i].Temperature = Test4ConstField(RawDeviceStructure[i].Temperature,
                    ConstDeviceStructure[i].Temperature);
            }
        }


        private Tuple<List<bool>, List<string>, List<double>> Test2ConstField(List<double> RawData, List<double> ConstData)
        {
            NewDataLists();
            if (RawData[0] > 0)
            {
                thisResultStatus.Add(true);
                explanationsTextResultInfo.Add("Минимальное значение параметра больше 0.");
                dataParametrsInfo.Add(RawData[0]);
            }
            else
            {
                thisResultStatus.Add(false);
                explanationsTextResultInfo.Add("Минимальное значение параметра меньше 0.");
                dataParametrsInfo.Add(RawData[0]);
            }
            if (RawData[1] <= ConstData[1])
            {
                thisResultStatus.Add(true);
                explanationsTextResultInfo.Add("Максимальное значение параметра находится в допустимом пределе.");
                dataParametrsInfo.Add(RawData[1]);
                dataParametrsInfo.Add(ConstData[1]);
                thisResultStatus.Add(true);
                explanationsTextResultInfo.Add("Среднее значение параметра находится в допустимом пределе.");
                dataParametrsInfo.Add(RawData[2]);
            }
            else
            {
                thisResultStatus.Add(false);
                explanationsTextResultInfo.Add("Максимальное значение параметра превышает предельное значение параметра");
                dataParametrsInfo.Add(RawData[1]);
                dataParametrsInfo.Add(ConstData[1]);
                thisResultStatus.Add(true);
                explanationsTextResultInfo.Add("Среднее значение параметра находится в допустимом пределе.");
                dataParametrsInfo.Add(RawData[2]);
            }
            return Tuple.Create(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
        }

        /// <summary>
        /// Производит сравнение измерений с 4-мя постоянными параметрами (из XML)
        /// </summary>
        /// <param name="RawData">Лист из структуры расшифрованных параметров</param>
        /// <param name="ConstData">Лист из структуры постоянных параметров</param>
        /// <returns></returns> 
        private Tuple<List<bool>, List<string>, List<double>> Test4ConstField(List<double> RawData, List<double> ConstData)
        {
            NewDataLists();
            if (RawData[2] >= ConstData[0] && RawData[2] <= ConstData[3])
            {
                thisResultStatus.Add(true);
                explanationsTextResultInfo.Add("Среднее значение параметра находится в допустимых границах");
            }
            else
            {
                if (RawData[2] < ConstData[0])
                {
                    thisResultStatus.Add(false);
                    explanationsTextResultInfo.Add("Среднее значение параметра ниже, чем его самое максимальное значение с допуском");
                }
                else
                {
                    thisResultStatus.Add(false);
                    explanationsTextResultInfo.Add("Среднее значение параметра выше, чем его самое максимальное значение с допуском");
                }
            }
            if (RawData[0] >= ConstData[0] && RawData[0] <= ConstData[2])
            {
                thisResultStatus.Add(true);
                explanationsTextResultInfo.Add("Минимальное значение параметра находится в допустимых границах");
            }
            else
            {
                if (RawData[0] < ConstData[0])
                {
                    thisResultStatus.Add(false);
                    explanationsTextResultInfo.Add("Минимальное значение параметра ниже, чем его самое миниальное значение с допуском");
                }
                else
                {
                    thisResultStatus.Add(false);
                    explanationsTextResultInfo.Add("Минимальное значение параметра выше, чем его самое миниальное значение с допуском");
                }
            }
            if (RawData[1] <= ConstData[3])
            {
                thisResultStatus.Add(true);
                explanationsTextResultInfo.Add("Максимальное значение параметра не превышает значения с допуском");
            }
            else
            {
                if (RawData[1] > ConstData[3])
                {
                    thisResultStatus.Add(false);
                    explanationsTextResultInfo.Add("Максимальное значение параметра выше, чем его самое высокое значение с допуском");
                }
            }
            dataParametrsInfo.Add(RawData[0]); dataParametrsInfo.Add(RawData[1]); dataParametrsInfo.Add(RawData[2]);
            dataParametrsInfo.Add(ConstData[0]); dataParametrsInfo.Add(ConstData[2]); dataParametrsInfo.Add(ConstData[3]);
            return Tuple.Create(thisResultStatus, explanationsTextResultInfo, dataParametrsInfo);
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
                    new Tuple<List<bool>, List<string>, List<double>>(new List<bool>(), new List<string>(), new List<double>());
                TestResultDataStruct[i].TransmitterDifferentialOutputVoltage =
                    new Tuple<List<bool>, List<string>, List<double>>(new List<bool>(), new List<string>(), new List<double>());
                TestResultDataStruct[i].TransmitterRiseRecessionSignalTime =
                    new Tuple<List<bool>, List<string>, List<double>>(new List<bool>(), new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqPlusFiveVoltage =
                    new Tuple<List<bool>, List<string>, List<double>>(new List<bool>(), new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqMinusTwelveVoltage =
                    new Tuple<List<bool>, List<string>, List<double>>(new List<bool>(), new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqPlusTwelvePauseVoltage =
                    new Tuple<List<bool>, List<string>, List<double>>(new List<bool>(), new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqPlusTwelve25Voltage =
                    new Tuple<List<bool>, List<string>, List<double>>(new List<bool>(), new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqPlusTwelve50Voltage =
                    new Tuple<List<bool>, List<string>, List<double>>(new List<bool>(), new List<string>(), new List<double>());
                TestResultDataStruct[i].PowerReqPlusTwelve100Voltage =
                    new Tuple<List<bool>, List<string>, List<double>>(new List<bool>(), new List<string>(), new List<double>());
                TestResultDataStruct[i].Temperature =
                    new Tuple<List<bool>, List<string>, List<double>>(new List<bool>(), new List<string>(), new List<double>());
                TestResultDataStruct[i].DeviceStatusDescription = new List<string>();
                TestResultDataStruct[i].DeviceDataDescriptionTest = new List<string>();
            }
        }

        /// <summary>
        /// Очищает хранилища данных перед каждым параметром
        /// </summary>
        private void NewDataLists()
        {
            dataParametrsInfo = new List<double>();
            explanationsTextResultInfo = new List<string>();
            thisResultStatus = new List<bool>();
        }
    }
}
