using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Processing.Devices
{
    public class TemporaryDevicesStructure
    {
        /// <summary>
        /// Описывает структуру устройства
        /// </summary>
        public struct TmpDevice
        {
            /// <summary>
            /// Инвентарный номер устройства. String.
            /// </summary>
            public string InventoryNumber;
            /// <summary>
            /// Приёмник: Дифференциальное входное напряжение. List double. Должен хранить 100 значений.
            /// </summary>
            public List<double> ReceiverDifferentialInputVoltage;
            /// <summary>
            /// Передатчик: Дифференциальное выходное напряжение. List double. Должен хранить 100 значений.
            /// </summary>
            public List<double> TransmitterDifferentialOutputVoltage;
            /// <summary>
            /// Передатчик: Время нарастания и спада сигнала. List double. Должен хранить 100 значений.
            /// </summary>
            public List<double> TransmitterRiseRecessionSignalTime;
            /// <summary>
            /// Требования по питанию: +5В. List double. Должен хранить 100 значений.
            /// </summary>
            public List<double> PowerReqPlusFiveVoltage;
            /// <summary>
            /// Требования по питанию: -12В. List double. Должен хранить 100 значений.
            /// </summary>
            public List<double> PowerReqMinusTwelveVoltage;
            /// <summary>
            /// Требования по питанию: +12В Пауза. List double. Должен хранить 100 значений.
            /// </summary>
            public List<double> PowerReqPlusTwelvePauseVoltage;
            /// <summary>
            /// Требования по питанию: +12В 25% времени передачи. List double. Должен хранить 100 значений.
            /// </summary>
            public List<double> PowerReqPlusTwelve25Voltage;
            /// <summary>
            /// Требования по питанию: +12В 50% времени передачи. List double. Должен хранить 100 значений.
            /// </summary>
            public List<double> PowerReqPlusTwelve50Voltage;
            /// <summary>
            /// Требования по питанию: +12В 100% времени передачи. List double. Должен хранить 100 значений.
            /// </summary>
            public List<double> PowerReqPlusTwelve100Voltage;
            /// <summary>
            /// Параметры температуры. List double. Должен хранить 100 значений.
            /// </summary>
            public List<double> Temperature;
        }
    }
}
