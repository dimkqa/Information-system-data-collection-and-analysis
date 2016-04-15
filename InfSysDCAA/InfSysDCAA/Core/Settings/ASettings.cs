using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfSysDCAA.Core.Settings
{
    public abstract class ASettings
    {
        /// <summary>
        /// Лист field'ов
        /// </summary>
        protected List<string> fieldsList = new List<string>();
        
        /// <summary>
        /// Производит запись данных в файл user.settings
        /// </summary>
        /// <param name="Name">Имя параметра</param>
        /// <param name="Value">Значение параметра</param>
        public void WriteDataSettings(string Name, string Value)
        {
            Properties.Application_data.user.Default[Name] = Value;
            Properties.Application_data.user.Default.Save();
        }

        /// <summary>
        /// Производит чтение из файла Properties с настройками
        /// </summary>
        /// <returns></returns>
        abstract public Dictionary<string, string> ReadDataSettings();
    }
}
