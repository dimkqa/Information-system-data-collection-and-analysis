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
        /// Содержит данные текущих измерений
        /// </summary>
        private TemporaryDevicesStructure.TmpDevice[] RawDeviceStructure;
        /// <summary>
        /// Содержит константные параметры для каждого устройства
        /// </summary>
        private ConstantDeviceStruct.TmpDevice[] ConstDeviceStructure;

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
                RawDeviceStructure = deviceRaw;
                ConstDeviceStructure = deviceConst;
                PrepareTupleResult();
            }
        }

        /// <summary>
        /// Иницирует старт тестирования
        /// </summary>
        public void StartTest()
        {

        }

        public void GetResultTest()
        {

        }

        private void PrepareTupleResult()
        {
            
        }

    }
}
