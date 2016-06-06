using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfSysDCAA.Core.Processing.Devices;

namespace InfSysDCAA.Core.Processing
{
    public static class imba
    {
        public static IEnumerable<ConstantDeviceStruct.TmpDevice> Reverse(ConstantDeviceStruct.TmpDevice[] array)
        {
            for (int i = array.Count() - 1; i >= 0; i--)
                yield return array[i];
        }
    }
}
