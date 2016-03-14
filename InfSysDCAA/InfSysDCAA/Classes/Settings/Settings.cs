using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using InfSysDCAA.Classes.Files;
using InfSysDCAA;
using InfSysDCAA.Files.Params;

namespace InfSysDCAA.Classes.Settings
{
    public class SaveSettingsDataBase
    {
        //Имя, хост, пользователь, пароль.
        public string databaseName {
            get { return _databaseName; }
            set
            {
            //    Regex r = new Regex(@"[a-zA-Z0-9]");
            //    Match m = r.Match(_databaseName);
            //    while (!m.Success)
            //    {
            //        
            //    }
                    _databaseName = value;
            }
        }
        public string databaseHost {
            get { return _databaseHost; }
            set { _databaseHost = value; }
        }
        public string databaseUser {
            get { return _databaseUser; }
            set { _databaseUser = value; }
        }

        public string databasePassword
        {
            get { return _databasePassword; }
            set { _databasePassword = value; } 
        }

        private string _databaseName;
        private string _databaseHost;
        private string _databaseUser;
        private string _databasePassword;
        /// <summary>
        /// Конструктор принимает List с настройками
        /// </summary>
        /// <param name="ParamDB">List<string> содержит параметры соеднения с БД</param>
        public SaveSettingsDataBase(List<String> ParamDB)
        {
            operationsWithXML owxml = new operationsWithXML(PathFinder.AllPath[0], "settings-database.xml");
            owxml.CreateFile();
        }

    }
}
