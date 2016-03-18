using System.Collections.Generic;

namespace InfSysDCAA.Forms.Auth
{
    class Authorization
    {
        private Main _formMain;

        private string _login;
        private string _password;
        private string _trueLogin = "dimkqa";
        private string _truePassword = "dimkqa";

        public Authorization(string login, string password)
        {
            this._login = login;
            this._password = password;
        }

        public bool ScanLogin()
        {
            
            return true;
        }

        public bool ScanPassword(string password)
        {
            return true;
        }

        private bool TestLogin(string login)
        {
            List<string> pattern = new List<string>();
            pattern.Add(@"\^[a-z]+$");
            
            return true;
        }

        private bool TestPassword(string password)
        {
            return true;
        }

        public bool Signin()
        {
            if (_login == _trueLogin && _password == _truePassword)
                return true;
            return false;
        }

        public bool Logout()
        {
            return true;
        }
    }
    
}
