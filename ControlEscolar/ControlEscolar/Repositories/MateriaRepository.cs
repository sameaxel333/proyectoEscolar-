using System.Collections.Generic;
using System.Data.SqlClient;
using ControlEscolar.Model;
namespace ControlEscolar.Repositories
{
    public class MateriaRepository : RepositoryBase
    {
        public List<MateriaModel> ObtenerMaterias()
        {
            var materias = new List<MateriaModel>();

            // Usa el método GetConnection() heredado
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Nombre FROM Materia ORDER BY Nombre";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        materias.Add(new MateriaModel
                        {
                            NombreMateria = reader.GetString(0)
                        });
                    }
                }
            }

            return materias;
        }
    }
}