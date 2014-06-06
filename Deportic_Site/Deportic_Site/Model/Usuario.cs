using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deportic_Site.Model
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string direccion { get; set; }
        public int estado { get; set; }
        public int tipoID { get; set; }
        public string barrio { get; set; }
        public char genero { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string ocupacion { get; set; }
        public string Especialidad { get; set; }
        public int perfil { get; set; }
        public int? Desarrollo { get; set; }

        public Usuario()
        {
            
        }
    }
}