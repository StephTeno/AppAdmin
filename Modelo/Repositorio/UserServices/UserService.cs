using BCrypt.Net;
using Modelo.Datos;
using Modelo.Repositorio.MonDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorio.UserServices
{
    public class UserService
    {
        public List<AdminUser> GetAllAdminUsers()
        {
            throw new NotImplementedException();
        }

        public async AdminUser Login(AdminUser User, string database)
        {
            bool isValidPassword = BCrypt.Net.BCrypt.EnhancedVerify(User.Password, password);
            if (isValidPassword)
                return User;
            else
            {
                return null;
            }
        }

        public AdminUser Signup(AdminUser User)
        {
            User.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(User.Password, 13);
            return User;
        }
    }
}
