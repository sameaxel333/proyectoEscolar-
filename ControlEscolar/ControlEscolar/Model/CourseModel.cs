using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlEscolar.Model
{
    public class CourseModel
    {
        public int CursoID { get; set; }  // Identificador único del curso
        public int MateriaID { get; set; }  // FK hacia Materia
        public int Numero_Empleado { get; set; }  // FK hacia Profesor
        public int Grado { get; set; }  // Año escolar del curso
        public char Grupo { get; set; }  // Identificador de grupo (ej. 'A', 'B')
        public string Dia { get; set; }  // Día de la semana (VARCHAR(20))
        public TimeSpan HoraInicio { get; set; }  // Inicio de clase (TIME(7))
        public TimeSpan HoraFin { get; set; }  // Fin de clase (TIME(7))
    }
}
