using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        public bool AuthenticateUser(string username, byte[] passwordHash, string userRole)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                Console.WriteLine($"Validando usuario en la tabla:" + userRole);

                command.CommandText = $"SELECT COUNT(*) FROM [{userRole}] WHERE CURP = @CURP AND Contraseña = @password";
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


        public UserModel GetUserInfo(string curp)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
            SELECT Nombre, Curp, Edad
            FROM Estudiante 
            WHERE CURP = @CURP";

                command.Parameters.Add("@CURP", SqlDbType.NVarChar).Value = curp;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UserModel()
                        {
                            Nombre = reader["Nombre"].ToString(),
                            Username = reader["Curp"].ToString(),
                            Edad = Convert.ToInt32(reader["Edad"])  // ✅ Conversión correcta
                        };
                    }
                }
            }
            return null;
        }


        public bool InsertUser(UserModel user, string plainPassword)
        {
            // Validación previa para evitar valores vacíos o nulos en la contraseña
            if (string.IsNullOrWhiteSpace(plainPassword))
            {
                System.Windows.MessageBox.Show("La contraseña no puede estar vacía.");
                return false;
            }

            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
            INSERT INTO Estudiante
              (Matricula, CURP, Nombre, Edad, Fecha_Nacimiento, Contraseña)
            VALUES 
              (@matricula, @curp, @nombre, @edad, @fechaNac, @contraseña)
        ";

                // Asignación de parámetros correcta
                command.Parameters.Add("@matricula", SqlDbType.NVarChar).Value = user.Matricula;
                command.Parameters.Add("@curp", SqlDbType.NVarChar).Value = user.CURP;
                command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = user.Nombre;
                command.Parameters.Add("@edad", SqlDbType.Int).Value = user.Edad;
                command.Parameters.Add("@fechaNac", SqlDbType.Date).Value = user.FechaNacimiento;

                // 🔥 SOLUCIÓN: Aplica SHA256 en C# antes de enviar la contraseña a SQL Server
                byte[] hashedPassword = System.Security.Cryptography.SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(plainPassword));
                command.Parameters.Add("@contraseña", SqlDbType.VarBinary, 64).Value = hashedPassword;

                // Depuración antes de la ejecución
                System.Windows.MessageBox.Show($"Contraseña en bytes: {BitConverter.ToString(hashedPassword)}");

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool InsertTeacher(UserModel user, string plainPassword)
        {
            // Validación para evitar valores vacíos o nulos en la contraseña
            if (string.IsNullOrWhiteSpace(plainPassword))
            {
                System.Windows.MessageBox.Show("La contraseña no puede estar vacía.");
                return false;
            }

            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
            INSERT INTO Maestro
              (Numero_Empleado, CURP, Nombre, Edad, Fecha_Nacimiento, Contraseña)
            VALUES 
              (@numeroEmpleado, @curp, @nombre, @edad, @fechaNac, @contraseña)
        ";

                // Asignación de parámetros correcta
                command.Parameters.Add("@numeroEmpleado", SqlDbType.Int).Value = user.Numero_Empleado;
                command.Parameters.Add("@curp", SqlDbType.VarChar, 18).Value = user.CURP;
                command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = user.Nombre;
                command.Parameters.Add("@edad", SqlDbType.Int).Value = user.Edad;
                command.Parameters.Add("@fechaNac", SqlDbType.Date).Value = user.FechaNacimiento;
                byte[] hashedPassword = System.Security.Cryptography.SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(plainPassword));
                command.Parameters.Add("@contraseña", SqlDbType.VarBinary, 64).Value = hashedPassword;

                // Depuración antes de la ejecución
                System.Windows.MessageBox.Show($"Contraseña en bytes: {BitConverter.ToString(hashedPassword)}");

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool InsertAdmin(UserModel admin, string plainPassword)
        {
            // Validación para evitar valores vacíos en la contraseña
            if (string.IsNullOrWhiteSpace(plainPassword))
            {
                System.Windows.MessageBox.Show("La contraseña no puede estar vacía.");
                return false;
            }

            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
    INSERT INTO Administrador
      (CURP, Nombre, Edad, Fecha_Nacimiento, Contraseña)
    VALUES 
      (@curp, @nombre, @edad, @fechaNac, @contraseña)
";

                
                command.Parameters.Add("@curp", SqlDbType.VarChar, 18).Value = admin.CURP; //  Se agrega `@curp`
                command.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = admin.Nombre;
                command.Parameters.Add("@edad", SqlDbType.Int).Value = admin.Edad;
                command.Parameters.Add("@fechaNac", SqlDbType.Date).Value = admin.FechaNacimiento;
                byte[] hashedPassword = System.Security.Cryptography.SHA256.Create()
                    .ComputeHash(System.Text.Encoding.UTF8.GetBytes(plainPassword));
                command.Parameters.Add("@contraseña", SqlDbType.VarBinary, 64).Value = hashedPassword;

                // Depuración para confirmar valores antes del INSERT
                System.Windows.MessageBox.Show($"CURP antes del insert: {admin.CURP}");
                System.Windows.MessageBox.Show($"Contraseña en bytes: {BitConverter.ToString(hashedPassword)}");

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;


             
            }
        }
        public UserModel GetUserMaestroInfo(string curp)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
            SELECT Nombre, Curp, Edad
            FROM Maestro 
            WHERE CURP = @CURP";

                command.Parameters.Add("@CURP", SqlDbType.NVarChar).Value = curp;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UserModel()
                        {
                            Nombre = reader["Nombre"].ToString(),
                            Username = reader["Curp"].ToString(),
                            Edad = Convert.ToInt32(reader["Edad"])
                        };
                    }
                }
            }
            return null;
        }

        public UserModel GetUserAdminInfo(string curp)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
            SELECT Nombre, Curp, Edad
            FROM Administrador 
            WHERE CURP = @CURP";

                command.Parameters.Add("@CURP", SqlDbType.NVarChar).Value = curp;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UserModel()
                        {
                            Nombre = reader["Nombre"].ToString(),
                            Username = reader["Curp"].ToString(),
                            Edad = Convert.ToInt32(reader["Edad"])
                        };
                    }
                }
            }
            return null;
        }
        public List<Estudiante> ObtenerEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Estudiante";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    estudiantes.Add(new Estudiante
                    {
                        Matricula = reader.IsDBNull(reader.GetOrdinal("Matricula")) ? 0 : Convert.ToInt32(reader["Matricula"]),
                        CURP = reader.IsDBNull(reader.GetOrdinal("CURP")) ? string.Empty : reader["CURP"].ToString(),
                        Nombre = reader.IsDBNull(reader.GetOrdinal("Nombre")) ? string.Empty : reader["Nombre"].ToString(),
                        Edad = reader.IsDBNull(reader.GetOrdinal("Edad")) ? 0 : Convert.ToInt32(reader["Edad"]),
                        FechaNacimiento = reader.IsDBNull(reader.GetOrdinal("Fecha_Nacimiento")) ? DateTime.MinValue : Convert.ToDateTime(reader["Fecha_Nacimiento"]),
                    });
                }
            }

            return estudiantes;
        }
    }
}