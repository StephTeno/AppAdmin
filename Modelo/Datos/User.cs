using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Datos
{
    [Serializable]
    public class User
    {
        private string _Username;
        public string UserName { 
            get=> _Username;
            set => _Username = value;
        }
        private string _Email;
        public string Email
        {
            get => _Email;
            set => _Email = value;
        }
        private string _Password;
        public string Password
        {
            get => _Password;
            set => _Password = value;
        }

        public User(string username, string email, string password)
        {
            _Username = username;
            _Email = email;
            _Password = password;
        }

    }
}
