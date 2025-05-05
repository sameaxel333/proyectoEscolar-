using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.Model
{
    public interface IUserRepository
    {
        bool AuthenticateUser(string username, byte[] passwordHash, string userRole);
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Remove(int id);
        UserModel GetById(int id);
        UserModel GetByUsername(string username);
    }
}
