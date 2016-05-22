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
        /// Проводит тестирование параметров платы
        /// </summary>
        /// <param name="deviceRaw">Массив структур данных, расшифрованная из файла с иходными данными</param>
        /// <param name="deviceConst">Массив структур данных, взятых из файла настроек (XML)</param>
        public Testing(TemporaryDevicesStructure.TmpDevice [] deviceRaw, ConstantDeviceStruct [] deviceConst)
        {

        }
    }
}
