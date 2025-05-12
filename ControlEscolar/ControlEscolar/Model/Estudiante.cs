using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.Model
{
    public class Estudiante
    {
        public int Matricula { get; set; }
        public string CURP { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Contraseña { get; set; }
    }

}