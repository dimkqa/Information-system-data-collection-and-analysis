using System.Windows.Forms;
using InfSysDCAA.Core.Config;
using InfSysDCAA.Core.DataBase;

namespace InfSysDCAA.Core.Auth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Авторизация
    /// </summary>
    public class AuthClass
    {
        /// <summary>
        /// Хранит данные аварийного входа
        /// </summary>
        private List<string> EmergencyDataLogin;

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        ///  Аварийный Логин
        /// </summary>
        public string EmergencyLogin { get; set; }

        /// <summary>
        /// Аварийный Пароль
        /// </summary>
        public string EmergencyLoginPassword { get; set; }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="login">String, Логин</param>
        /// <param name="password">String, Пароль</param>
        public AuthClass(string login, string password)
        {
            Login = login;
            Password = password;
        }

        /// <summary>
        /// Авторизация
        /// </summary>
        /// <returns>Возвращает кортеж - первый элемент булево значение, второй - список элементов</returns>
        public Tuple<bool, List<string>> LogIn()
        {
            List<string> userData = new List<string>();
            string HLogin, HPassword;
            try
            {
                HLogin = EncryptionData.EncryptLogin(Login, Password);
                HPassword = EncryptionData.EncryptPassword(Login, Password);
                DataBaseConnect DBC = new DataBaseConnect(GetConnectionString.getStringConnectionData());
                userData = new List<string>(DBC.getUserInfoFromDataBase(HLogin, HPassword));
                getEmergencyAuthData();
                if (userData != null)
                {
                    return Tuple.Create(true, userData);
                }
                else
                    return Tuple.Create(false, userData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return Tuple.Create(false, userData);
            }
        }


        /// <summary>
        /// Выход пользователя
        /// </summary>
        public void LogOut()
        {

        }

        /// <summary>
        /// Возвращает данные аварийного входа в систему.
        /// </summary>
        /// <returns></returns>
        private void getEmergencyAuthData()
        {
            EmergencyLogin = Properties.Settings.Default.emergency_login.ToString();
            EmergencyLoginPassword = Properties.Settings.Default.emergency_password.ToString();
        }
    }
}
