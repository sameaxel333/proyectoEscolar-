using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ControlEscolar.Model;
using System.Collections.ObjectModel;

namespace ControlEscolar.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Server = SEBACUNA\\VSGESTION; " +
                "Database = ProyectoEsc; " +
                "Integrated Security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
        public void GuardarCurso()
        {
            using (var connection = GetConnection()) 
            {
                // Código para insertar en la base de datos
            }
        }

    }
}
