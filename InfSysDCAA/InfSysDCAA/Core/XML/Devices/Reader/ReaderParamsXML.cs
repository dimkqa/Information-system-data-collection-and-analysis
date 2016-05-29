using InfSysDCAA.Core.Directory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using InfSysDCAA.Core.Processing.Devices;

namespace InfSysDCAA.Core.XML.Devices.Reader
{
    /// <summary>
    /// Выполняет чтение данных из XML файлов
    /// </summary>
    public class ReaderParamsXML
    {
        /// <summary>
        /// Устанавливает или возвращает имя файла для поиска.
        /// </summary>
        private string FileNameParams { get; set; }

        /// <summary>
        /// Содержит число инвентарных номеров, или устройств,
        /// входящих в тест.
        /// </summary>
        private int CountInvetntNumbers { get; set; }

        /// <summary>
        /// Временный счетчик. -1 Для того, что бы правильно считать. 
        /// Счёт идет от числа всех - 1
        /// </summary>
        private int CountTmp { get; set; }

        /// <summary>
        /// Содержит полный путь до файла.
        /// </summary>
        private string FullPathToFile => DirectoryList.DefaultPathList[1] + "\\" + FileNameParams;

        /// <summary>
        /// Содержит данные для анализа
        /// </summary>
        private ConstantDeviceStruct.TmpDevice XMLDevice;

        /// <summary>
        /// Массив структур для экспорта в класс процесса
        /// </summary>
        public ConstantDeviceStruct.TmpDevice[] XmlDeviceExport;

        /// <summary>
        /// Принимает массив инвентарных номеров устройств, входящих в тест.
        /// Инвентарные номера используются для поиска файлов с данными 
        /// в системном каталоге программы
        /// </summary>
        /// <param name="inventNumber"> []String, массив нвентарных номеров</param>
        public ReaderParamsXML(string[] inventNumber)
        {
            AddedDotXML(inventNumber);
            CountInvetntNumbers = inventNumber.Count();
            PasreArrayStringInventoryNumber(inventNumber);
        }

        //Необходимо разобрать массив номеров на отдельные строки, считать данные из файлов, 
        //и сделать их публично доступными
        /// <summary>
        /// Производит разбивку массива строк на отдельные элементы и передаёт их в обработку
        /// дальнейшим методам
        /// </summary>
        /// <param name="ArrayString"></param>
        private void PasreArrayStringInventoryNumber(string[] arrayString)
        {
            string tmp = "";
            for (int i = 0; i < arrayString.Count(); i++)
            {
                FileNameParams = arrayString[i];
                tmp = arrayString[i].Replace(".xml", "");
                XMLFileReader(tmp);
            }
        }

