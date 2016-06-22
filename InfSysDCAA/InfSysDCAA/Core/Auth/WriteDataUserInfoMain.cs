﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Core.Collecting_information.System;
using InfSysDCAA.Core.Config;
using InfSysDCAA.Core.DataBase;
using InfSysDCAA.Core.Directory;
using InfSysDCAA.Core.Processing.Data;
using InfSysDCAA.Core.Processing.Files;
using InfSysDCAA.Core.Validation;
using InfSysDCAA.Forms.Settings;
using InfSysDCAA.Forms.About_system_PC;
using InfSysDCAA.Forms.Auth;
using InfSysDCAA.Forms.Device.Add_or_Edit;

namespace InfSysDCAA
{
    public partial class Main 
    {
        public void WriteUserData(List<string> userInfo)
        {
            label_firstname_info.Text = userInfo[0];
            label_secondname_info.Text = userInfo[1];
            label_status_info.Text = userInfo[2];
        }

        public void ClearUserData()
        {
            label_firstname_info.Text = "";
            label_secondname_info.Text = "";
            label_status_info.Text = "";
        }
    }
}
