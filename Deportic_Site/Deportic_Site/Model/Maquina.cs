using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deportic_Site.Model
{
    public class Maquina
    {
        public string referencia { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public DateTime fechaCompra { get; set; }
        public Maquina()
        {
        }
    }
}