using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_Progra_IX.Models
{
    public class Alumnos
    {
        public int id { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public int carne { get; set; }
        public string carrera { get; set; }
        public DateTime fecha_de_ingreso { get; set; }
        public DateTime fecha_nac { get; set; }
        public string correo_electronico { get; set; }
        public int telefono { get; set; }
        public string genero { get; set; }
    }
}
