using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ControlEscolar.Repositories
{
    class InscriptionRepository
    {
        public void RegistrarInscripcion(int matricula, int idCurso)
        {
            using (SqlConnection connection = new SqlConnection("TuCadenaDeConexion"))
            {
                string query = @"INSERT INTO Inscripcion (Matricula, ID_Curso, FechaInscripcion) 
                         VALUES (@matricula, @idCurso, @fechaInscripcion)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@matricula", SqlDbType.Int).Value = matricula;
                    command.Parameters.Add("@idCurso", SqlDbType.Int).Value = idCurso;
                    command.Parameters.Add("@fechaInscripcion", SqlDbType.Date).Value = DateTime.Today;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Inscripción realizada con éxito.");
        }
    }
}
