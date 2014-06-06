using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deportic_Site.Model
{
    public class Ejercicio
    {
        public string Nombre { get; set; }
        public string descripcion { get; set; }
        public string ZonaCuerpo { get; set; }
        public int Categoria { get; set; }

        public Ejercicio(){}
    }
}