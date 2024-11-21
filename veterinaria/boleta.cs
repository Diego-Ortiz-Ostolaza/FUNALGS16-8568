using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    public class boleta
    {
        public int Codigo { get; set; }

        public mascotas mascota1 { get; set; }
        public servicios Servicio1 { get; set; }
        public servicios Servicio2 { get; set; }
        public double Total { get; set; }
    }
}
