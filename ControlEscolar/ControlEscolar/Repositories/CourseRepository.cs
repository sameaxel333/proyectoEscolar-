using ControlEscolar.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ControlEscolar.Repositories
{
    class CourseRepository : RepositoryBase
    {
        
        public List<MateriaModel> ObtenerMaterias()
        {
            var materias = new List<MateriaModel>();

            using (var connection = GetConnection())
            using (var command = new SqlCommand("SELECT ID_Materia, Nombre FROM Materia", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    materias.Add(new MateriaModel { MateriaID = reader.GetInt32(0), NombreMateria = reader.GetString(1) });
                }
            }
            return materias;
        }

        public List<MaestroModel> ObtenerMaestros()
        {
            var maestros = new List<MaestroModel>();

            using (var connection = GetConnection())
            using (var command = new SqlCommand("SELECT Numero_Empleado, Nombre FROM Maestro", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    maestros.Add(new MaestroModel { Numero_Empleado = reader.GetInt32(0), NombreProfesor = reader.GetString(1) });
                }
            }
            return maestros;
        }

        public bool GuardarCurso(CourseModel curso)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
                INSERT INTO Curso 
                    (ID_Materia, Numero_Empleado, Grado, Grupo, Dia, Hora_Inicio, Hora_Fin)
                VALUES 
                    (@materiaID, @numEmpleado, @grado, @grupo, @dia, @horaInicio, @horaFin)";

                command.Parameters.Add("@materiaID", SqlDbType.Int).Value = curso.MateriaID;
                command.Parameters.Add("@numEmpleado", SqlDbType.Int).Value = curso.Numero_Empleado;
                command.Parameters.Add("@grado", SqlDbType.Int).Value = curso.Grado;
                command.Parameters.Add("@grupo", SqlDbType.Char, 1).Value = curso.Grupo;
                command.Parameters.Add("@dia", SqlDbType.VarChar, 20).Value = string.IsNullOrWhiteSpace(curso.Dia) ? "Lunes" : curso.Dia;
                command.Parameters.Add("@horaInicio", SqlDbType.Time).Value = TimeSpan.Parse(curso.HoraInicio.ToString(@"hh\:mm\:ss"));
                command.Parameters.Add("@horaFin", SqlDbType.Time).Value = TimeSpan.Parse(curso.HoraFin.ToString(@"hh\:mm\:ss"));

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        
        public List<CourseModel> ObtenerCursos()
        {
            List<CourseModel> cursos = new List<CourseModel>();

            

            return cursos;
        }


    }
}