        public void XMLFileReader(string inv)
        {
            try
            {
                if (FindFileInThePath())
                {
                    PrepareData();
                    CountTmp = CountInvetntNumbers - 1;
                    ExtractXMLData();/////////////////////////////////
                }
                else
                {
                    //TODO: Вынести в отдельный файл ошибки.
                    string errMsg = "Файл устройства с инвентарным номером "+ inv +"не найден";
                    throw new Exception(errMsg);        
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        /// <summary>
        /// Инициализирует:
        ///  - List'ы в структуре;
        ///  - Массив структур и их List'ы
        /// </summary>
        public void PrepareData()
        {
            XMLDevice = new ConstantDeviceStruct.TmpDevice();
            XMLDevice.ReceiverDifferentialInputVoltage = new List<double>();
            XMLDevice.TransmitterDifferentialOutputVoltage = new List<double>();
            XMLDevice.TransmitterRiseRecessionSignalTime = new List<double>();
            XMLDevice.PowerReqPlusFiveVoltage = new List<double>();
            XMLDevice.PowerReqMinusTwelveVoltage = new List<double>();
            XMLDevice.PowerReqPlusTwelvePauseVoltage = new List<double>();
            XMLDevice.PowerReqPlusTwelve25Voltage = new List<double>();
            XMLDevice.PowerReqPlusTwelve50Voltage = new List<double>();
            XMLDevice.PowerReqPlusTwelve100Voltage = new List<double>();
            XMLDevice.Temperature = new List<double>();
            //Создадим и проведем инициализацию массива структур
            XmlDeviceExport = new ConstantDeviceStruct.TmpDevice[CountInvetntNumbers];
            for (int i = 0; i < CountInvetntNumbers; i++)
            {
                XmlDeviceExport[i].ReceiverDifferentialInputVoltage = new List<double>();
                XmlDeviceExport[i].PowerReqMinusTwelveVoltage = new List<double>();
                XmlDeviceExport[i].PowerReqPlusFiveVoltage = new List<double>();
                XmlDeviceExport[i].PowerReqPlusTwelve100Voltage = new List<double>();
                XmlDeviceExport[i].PowerReqPlusTwelve25Voltage = new List<double>();
                XmlDeviceExport[i].PowerReqPlusTwelve50Voltage = new List<double>();
                XmlDeviceExport[i].PowerReqPlusTwelvePauseVoltage = new List<double>();
                XmlDeviceExport[i].Temperature = new List<double>();
                XmlDeviceExport[i].TransmitterDifferentialOutputVoltage = new List<double>();
                XmlDeviceExport[i].TransmitterRiseRecessionSignalTime = new List<double>();
            }
        }

        /// <summary>
        /// Извлекает данные из файла и записывает их в 
        /// List'ы. 
        /// <warning> СКЛАДЫВАЕТ В РЕЗУЛЬТАТ В ОБРАТНОМ ПОРЯДКЕ!!!!</warning>
        /// </summary>
        private void ExtractXMLData()
        {
            // Загружаем XML-файл
            XDocument XMLData = XDocument.Load(FullPathToFile);
            // Обходим XML файл начиная с корня.
            foreach (XElement element in XMLData.Root.Elements())
            {
                //В ветке ресивера:
                foreach (XElement ReceiverElement in element.Elements("DifferentialInputVoltage"))
                {
                    XElement Limit = ReceiverElement.Element("Limit");
                    XElement Minimum = ReceiverElement.Element("Minimum");
                    XElement Maximum = ReceiverElement.Element("Maximum");

                    XMLDevice.ReceiverDifferentialInputVoltage.Add(Convert.ToDouble(Minimum.Value));
                    XmlDeviceExport[CountTmp].ReceiverDifferentialInputVoltage.Add(Convert.ToDouble(Minimum.Value));
                    XMLDevice.ReceiverDifferentialInputVoltage.Add(Convert.ToDouble(Maximum.Value));
                    XmlDeviceExport[CountTmp].ReceiverDifferentialInputVoltage.Add(Convert.ToDouble(Maximum.Value));
                    XMLDevice.ReceiverDifferentialInputVoltage.Add(Convert.ToDouble(Limit.Value));
                    XmlDeviceExport[CountTmp].ReceiverDifferentialInputVoltage.Add(Convert.ToDouble(Limit.Value));
                }
                //Ветка трансмиттера
                foreach (XElement TransmitterElementDiffOutV in element.Elements("DifferentialOutputVoltage"))
                {
                    XElement Minimum = TransmitterElementDiffOutV.Element("Minimum");
                    XElement Normal = TransmitterElementDiffOutV.Element("Normal");
                    XElement Limit = TransmitterElementDiffOutV.Element("Limit");

                    XMLDevice.TransmitterDifferentialOutputVoltage.Add(Convert.ToDouble(Minimum.Value));
                    XmlDeviceExport[CountTmp].TransmitterDifferentialOutputVoltage.Add(Convert.ToDouble(Minimum.Value));
                    XMLDevice.TransmitterDifferentialOutputVoltage.Add(Convert.ToDouble(Normal.Value));
                    XmlDeviceExport[CountTmp].TransmitterDifferentialOutputVoltage.Add(Convert.ToDouble(Normal.Value));
                    XMLDevice.TransmitterDifferentialOutputVoltage.Add(Convert.ToDouble(Limit.Value));
                    XmlDeviceExport[CountTmp].TransmitterDifferentialOutputVoltage.Add(Convert.ToDouble(Limit.Value));
                }
                foreach (XElement TransmitterElementTimeUpDownS in element.Elements("TimeToUpDownSignal"))
                {
                    XElement Minimum = TransmitterElementTimeUpDownS.Element("Minimum");
                    XElement Normal = TransmitterElementTimeUpDownS.Element("Normal");
                    XElement Maximum = TransmitterElementTimeUpDownS.Element("Maximum");
                    XElement Limit = TransmitterElementTimeUpDownS.Element("Limit");

                    XMLDevice.TransmitterRiseRecessionSignalTime.Add(Convert.ToDouble(Minimum.Value));
                    XmlDeviceExport[CountTmp].TransmitterRiseRecessionSignalTime.Add(Convert.ToDouble(Minimum.Value));
                    XMLDevice.TransmitterRiseRecessionSignalTime.Add(Convert.ToDouble(Normal.Value));
                    XmlDeviceExport[CountTmp].TransmitterRiseRecessionSignalTime.Add(Convert.ToDouble(Normal.Value));
                    XMLDevice.TransmitterRiseRecessionSignalTime.Add(Convert.ToDouble(Maximum.Value));
                    XmlDeviceExport[CountTmp].TransmitterRiseRecessionSignalTime.Add(Convert.ToDouble(Maximum.Value));
                    XMLDevice.TransmitterRiseRecessionSignalTime.Add(Convert.ToDouble(Limit.Value));
                    XmlDeviceExport[CountTmp].TransmitterRiseRecessionSignalTime.Add(Convert.ToDouble(Limit.Value));
                }
                //Ветка требования по питанию
                foreach (XElement PlusFiveVolt in element.Elements("PlusFiveVolt"))
                {
                    XElement Maximum = PlusFiveVolt.Element("Maximum");
                    XElement Limit = PlusFiveVolt.Element("Limit");

                    XMLDevice.PowerReqPlusFiveVoltage.Add(Convert.ToDouble(Maximum.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusFiveVoltage.Add(Convert.ToDouble(Maximum.Value));
                    XMLDevice.PowerReqPlusFiveVoltage.Add(Convert.ToDouble(Limit.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusFiveVoltage.Add(Convert.ToDouble(Limit.Value));
                }
                foreach (XElement MinusTwelvVolt in element.Elements("MinusTwelvVolt"))
                {
                    XElement Normal = MinusTwelvVolt.Element("Normal");
                    XElement Limit = MinusTwelvVolt.Element("Limit");

                    XMLDevice.PowerReqMinusTwelveVoltage.Add(Convert.ToDouble(Normal.Value));
                    XmlDeviceExport[CountTmp].PowerReqMinusTwelveVoltage.Add(Convert.ToDouble(Normal.Value));
                    XMLDevice.PowerReqMinusTwelveVoltage.Add(Convert.ToDouble(Limit.Value));
                    XmlDeviceExport[CountTmp].PowerReqMinusTwelveVoltage.Add(Convert.ToDouble(Limit.Value));
                }
                foreach (XElement PlusTwelvVoltPause in element.Elements("PlusTwelvVoltPause"))
                {
                    XElement Minimum = PlusTwelvVoltPause.Element("Minimum");
                    XElement Normal = PlusTwelvVoltPause.Element("Normal");
                    XElement Maximum = PlusTwelvVoltPause.Element("Maximum");
                    XElement Limit = PlusTwelvVoltPause.Element("Limit");

                    XMLDevice.PowerReqPlusTwelvePauseVoltage.Add(Convert.ToDouble(Minimum.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelvePauseVoltage.Add(Convert.ToDouble(Minimum.Value));
                    XMLDevice.PowerReqPlusTwelvePauseVoltage.Add(Convert.ToDouble(Normal.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelvePauseVoltage.Add(Convert.ToDouble(Normal.Value));
                    XMLDevice.PowerReqPlusTwelvePauseVoltage.Add(Convert.ToDouble(Maximum.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelvePauseVoltage.Add(Convert.ToDouble(Maximum.Value));
                    XMLDevice.PowerReqPlusTwelvePauseVoltage.Add(Convert.ToDouble(Limit.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelvePauseVoltage.Add(Convert.ToDouble(Limit.Value));
                }
                foreach (XElement PlusTwelvVoltTwentyFive in element.Elements("PlusTwelvVoltTwentyFive"))
                {
                    XElement Minimum = PlusTwelvVoltTwentyFive.Element("Minimum");
                    XElement Normal = PlusTwelvVoltTwentyFive.Element("Normal");
                    XElement Maximum = PlusTwelvVoltTwentyFive.Element("Maximum");
                    XElement Limit = PlusTwelvVoltTwentyFive.Element("Limit");

                    XMLDevice.PowerReqPlusTwelve25Voltage.Add(Convert.ToDouble(Minimum.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve25Voltage.Add(Convert.ToDouble(Minimum.Value));
                    XMLDevice.PowerReqPlusTwelve25Voltage.Add(Convert.ToDouble(Normal.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve25Voltage.Add(Convert.ToDouble(Normal.Value));
                    XMLDevice.PowerReqPlusTwelve25Voltage.Add(Convert.ToDouble(Maximum.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve25Voltage.Add(Convert.ToDouble(Maximum.Value));
                    XMLDevice.PowerReqPlusTwelve25Voltage.Add(Convert.ToDouble(Limit.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve25Voltage.Add(Convert.ToDouble(Limit.Value));
                }
                foreach (XElement PlusTwelvVoltFifty in element.Elements("PlusTwelvVoltFifty"))
                {
                    XElement Minimum = PlusTwelvVoltFifty.Element("Minimum");
                    XElement Normal = PlusTwelvVoltFifty.Element("Normal");
                    XElement Maximum = PlusTwelvVoltFifty.Element("Maximum");
                    XElement Limit = PlusTwelvVoltFifty.Element("Limit");

                    XMLDevice.PowerReqPlusTwelve50Voltage.Add(Convert.ToDouble(Minimum.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve50Voltage.Add(Convert.ToDouble(Minimum.Value));
                    XMLDevice.PowerReqPlusTwelve50Voltage.Add(Convert.ToDouble(Normal.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve50Voltage.Add(Convert.ToDouble(Normal.Value));
                    XMLDevice.PowerReqPlusTwelve50Voltage.Add(Convert.ToDouble(Maximum.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve50Voltage.Add(Convert.ToDouble(Maximum.Value));
                    XMLDevice.PowerReqPlusTwelve50Voltage.Add(Convert.ToDouble(Limit.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve50Voltage.Add(Convert.ToDouble(Limit.Value));
                }
                foreach (XElement PlusTwelvVoltHundred in element.Elements("PlusTwelvVoltHundred"))
                {
                    XElement Minimum = PlusTwelvVoltHundred.Element("Minimum");
                    XElement Limit = PlusTwelvVoltHundred.Element("Limit");
                    XElement Maximum = PlusTwelvVoltHundred.Element("Maximum");
                    XElement Normal = PlusTwelvVoltHundred.Element("Normal");

                    XMLDevice.PowerReqPlusTwelve100Voltage.Add(Convert.ToDouble(Minimum.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve100Voltage.Add(Convert.ToDouble(Minimum.Value));
                    XMLDevice.PowerReqPlusTwelve100Voltage.Add(Convert.ToDouble(Normal.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve100Voltage.Add(Convert.ToDouble(Normal.Value));
                    XMLDevice.PowerReqPlusTwelve100Voltage.Add(Convert.ToDouble(Maximum.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve100Voltage.Add(Convert.ToDouble(Maximum.Value));
                    XMLDevice.PowerReqPlusTwelve100Voltage.Add(Convert.ToDouble(Limit.Value));
                    XmlDeviceExport[CountTmp].PowerReqPlusTwelve100Voltage.Add(Convert.ToDouble(Limit.Value));
                }
                // Ветка температуры
                foreach (XElement temperature in element.Elements("PowerTemp"))
                {
                    XElement Minimum = temperature.Element("Minimum");
                    XElement Maximum = temperature.Element("Maximum");
                    XElement Limit = temperature.Element("Limit");

                    XMLDevice.Temperature.Add(Convert.ToDouble(Minimum.Value));
                    XmlDeviceExport[CountTmp].Temperature.Add(Convert.ToDouble(Minimum.Value));
                    XMLDevice.Temperature.Add(Convert.ToDouble(Maximum.Value));
                    XmlDeviceExport[CountTmp].Temperature.Add(Convert.ToDouble(Maximum.Value));
                    XMLDevice.Temperature.Add(Convert.ToDouble(Limit.Value));
                    XmlDeviceExport[CountTmp].Temperature.Add(Convert.ToDouble(Limit.Value));
                }
            }
            //Уменьшаем число устройств
            CountTmp--;
        }

        /// <summary>
        /// Проверяет, существует ли XML-файл с параметрами в папке.
        /// </summary>
        /// <returns>Возвращает истину, если файл есть, и ложь, если файла нет</returns>
        private bool FindFileInThePath()
        {
            if (File.Exists(FullPathToFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Добавляет к каждому инвентарному номеру в массиве ".xml"
        /// и возвращает модифицированный массив
        /// </summary>
        /// <param name="str">[]string, массив инвентарных номеров с .xml в конце у каждого.</param>
        /// <returns></returns>
        private string[] AddedDotXML(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i] + ".xml";
            }
            return str;
        }
    }
}
