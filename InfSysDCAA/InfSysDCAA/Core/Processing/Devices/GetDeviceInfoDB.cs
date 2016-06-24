using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfSysDCAA.Core.Config;
using InfSysDCAA.Core.DataBase;

namespace InfSysDCAA.Core.Processing.Devices
{
    public static class GetDeviceInfoDB
    {
        static GetDeviceInfoDB()
        {

        }

        /// <summary>
        /// Получает имя конкретного устройства по инвентарному номеру
        /// </summary>
        /// <param name="InventoryId">String, инвентарный номер устройства</param>
        /// <returns></returns>
        public static string GetDeviceName(string InventoryId )
        {
            DataBaseConnect DBC = new DataBaseConnect(GetConnectionString.getStringConnectionData());
            return DBC.getGetDeviceData("name", InventoryId);
        }

        /// <summary>
        /// Получает описание устройства по инвентарному номеру
        /// </summary>
        /// <param name="InventoryId">String, инвентарный номер устройства</param>
        /// <returns></returns>
        public static string GetDeviceDescription(string InventoryId)
        {
            DataBaseConnect DBC = new DataBaseConnect(GetConnectionString.getStringConnectionData());
            return DBC.getGetDeviceData("description", InventoryId);
        }

        /// <summary>
        /// Получает имя производителя устройства по инвентарному номеру
        /// </summary>
        /// <param name="invent"></param>
        /// <returns></returns>
        public static string GetDeviceManufacturer(string InventoryId)
        {
            DataBaseConnect DBC = new DataBaseConnect(GetConnectionString.getStringConnectionData());
            return DBC.getGetDeviceData("manufacturer", InventoryId);
        }
    }
}
