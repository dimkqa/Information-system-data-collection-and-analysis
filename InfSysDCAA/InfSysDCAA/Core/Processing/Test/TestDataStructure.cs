using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Processing.Test
{
    /// <summary>
    /// В состав класса входит структура, которая содержит информацию о тесте для текущего устройства.
    /// </summary>
    public class TestDataStructure
    {
        /// <summary>
        /// Структура данных теста
        /// </summary>
        public struct TestDataStruct
        {
            /// <summary>
            /// String. Имя устройства. Данные из БД
            /// </summary>
            public string DeviceName;

            /// <summary>
            /// String. Инвентарный номер устройства.
            /// </summary>
            public string DeviceInventNumber;

            /// <summary>
            /// String. Статус теста устройства в общем.
            /// </summary>
            public string DeviceStatus;

            /// <summary>
            /// String. Производитель устройства. Данные из БД
            /// </summary>
            public string DeviceManufacturer;

            /// <summary>
            /// String. Описание устройства. Данные из БД
            /// </summary>
            public string DeviceDescription;

            /// <summary>
            /// List string. Пояснения к статусу устройства.
            /// </summary>
            public List<string> DeviceStatusDescription;

            /// <summary>
            /// Общие пояснения к тесту
            /// </summary>
            public List<string> DeviceDataDescriptionTest;

            /// <summary>
            /// Данные приёмника: Дифференциальное входное напряжение.
            /// </summary>
            public Tuple<bool[], List<string>, List<double>> ReceiverDifferentialInputVoltage;

            /// <summary>
            /// Данные передатчика: Дифференциальное выходное напряжение.
            /// </summary>
            public Tuple<bool[], List<string>, List<double>> TransmitterDifferentialOutputVoltage;

            /// <summary>
            /// Данные передатчика: Время нарастания и спада сигнала.
            /// </summary>
            public Tuple<bool[], List<string>, List<double>> TransmitterRiseRecessionSignalTime;
            
            /// <summary>
            /// Требования по питанию: +5В. List string.
            /// </summary>
            public Tuple<bool[], List<string>, List<double>> PowerReqPlusFiveVoltage;
            
            /// <summary>
            /// Требования по питанию: -12В. List string.
            /// </summary>
            public Tuple<bool[], List<string>, List<double>> PowerReqMinusTwelveVoltage;
            
            /// <summary>
            /// Требования по питанию: +12В Пауза. List string.
            /// </summary>
            public Tuple<bool[], List<string>, List<double>> PowerReqPlusTwelvePauseVoltage;

            /// <summary>
            /// Требования по питанию: +12В 25% времени передачи. List string.
            /// </summary>
            public Tuple<bool[], List<string>, List<double>> PowerReqPlusTwelve25Voltage;

            /// <summary>
            /// Требования по питанию: +12В 50% времени передачи. List string.
            /// </summary>
            public Tuple<bool[], List<string>, List<double>> PowerReqPlusTwelve50Voltage;

            /// <summary>
            /// Требования по питанию: +12В 100% времени передачи.List string.
            /// </summary>
            public Tuple<bool[], List<string>, List<double>> PowerReqPlusTwelve100Voltage;

            /// <summary>
            /// Параметры температуры. List string.
            /// </summary>
            public Tuple<bool[], List<string>, List<double>> Temperature;
        }
    }
}
