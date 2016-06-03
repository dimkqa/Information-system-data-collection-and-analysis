using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfSysDCAA.Core.Processing.Devices;
using InfSysDCAA.Core.Processing.Test;

namespace InfSysDCAA.Core.Processing.Report
{
    /// <summary>
    /// Формирование отчёта
    /// </summary>
    public class Reporting
    {
        /// <summary>
        /// Конструктор принимает 3 структуры с данными, в первых двух содержаться числовые значения, 
        /// в последней выводы по тесту
        /// </summary>
        /// <param name="TestRawData">Структура содержит данные измерений</param>
        /// <param name="TestConstData">Структура содержит эталонные данные</param>
        /// <param name="TestResultData">Структура содержит текстовое пояснение к конкретному параметру устройства</param>
        public Reporting(TemporaryDevicesStructure.TmpDevice[] TestRawData,
            ConstantDeviceStruct.TmpDevice[] TestConstData, TestDataStructure.TestDataStruct[] TestResultData)
        {

        }
    }
}
