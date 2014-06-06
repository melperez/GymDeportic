using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Deportic_Site.ViewModel;
using System.Data;

namespace Deportic_Site.Views
{
    public partial class RegistroMaquina : System.Web.UI.Page
    {
        Dictionary<string, int> colLookup = new Dictionary<string,int>(); 
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["Agregar"] = Request.QueryString["Agregar"];

            if (Session["IdIngreso"] == null)
                Session["IdIngreso"] = 0;
            this.BtnRegistroMaquina.ServerClick += new EventHandler(BtnRegistroMaquina_ServerClick);
            this.BtnBack.ServerClick += new EventHandler(BtnBack_ServerClick);

            if (!IsPostBack)
            {
                // Call FillGridView Method
                FillGridView();
                
                
            }

            if (Session["Agregar"] == null)
                Session["Agregar"] = false;
            try
            {
                if ((bool)Session["Agregar"])
                {
                    this.Consultar.Style.Remove("Visibility");
                    this.Consultar.Style.Add("Visibility", "hidden");
                    this.Consultar.Visible = false;
                    this.Form.Style.Remove("Visibility");
                    this.Form.Style.Add("Visibility", "visible");
                    this.ImgInsert.Style.Remove("Visibility");
                    this.ImgInsert.Style.Add("Visibility", "visible");
                    this.divFieldset.Style.Remove("Visibility");
                    this.divFieldset.Style.Add("Visibility", "visible");
                }
                else
                {
                    this.Consultar.Style.Remove("Visibility");
                    this.Consultar.Style.Add("Visibility", "visible");
                    this.Consultar.Visible = Visible;
                    this.Form.Style.Remove("Visibility");
                    this.Form.Style.Add("Visibility", "visible");
                }
            }
            catch (InvalidCastException exception)
            {
                Session["Agregar"] = true;
                Response.Redirect("~/Views/RegistroMaquina.aspx");
            }

        }

        public void BtnBack_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegistroMaquina.aspx");
        }

        public void BtnRegistroMaquina_ServerClick(object sender, EventArgs e)
        {
            Session["Agregar"] = false;
            string l_objCadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ToString();
            SISTEMA sistema = new SISTEMA(l_objCadenaConexion);
            Model.Maquina obj_maquina = new Model.Maquina()
            {
                descripcion = this.Desc.Value,
                estado = this.estado.Value,
                fechaCompra = Convert.ToDateTime(this.FechaAnio.Value + "-" + this.fechaMes.Value + "-" + this.fechaDia.Value),
                nombre = this.Nombre.Value,
                referencia = this.Ref.Value
            };
            string Mensaje = "";
            sistema.AdicionarMaquina(obj_maquina, (int)Session["IdIngreso"], out Mensaje);
            Response.Redirect("~/Views/RegistroMaquina.aspx");
        }


        protected void EditMaquina(object sender, EventArgs e)
        {
            this.Consultar.Style.Remove("Visibility");
            this.Consultar.Style.Add("Visibility", "hidden");
            this.Consultar.Visible = false;
            this.Form.Style.Remove("Visibility");
            this.Form.Style.Add("Visibility", "visible");
            this.ImgInsert.Style.Remove("Visibility");
            this.ImgInsert.Style.Add("Visibility", "visible");
            this.divFieldset.Style.Remove("Visibility");
            this.divFieldset.Style.Add("Visibility", "visible");
        }

        protected void BorrarMaquina(object sender, EventArgs e)
        {
            GridViewRow r = (GridViewRow)((Control)sender).NamingContainer;
            int index = r.RowIndex;
            this.Consultar.Style.Remove("Visibility");
            this.Consultar.Style.Add("Visibility", "hidden");
            this.Consultar.Visible = false;
            this.Form.Style.Remove("Visibility");
            this.Form.Style.Add("Visibility", "visible");
            this.ImgInsert.Style.Remove("Visibility");
            this.ImgInsert.Style.Add("Visibility", "visible");
            this.divFieldset.Style.Remove("Visibility");
            this.divFieldset.Style.Add("Visibility", "visible");

            //Session["Agregar"] = false;
            //string mensajeR = string.Empty;
            //string l_objCadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ToString();
            //SISTEMA sistema = new SISTEMA(l_objCadenaConexion);
            //DataTable dtMaquinas = new DataTable();
            //int indexCell = 0;
            //for (int i = 0; i < GvMaquinas.Rows[index].Cells.Count; i++)
            //{
            //    if (GvMaquinas.HeaderRow.Cells[index].Text == "ID")
            //    {
            //        indexCell = i;
            //        break;
            //    }
            //}
            //    string id = this.GvMaquinas.Rows[index].Cells[indexCell].Text;
            
            //sistema.ConsultarMaquina(dtMaquinas, id, true);
            //if (dtMaquinas.Rows.Count != 0)
            //    sistema.EliminarMaquina(Convert.ToInt16(id), out mensajeR);

        }

        private void FillGridView()
        {
            Session["Agregar"] = false;
            string l_objCadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ToString();
            SISTEMA sistema = new SISTEMA(l_objCadenaConexion);
            DataTable dtMaquinas = new DataTable();
            sistema.ConsultarMaquina(dtMaquinas, "", false);
            this.GvMaquinas.DataSource = dtMaquinas;
            GvMaquinas.DataBind();
        }
    }
}