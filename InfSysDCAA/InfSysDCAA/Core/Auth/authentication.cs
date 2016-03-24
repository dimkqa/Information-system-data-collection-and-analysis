namespace InfSysDCAA.Core.Auth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class authentication
    {
        private string _password;
        private string _login;
        public string Login {
            get { return _login; }
            set { _login = value; }
        }
        public string Password {
            get { return _password; }
            set { _password = value; }
        }
        public authentication(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public bool LogIn()
        {
            return true;
        }

        public void LogOut()
        {

        }
    }
}
