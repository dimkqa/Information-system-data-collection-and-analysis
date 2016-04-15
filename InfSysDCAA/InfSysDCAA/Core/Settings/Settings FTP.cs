using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.Settings
{
    public class Settings_FTP : ASettings
    {

        public Settings_FTP()
        {
            fieldsList = new List<string>()
            {
                "field_ftp_host",
                "field_ftp_login",
                "field_ftp_password"
            };
        }

        public override Dictionary<string, string> ReadDataSettings()
        {
            Dictionary<string, string> connectDictionary = new Dictionary<string, string>()
            {
                {fieldsList[0], Properties.Application_data.user.Default.field_ftp_host},
                {fieldsList[1], Properties.Application_data.user.Default.field_ftp_login},
                {fieldsList[2], Properties.Application_data.user.Default.field_ftp_password}
            };
            return connectDictionary;
        }
    }
}
