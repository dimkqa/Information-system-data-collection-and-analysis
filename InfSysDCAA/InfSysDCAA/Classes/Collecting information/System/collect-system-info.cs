using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace InfSysDCAA.Classes.Collecting_information.System_information
{
    public static class collect_system_info
    {
        private static Dictionary<string, string> ForSystemComputerInformation = new Dictionary<string, string>();
        public static Dictionary<string, string> ForAboutComputerInformation = new Dictionary<string, string>();
        
        private static string[] KeySystemInfoHashtable = new string[]
        {
            "pc_name", "user_name", "os_name", "os_version", "os_bit_width",
            "ram_width", "processor_name", "count_log_proc",
            "count_phys_proc", "name_card", "graph_proc"
        };

        private static string[] KeySystemInfoText = new string[]
        {
            "Имя ПК: ", "Имя пользователя:", "Название ОС: ", "Версия ОС: ", "Разрядность ОС: ",
            "Размер ОЗУ: ", "Имя процессора: ", "Число логических процессоров: ",
            "Число физических процессоров: ", "Название видеоплаты: ", "Граф. процессор: "
        };

        public static void getSystemInformation()
        {
            ManagementObjectSearcher operatingSystem = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher processor  = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            ManagementObjectSearcher videoController = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            getInfoOS(operatingSystem);
            getInfoProcessor(processor);
            getInfoVideo(videoController);
        }

        private static void getInfoOS(ManagementObjectSearcher operatingSystem)
        {
            foreach (ManagementObject queryObj in operatingSystem.Get())
            {
                //Имя машины
                ForSystemComputerInformation.Add(KeySystemInfoHashtable[0], Environment.MachineName.ToString());
                ForAboutComputerInformation.Add(KeySystemInfoText[0], Environment.MachineName.ToString());
                //Имя пользователя
                ForSystemComputerInformation.Add(KeySystemInfoHashtable[1], queryObj["RegisteredUser"].ToString());
                ForAboutComputerInformation.Add(KeySystemInfoText[1], queryObj["RegisteredUser"].ToString());
                //Название ОС         
                ForSystemComputerInformation.Add(KeySystemInfoHashtable[2], queryObj["Caption"].ToString());
                ForAboutComputerInformation.Add(KeySystemInfoText[2], queryObj["Caption"].ToString());
                //Версия ОС                Environment.OSVersion.ToString();
                ForSystemComputerInformation.Add(KeySystemInfoHashtable[3], Environment.OSVersion.ToString().ToString());
                ForAboutComputerInformation.Add(KeySystemInfoText[3], Environment.OSVersion.ToString());
                //Разрядность ОС
                ForSystemComputerInformation.Add(KeySystemInfoHashtable[4], queryObj["OSArchitecture"].ToString());
                ForAboutComputerInformation.Add(KeySystemInfoText[4], queryObj["OSArchitecture"].ToString());
                //Размер ОЗУ 
                ulong RAM = Convert.ToUInt64(queryObj["TotalVisibleMemorySize"]) / 1000000;
                ForSystemComputerInformation.Add(KeySystemInfoHashtable[5], queryObj["TotalVisibleMemorySize"].ToString());
                ForAboutComputerInformation.Add(KeySystemInfoText[5],
                    Convert.ToString( RAM + " Гб"));
            }

        }

        private static void getInfoProcessor(ManagementObjectSearcher processor)
        {
            foreach (ManagementObject queryObj in processor.Get())
            {
                //Имя процессора
                ForSystemComputerInformation.Add(KeySystemInfoHashtable[6], queryObj["Name"].ToString());
                ForAboutComputerInformation.Add(KeySystemInfoText[6], queryObj["Name"].ToString());
                //Число логических процессоров
                ForSystemComputerInformation.Add(KeySystemInfoHashtable[7], queryObj["NumberOfLogicalProcessors"].ToString());
                ForAboutComputerInformation.Add(KeySystemInfoText[7], queryObj["NumberOfLogicalProcessors"].ToString());
                //Число физических процессоров
                ForSystemComputerInformation.Add(KeySystemInfoHashtable[8], queryObj["NumberOfCores"].ToString());
                ForAboutComputerInformation.Add(KeySystemInfoText[8], queryObj["NumberOfCores"].ToString());
            }
        }

        private static void getInfoVideo(ManagementObjectSearcher videoController)
        {
            foreach (ManagementObject queryObj in videoController.Get())
            {
                switch (queryObj["DeviceID"].ToString())
                {
                    case "VideoContoller1":
                    {
                        //Имя
                        ForSystemComputerInformation.Add(KeySystemInfoHashtable[9], queryObj["Name"].ToString());
                        ForAboutComputerInformation.Add(KeySystemInfoText[9], queryObj["Name"].ToString());
                        //Процессор
                        ForSystemComputerInformation.Add(KeySystemInfoHashtable[10], queryObj["VideoProcessor"].ToString());
                        ForAboutComputerInformation.Add(KeySystemInfoText[10], queryObj["VideoProcessor"].ToString());
                        break;
                    }

                    case "VideoController2":
                    {
                        //Имя
                        ForSystemComputerInformation.Add(KeySystemInfoHashtable[9], queryObj["Name"].ToString());
                        ForAboutComputerInformation.Add(KeySystemInfoText[9], queryObj["Name"].ToString());
                        //Процессор
                        ForSystemComputerInformation.Add(KeySystemInfoHashtable[10], queryObj["VideoProcessor"].ToString());
                        ForAboutComputerInformation.Add(KeySystemInfoText[10], queryObj["VideoProcessor"].ToString());
                        break;
                    }
                }
            }
        }

        public static void SQLDataInsert()
        {

        }
    }
}
