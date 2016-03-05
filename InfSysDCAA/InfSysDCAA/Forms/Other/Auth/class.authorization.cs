using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace InfSysDCAA.Forms.Other.Auth
{
    class Authorization
    {
        private Main _formMain;

        private string login;
        private string password;
        private string trueLogin = "dimkqa";
        private string truePassword = "dimkqa";

        public Authorization(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public bool scanLogin()
        {
            
            return true;
        }

        public bool scanPassword(string password)
        {
            return true;
        }

        private bool testLogin(string login)
        {
            List<string> pattern = new List<string>();
            pattern.Add(@"\^[a-z]+$");
            
            return true;
        }

        private bool testPassword(string password)
        {
            return true;
        }

        public bool Signin()
        {
            if (login == trueLogin && password == truePassword)
                return true;
            return false;
        }

        public bool Logout()
        {
            return true;
        }
    }
    
}
