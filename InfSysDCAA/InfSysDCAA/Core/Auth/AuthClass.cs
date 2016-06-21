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
        /// Авторизация пользователей 
        /// </summary>
        /// <returns></returns>
        public bool LogIn()
        {
            getEmergencyAuthData();


            return true;
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
