using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deportic_Site.Model
{
    public class Rutina
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Ejercicio { get; set; }
        public int repeticiones { get; set; }
        public int series { get; set; }

        public Rutina() { }
    }
}