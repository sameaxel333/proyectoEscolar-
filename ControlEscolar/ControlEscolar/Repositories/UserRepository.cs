using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using ControlEscolar.Model;

namespace ControlEscolar.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(string username, byte[] passwordHash)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"SELECT COUNT(*) FROM Estudiantes 
                                WHERE CURP = @CURP AND Contraseña = @password";

                command.Parameters.Add("@CURP", System.Data.SqlDbType.NVarChar).Value = username;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarBinary).Value = passwordHash;

                return (int)command.ExecuteScalar() > 0;
            }
        }



        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
