using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Data;
using Deportic_Site.ViewModel;
using Deportic_Site.Model;

namespace Deportic_Site.Views
{
    public partial class Login : System.Web.UI.Page, ILogin
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.close.ServerClick += new EventHandler(close_ServerClick);

             if (Session["Autenticated"] == null)
                Session["Autenticated"] = false;

            if ((bool)Session["Autenticated"])
            {
                this.dvLogin.Style.Remove("Visibility");
                this.dvLogin.Style.Add("Visibility", "hidden");
                this.fieldset.Style.Remove("Visibility");
                this.fieldset.Style.Add("Visibility", "hidden");
                this.fieldset.Visible = false;
                this.dvDefault.Style.Remove("Visibility");
                this.dvDefault.Style.Add("Visibility", "visible");
                this.Titulo.InnerText += " " + Usuario.ToUpper();
            }
        }

        protected void close_ServerClick(object sender, EventArgs e)
        {
            this.Autentica = false;
            Response.Redirect("~\\Views\\Login.aspx");
        }


        protected void AutenticarUsuario(object sender, AuthenticateEventArgs e)
        {
            Session["Autenticated"] = false;
            string m_strNombre = "";
            string m_strPerfil = "";
            bool Autenticado = false;
            string l_objCadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ToString();
            SISTEMA sistema = new SISTEMA(l_objCadenaConexion);
            Autenticado = sistema.AutenticarUsuario(UserLogin.UserName, UserLogin.Password, out m_strNombre, out m_strPerfil);
            if (m_strNombre != string.Empty)
                this.Usuario = m_strNombre;
            if (m_strPerfil != string.Empty)
                this.Perfil = m_strPerfil;
            e.Authenticated = Autenticado;
            if (Autenticado)
                Session["Autenticated"] = true;

        }


        public bool Autentica
        {
            get
            {
                return (bool)Session["Autenticated"];
            }
            set
            {
                Session["Autenticated"] = value;
            }
        }

        public string Usuario
        {
            get
            {
                return (string)Session["Usuario"];
            }
            set
            {
                Session["Usuario"] = value;
            }
        }

        public string Contrasena
        {
            get
            {
                return (string)Session["Password"];
            }
            set
            {
                Session["Password"] = value;
            }
        }

        public string Perfil
        {
            get
            {
                return (string)Session["Perfil"];
            }
            set
            {
                Session["Perfil"] = value;
            }
        }
    }
}