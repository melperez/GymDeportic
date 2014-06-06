using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Deportic_Site.ViewModel;
using Deportic_Site.Model;

namespace Deportic_Site.Views
{
    public partial class Deportista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BtnRegistroDep.ServerClick += BtnRegistroDep_Click;
        }

        public void BtnRegistroDep_Click(object sender, EventArgs e)
        {
            bool Registrado = false;
            string ResultMessage = "";
            string l_objCadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ToString();
            SISTEMA sistema = new SISTEMA(l_objCadenaConexion);
            Usuario newUsuario = new Usuario(){
                Nombre = this.Nombres.Value,
                Apellidos = this.Apellidos.Value,
                UserName = this.UserName.Value,
                pass = this.Pass.Value,
                email = this.email.Value,
                direccion = this.direccion.Value,
                estado = 0,
                tipoID = this.TipoID.SelectedIndex,
                barrio = this.barrio.Value,
                genero = Convert.ToChar(this.Genero.Value),
                fechaNacimiento = Convert.ToDateTime(this.AnioNacimiento.Value + "-" + this.MesNacimiento.Value + "- " + this.DiaNacimiento.Value),
                fechaRegistro = DateTime.Now,
                ocupacion = this.Ocupacion.Value,
                Especialidad = null,
                perfil = this.Perfil.SelectedIndex,
                Desarrollo = 1
            };
            Random r = new Random();
            string msg = string.Empty;
            sistema.AdicionarUsuario(newUsuario, r.Next(), out msg);

            string vtn = "window.open('RegistroDeportista.aspx','Dates','scrollbars=yes,resizable=yes','height=300', 'width=300')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", vtn, true);

        }
    }
}