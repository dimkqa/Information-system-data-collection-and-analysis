namespace InfSysDCAA.Core.Processing.Devices
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
        /// <summary>
        /// Длина в байтах на одно устройство
        /// </summary>
        ///ЭТО МАГИЯ!!
        public const int LengthDeviceInBytes = 8015;
        /// <summary>
        /// Длина в байтах на все устройства в файле
        /// </summary>
        public static int LengthAllDevicesBytes;
    }
}
