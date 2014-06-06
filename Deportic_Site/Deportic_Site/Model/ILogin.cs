using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deportic_Site.Model
{
    public interface ILogin
    {
        bool Autentica { get; set; }
        string Usuario { get; set; }
        string Contrasena { get; set; }
        string Perfil { get; set; }

    }
}
