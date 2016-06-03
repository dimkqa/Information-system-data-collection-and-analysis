using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int id = Convert.ToInt32(InventoryId);
            string nameDevice = "";
            //TODO запрос к БД, результат запроса - имя устройства, определённое по инвентарному номеру
            return nameDevice;
        }

        /// <summary>
        /// Получает описание устройства по инвентарному номеру
        /// </summary>
        /// <param name="InventoryId">String, инвентарный номер устройства</param>
        /// <returns></returns>
        public static string GetDeviceDescription(string InventoryId)
        {
            int id = Convert.ToInt32(InventoryId);
            string descriptionDevice = "";
            //TODO запрос к БД, результат запроса - описание устройства, определённое по инвентарному номеру
            return descriptionDevice;
        }

        /// <summary>
        /// Получает имя производителя устройства по инвентарному номеру
        /// </summary>
        /// <param name="invent"></param>
        /// <returns></returns>
        public static string GetDeviceManufacturer(string InventoryId)
        {
            int id = Convert.ToInt32(InventoryId);
            string manufacturerDevice = "";
            //TODO запрос к БД, результат запроса - описание устройства, определённое по инвентарному номеру
            return manufacturerDevice;
        }
    }
}
