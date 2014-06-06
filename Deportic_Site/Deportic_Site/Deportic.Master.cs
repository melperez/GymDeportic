using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Deportic_Site
{
    public partial class Deportic : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Autenticated"] == null)
                Session["Autenticated"] = false;

            if ((bool)Session["Autenticated"])
            {

                switch ((string)Session["Perfil"])
                {
                    case "Administrador": break;
                    case "Deportista":
                        while (NavigationMenu.Items.Count > 3) //Menu deportista
                        {
                            NavigationMenu.Items.RemoveAt(1);
                        }
                        break;
                    case "Profesional":
                        while (NavigationMenu.Items.Count > 5)//Menu Profesional/Instructor
                        {
                            NavigationMenu.Items.RemoveAt(1);
                        }
                        break;
                    default:
                        break;
                }

            }

        }

    }
}