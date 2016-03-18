using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace InfSysDCAA.Core.Collecting_information.System
{
    [Serializable]
    public static class CollectSystemInfo
    {
        private static Dictionary<string, string> _forSystemComputerInformation = new Dictionary<string, string>();
        public static Dictionary<string, string> ForAboutComputerInformation = new Dictionary<string, string>();
        
        private static readonly string[] _keySystemInfoHashtable = new string[]
        {
            "pc_name", "user_name", "os_name", "os_version", "os_bit_width",
            "ram_width", "processor_name", "count_log_proc",
            "count_phys_proc", "name_card", "graph_proc"
        };

        private static readonly string[] _keySystemInfoText = new string[]
        {
            "Имя ПК: ", "Имя пользователя:", "Название ОС: ", "Версия ОС: ", "Разрядность ОС: ",
            "Размер ОЗУ: ", "Имя процессора: ", "Число логических процессоров: ",
            "Число физических процессоров: ", "Название видеоплаты: ", "Граф. процессор: "
        };

        private static string _oldFileCheckSum;
        private static string _newFileCheckSum;
        public static void GetSystemInformation()
        {
            ManagementObjectSearcher operatingSystem = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher processor  = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            ManagementObjectSearcher videoController = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            GetInfoOs(operatingSystem);
            GetInfoProcessor(processor);
            GetInfoVideo(videoController);
            //SqlDataInsert();
        }

        private static void GetInfoOs(ManagementObjectSearcher operatingSystem)
        {
            foreach (ManagementObject queryObj in operatingSystem.Get())
            {
                //Имя машины
                _forSystemComputerInformation.Add(_keySystemInfoHashtable[0], Environment.MachineName.ToString());
                ForAboutComputerInformation.Add(_keySystemInfoText[0], Environment.MachineName.ToString());
                //Имя пользователя
                _forSystemComputerInformation.Add(_keySystemInfoHashtable[1], queryObj["RegisteredUser"].ToString());
                ForAboutComputerInformation.Add(_keySystemInfoText[1], queryObj["RegisteredUser"].ToString());
                //Название ОС         
                _forSystemComputerInformation.Add(_keySystemInfoHashtable[2], queryObj["Caption"].ToString());
                ForAboutComputerInformation.Add(_keySystemInfoText[2], queryObj["Caption"].ToString());
                //Версия ОС                Environment.OSVersion.ToString();
                _forSystemComputerInformation.Add(_keySystemInfoHashtable[3], Environment.OSVersion.ToString().ToString());
                ForAboutComputerInformation.Add(_keySystemInfoText[3], Environment.OSVersion.ToString());
                //Разрядность ОС
                _forSystemComputerInformation.Add(_keySystemInfoHashtable[4], queryObj["OSArchitecture"].ToString());
                ForAboutComputerInformation.Add(_keySystemInfoText[4], queryObj["OSArchitecture"].ToString());
                //Размер ОЗУ 
                ulong ram = Convert.ToUInt64(queryObj["TotalVisibleMemorySize"]) / 1000000;
                _forSystemComputerInformation.Add(_keySystemInfoHashtable[5], queryObj["TotalVisibleMemorySize"].ToString());
                ForAboutComputerInformation.Add(_keySystemInfoText[5],
                    Convert.ToString( ram + " Гб"));
            }

        }

        private static void GetInfoProcessor(ManagementObjectSearcher processor)
        {
            foreach (ManagementObject queryObj in processor.Get())
            {
                //Имя процессора
                _forSystemComputerInformation.Add(_keySystemInfoHashtable[6], queryObj["Name"].ToString());
                ForAboutComputerInformation.Add(_keySystemInfoText[6], queryObj["Name"].ToString());
                //Число логических процессоров
                _forSystemComputerInformation.Add(_keySystemInfoHashtable[7], queryObj["NumberOfLogicalProcessors"].ToString());
                ForAboutComputerInformation.Add(_keySystemInfoText[7], queryObj["NumberOfLogicalProcessors"].ToString());
                //Число физических процессоров
                _forSystemComputerInformation.Add(_keySystemInfoHashtable[8], queryObj["NumberOfCores"].ToString());
                ForAboutComputerInformation.Add(_keySystemInfoText[8], queryObj["NumberOfCores"].ToString());
            }
        }

        private static void GetInfoVideo(ManagementObjectSearcher videoController)
        {
            foreach (ManagementObject queryObj in videoController.Get())
            {
                switch (queryObj["DeviceID"].ToString())
                {
                    case "VideoContoller1":
                    {
                        //Имя
                        _forSystemComputerInformation.Add(_keySystemInfoHashtable[9], queryObj["Name"].ToString());
                        ForAboutComputerInformation.Add(_keySystemInfoText[9], queryObj["Name"].ToString());
                        //Процессор
                        _forSystemComputerInformation.Add(_keySystemInfoHashtable[10], queryObj["VideoProcessor"].ToString());
                        ForAboutComputerInformation.Add(_keySystemInfoText[10], queryObj["VideoProcessor"].ToString());
                        break;
                    }

                    case "VideoController2":
                    {
                        //Имя
                        _forSystemComputerInformation.Add(_keySystemInfoHashtable[9], queryObj["Name"].ToString());
                        ForAboutComputerInformation.Add(_keySystemInfoText[9], queryObj["Name"].ToString());
                        //Процессор
                        _forSystemComputerInformation.Add(_keySystemInfoHashtable[10], queryObj["VideoProcessor"].ToString());
                        ForAboutComputerInformation.Add(_keySystemInfoText[10], queryObj["VideoProcessor"].ToString());
                        break;
                    }
                }
            }
        }

        private static byte[] GetSystemInfoMd5Checksum()
        {
            byte[] systemInfoBytes;

            var binSystemInfo = new BinaryFormatter();
            var mStream = new MemoryStream();
            binSystemInfo.Serialize(mStream, _forSystemComputerInformation);
            systemInfoBytes = mStream.ToArray();

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(systemInfoBytes);

            return result;
        }


        public static void SqlDataInsert()
        {
            //МД5 текущих даных в виде строки
            string currentMd5 = global::System.Text.Encoding.UTF8.GetString(GetSystemInfoMd5Checksum());
            //Строка МД из настроек
            string savedMd5 = Properties.Application_data.systemInformation.Default.MD5Checksum;

            if (!Equals(savedMd5, currentMd5))
            {
                Properties.Application_data.systemInformation.Default.MD5Checksum = currentMd5;
                Properties.Application_data.systemInformation.Default.Save();
                //выполняем запрос к БД
            }
            else
            {
            }
            /* Запуск системы, заносим данные в массив. Получаем МД5 массива с данными.
            * Сохраняем в конфиг файл. При следующем запуске будем сравнивать с данными из него. 
            * Если хэш отличный, то херачим туда строку новую. И постим в БД.*/
        }
    }
}
