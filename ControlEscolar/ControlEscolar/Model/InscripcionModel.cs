using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.Model
{
    public class InscripcionModel
    {
        public int ID_Inscripcion { get; set; } // Se autoincrementa en BD
        public int Matricula { get; set; } // FK del Alumno
        public int ID_Curso { get; set; } // FK del Curso
        public DateTime FechaInscripcion { get; set; } = DateTime.Today;
    }
}
