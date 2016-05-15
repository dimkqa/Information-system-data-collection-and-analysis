using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Processing
{
    /// <summary>
    /// Класс содержит структуру, которая описывает данные одного устройства
    /// учавствующее в конкретном опыте.
    /// Все технические параметры платы могут иметь три значения:
    /// Максимум, минимум, среднее. 
    /// При сравнении для отчета используется среднее число.
    /// LengthDeviceInBytes - число бай на одно устройство
    /// </summary>
    public class DevicesStruct
    {
        public const int LengthDeviceInBytes = 6422;

        public static int LengthAllDevicesBytes;
        public struct Device
        {
            public string InventoryNumber;
            //Receiver
            public List<double> ReceiverDifferentialInputVoltage;
            //Transmitter
            public List<double> TransmitterDifferentialOutputVoltage;
            public List<double> TransmitterRiseRecessionSignalTime;
            //Power
            public List<double> PowerReqPlusFiveVoltage;
            public List<double> PowerReqMinusTwelveVoltage;
            public List<double> PowerReqPlusTwelvePauseVoltage;
            public List<double> PowerReqPlusTwelve25Voltage;
            public List<double> PowerReqPlusTwelve50Voltage;
            public List<double> PowerReqPlusTwelve100Voltage;
            //Temperature
            public List<double> Temperature;
        }
    }
}
