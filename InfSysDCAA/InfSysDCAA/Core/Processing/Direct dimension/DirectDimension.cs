using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfSysDCAA.Core.Processing.Devices;

namespace InfSysDCAA.Core.Processing.Direct_dimension
{
    /// <summary>
    /// Класс отвечает за обработку результатов измерений
    /// </summary>
    public class DirectDimension
    {
        /// <summary>
        /// Содержит данные текущих измерений
        /// </summary>
        private TemporaryDevicesStructure.TmpDevice[] RawDeviceStructure;

        /// <summary>
        /// Принимает сырые данные, вызывает метод обработки
        /// </summary>
        /// <param name="devicesRawData">Структура, содержащая данные устройств</param>
        public DirectDimension(TemporaryDevicesStructure.TmpDevice[] devicesRawData)
        {
            RawDeviceStructure = devicesRawData;
            StartListDataModified();
        }

        /// <summary>
        /// Изменяет данные в List'ах структуры
        /// </summary>
        private void StartListDataModified()
        {
            for (int i = 0; i < RawDeviceStructure.Count(); i++)
            {
                RawDeviceStructure[i].TransmitterDifferentialOutputVoltage =
                    GetParametrsListData(RawDeviceStructure[i].TransmitterDifferentialOutputVoltage);
                RawDeviceStructure[i].TransmitterRiseRecessionSignalTime =
                    GetParametrsListData(RawDeviceStructure[i].TransmitterRiseRecessionSignalTime);
                RawDeviceStructure[i].ReceiverDifferentialInputVoltage =
                    GetParametrsListData(RawDeviceStructure[i].ReceiverDifferentialInputVoltage);
                RawDeviceStructure[i].PowerReqPlusFiveVoltage =
                    GetParametrsListData(RawDeviceStructure[i].PowerReqPlusFiveVoltage);
                RawDeviceStructure[i].PowerReqMinusTwelveVoltage =
                    GetParametrsListData(RawDeviceStructure[i].PowerReqMinusTwelveVoltage);
                RawDeviceStructure[i].PowerReqPlusTwelvePauseVoltage =
                    GetParametrsListData(RawDeviceStructure[i].PowerReqPlusTwelvePauseVoltage);
                RawDeviceStructure[i].PowerReqPlusTwelve25Voltage =
                    GetParametrsListData(RawDeviceStructure[i].PowerReqPlusTwelve25Voltage);
                RawDeviceStructure[i].PowerReqPlusTwelve50Voltage =
                    GetParametrsListData(RawDeviceStructure[i].PowerReqPlusTwelve50Voltage);
                RawDeviceStructure[i].PowerReqPlusTwelve100Voltage =
                    GetParametrsListData(RawDeviceStructure[i].PowerReqPlusTwelve100Voltage);
                RawDeviceStructure[i].Temperature =
                    GetParametrsListData(RawDeviceStructure[i].Temperature);
            }
        }

        /// <summary>
        /// Модифицирует List'ы из структуры - заместо 100 значений,
        /// теперь будет храниться 3 значения в List'е
        /// </summary>
        /// <param name="data">List исходный</param>
        /// <returns>Обновленный List</returns>
        private List<double> GetParametrsListData(List<double> data)
        {
            double Minimum = data.Min();
            double Maximum = data.Max();
            double Average = data.Average();
            data.Clear();
            data.Add(Minimum); data.Add(Maximum); data.Add(Average);
            return data;
        }
    }
}
