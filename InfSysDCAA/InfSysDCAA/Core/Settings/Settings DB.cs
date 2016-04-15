using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Settings
{
    public class Settings_DB : ASettings
    {
        public Settings_DB()
        {
            fieldsList = new List<string>()
            {
                "field_db_host",
                "field_db_name",
                "field_db_user",
                "field_db_password"
            };
        }

        public override Dictionary<string, string> ReadDataSettings()
        {
            Dictionary<string, string> connectDictionary = new Dictionary<string, string>()
            {
                {fieldsList[0], Properties.Application_data.user.Default.field_db_host},
                {fieldsList[1], Properties.Application_data.user.Default.field_db_name},
                {fieldsList[2], Properties.Application_data.user.Default.field_db_user},
                {fieldsList[3], Properties.Application_data.user.Default.field_db_password}
            };
            return connectDictionary;
        }
    }
}