using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.Model
{
    public class UserModel
    {
        internal string Nombre;

        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int Edad { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Matricula { get; set; }
        public string CURP { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int Numero_Empleado { get; set; }
    }
}
