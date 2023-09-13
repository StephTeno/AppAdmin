using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Modelo
{
    public class env
    {
        public string PORT = ConfigurationManager.AppSettings["port"].ToString();
        public string PASSWORD = ConfigurationManager.AppSettings["password"].ToString();
        public string USERNAME_DB = ConfigurationManager.AppSettings["username"].ToString();

    }
}
