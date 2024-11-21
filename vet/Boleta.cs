using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    internal class boleta
    {
        public int Codigo { get; set; }
        public mascota Mascota { get; set; }
        public servicio Servicio1 { get; set; }
        public servicio Servicio2 { get; set; }
        public double Total { get; set; }
}
}
