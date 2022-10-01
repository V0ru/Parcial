using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Postgrado
    {
        public int NoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ProgramaPostgrado { get; set; }
        public int Semestre { get; set; }
        public double PromedioSemestre { get; set; }
    }
}
