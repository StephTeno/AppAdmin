using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Datos
{
    public class AdminUser
    {
        private string _Username;
        public string UserName
        {
            get => _Username;
            set => _Username = value;
        }
        private string _Password;

        public string Password
        {
            get => _Password;
            set => _Password = value;
        }

        public AdminUser(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public AdminUser()
        {
        }
    }
}
