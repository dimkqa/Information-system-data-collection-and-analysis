﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfSysDCAA.Properties.Application_data {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class systemInformation : global::System.Configuration.ApplicationSettingsBase {
        
        private static systemInformation defaultInstance = ((systemInformation)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new systemInformation())));
        
        public static systemInformation Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string MD5Checksum {
            get {
                return ((string)(this["MD5Checksum"]));
            }
            set {
                this["MD5Checksum"] = value;
            }
        }
    }
}
