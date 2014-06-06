using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Deportic_Site.Model;

namespace Deportic_Site.ViewModel
{
    public class SISTEMA
    {
        string m_strConn = "";
        public SISTEMA(string conn)
        {
            m_strConn = conn;
        }

        public bool AutenticarAdministrador(string usuario, string contrasena)
        {
            bool autentica = false;
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            SqlCommand l_objCommand = new SqlCommand("SELECT * FROM tblAdministradores WHERE Usuario = '" + usuario + "' AND Contraseña = '" + contrasena + "'", l_objConexion);
            SqlDataReader result = l_objCommand.ExecuteReader();
            DataTable tblAdministradores = new DataTable();
            tblAdministradores.Load(result);
            l_objConexion.Close();
            if (tblAdministradores.Rows.Count != 0)
                autentica = true;

            return autentica;
        }

        public bool AutenticarUsuario(string usuario, string contrasena, out string Nombre, out string Perfil)
        {
            bool autentica = false;
            Nombre = string.Empty;
            Perfil = string.Empty;
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT Nombre, Apellidos, Usuario, Estado, tblPerfiles.Perfil");
            query.Append(" FROM tblUsuarios");
            query.Append(" INNER JOIN tblPerfiles on tblPerfiles.id = tblUsuarios.Perfil");
            query.Append(" WHERE Usuario = '" + usuario + "' AND Contraseña = '" + contrasena + "'");
            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            SqlDataReader result = l_objCommand.ExecuteReader();
            DataTable tblUsuarios = new DataTable();
            tblUsuarios.Load(result);
            l_objConexion.Close();
            if (tblUsuarios.Rows.Count != 0)
            {
                autentica = true;
                Nombre = tblUsuarios.Rows[0]["Nombre"].ToString();
                Perfil = tblUsuarios.Rows[0]["Perfil"].ToString();
            }
            return autentica;
        }

        public bool AdicionarUsuario(Usuario usuario, int id, out string MensajeResult)
        {
            bool adiciona = false;
            MensajeResult = "";
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" INSERT INTO tblUsuarios");
            query.Append(" ([Id],                                  ");
            query.Append(" [Nombre],                               ");
            query.Append(" [Apellidos],                            ");
            query.Append(" [Usuario],                              ");
            query.Append(" [Contraseña],                           ");
            query.Append(" [Email],                                ");
            query.Append(" [Direccion],                            ");
            query.Append(" [Estado],                               ");
            query.Append(" [TipoId],                               ");
            query.Append(" [Barrio],                               ");
            query.Append(" [Genero],                               ");
            query.Append(" [FechaNacimiento],                      ");
            query.Append(" [FechaRegistro],                        ");
            query.Append(" [Ocupacion],                            ");
            query.Append(" [Especialidad],                         ");
            query.Append(" [Perfil],                               ");
            query.Append(" [Desarrollo])                          ");
            query.Append(" VALUES                                                       ");
            query.Append(" (" + id.ToString() + ",                                 ");
            query.Append(" " + usuario.Nombre + ",                          ");
            query.Append(" " + usuario.Apellidos + ",                          ");
            query.Append(" " + usuario.UserName + ",                          ");
            query.Append(" " + usuario.pass + ",                          ");
            query.Append(" " + usuario.email + ",                          ");
            query.Append(" " + usuario.direccion + ",                          ");
            query.Append(" " + usuario.estado.ToString() + ",                          ");
            query.Append(" " + usuario.tipoID.ToString() + ",                          ");
            query.Append(" " + usuario.barrio + ",                          ");
            query.Append(" " + usuario.genero + ",                          ");
            query.Append(" " + usuario.fechaNacimiento + ",                          ");
            query.Append(" " + usuario.fechaRegistro + ",                          ");
            query.Append(" " + usuario.ocupacion + ",                          ");
            query.Append(" " + usuario.Especialidad + ",                          ");
            query.Append(" " + usuario.perfil.ToString() + ",                          ");
            query.Append(" " + usuario.Desarrollo.ToString() + ",                       ");

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            int result = l_objCommand.ExecuteNonQuery();
            l_objConexion.Close();
            if (result > 0)
            {
                adiciona = true;
                MensajeResult = "Usuario " + usuario.Nombre + " agregado exitosamente en perfiles de tipo" + usuario.perfil;
            }
            else
                MensajeResult = "Ocurrió un error agregando la información. Intente mas tarde";
            return adiciona;
        }

        public bool ConsultarUsuarios(DataTable dtUsuarios, string username, bool filtro)
        {
            bool select = false;
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT *");
            query.Append(" FROM tblUsuarios");
            if (filtro)
            {
                query.Append("where Usuario = '" + username + "'");
            }

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            SqlDataReader result = l_objCommand.ExecuteReader();
            dtUsuarios.Load(result);
            l_objConexion.Close();
            if (dtUsuarios.Rows.Count != 0)
            {
                select = true;
            }


            return select;
        }

        public bool ActualizarUsuario(Usuario usuario, out string MensajeResult, int id)
        {
            bool actualiza = false;
            MensajeResult = "";
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" UPDATE tblUsuarios SET ");
            query.Append(" ([Id]            = " + id.ToString() + ",                                               ");
            query.Append(" [Nombre]         = '" + usuario.Nombre + "',                                           ");
            query.Append(" [Apellidos]      = '" + usuario.Apellidos + "',                                     ");
            query.Append(" [Usuario]        = '" + usuario.UserName + "',                                         ");
            query.Append(" [Contraseña]     = '" + usuario.pass + "',                                         ");
            query.Append(" [Email]          = '" + usuario.email + "',                                             ");
            query.Append(" [Direccion]      = '" + usuario.direccion + "',                                     ");
            query.Append(" [Estado]         = " + usuario.estado.ToString() + ",                              ");
            query.Append(" [TipoId]         = " + usuario.tipoID.ToString() + ",                              ");
            query.Append(" [Barrio]         = '" + usuario.barrio + "',                                           ");
            query.Append(" [Genero]         = '" + usuario.genero + "',                                           ");
            query.Append(" [FechaNacimiento]= '" + usuario.fechaNacimiento + "',                         ");
            query.Append(" [FechaRegistro]  = '" + usuario.fechaRegistro + "',                             ");
            query.Append(" [Ocupacion]      = '" + usuario.ocupacion + "',                                     ");
            query.Append(" [Especialidad]   = '" + usuario.Especialidad + "',                               ");
            query.Append(" [Perfil]         = " + usuario.perfil.ToString() + ",                              ");
            query.Append(" [Desarrollo]     = " + usuario.Desarrollo.ToString() + "                          ");
            query.Append(" WHERE id = " + id);

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            int result = l_objCommand.ExecuteNonQuery();
            l_objConexion.Close();
            if (result > 0)
            {
                actualiza = true;
                MensajeResult = "Usuario " + usuario.Nombre + " actualizado exitosamente en perfiles de tipo" + usuario.perfil;
            }
            else
                MensajeResult = "Ocurrió un error actualizando la información. Intente más tarde";
            return actualiza;
        }

        public bool EliminarUsuarios(int id, out string MensajeResult)
        {
            bool elimina = false;
            MensajeResult = "";
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" DELETE ");
            query.Append(" FROM tblUsuarios");
            query.Append("where Id = " + id);

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            int result = l_objCommand.ExecuteNonQuery();
            l_objConexion.Close();
            if (result > 0)
            {
                elimina = true;
                MensajeResult = "Usuario Eliminado Exitosamente!";
            }
            else
                MensajeResult = "Ocurrio un error eliminando la informacion";
            return elimina;
        }

        public bool AdicionarMaquina(Maquina maquina, int id, out string MensajeResult)
        {
            bool adiciona = false;
            MensajeResult = "";
            id += id + 100 + Convert.ToInt16(DateTime.Now.Millisecond) + Convert.ToInt16(DateTime.Now.Second);
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" INSERT INTO tblMaquinas VALUES (");
            query.Append( id + ", '");
            query.Append(maquina.referencia + "', '");
            query.Append(maquina.nombre + "', '");
            query.Append(maquina.descripcion + "', ");
            query.Append( 0 +", '");
            query.Append(maquina.fechaCompra.ToString("yyyy-MM-dd") + "')");

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            int result = l_objCommand.ExecuteNonQuery();
            l_objConexion.Close();
            if (result > 0)
            {
                adiciona = true;
                MensajeResult = "Maquina agregada exitosamente";
            }
            else
                MensajeResult = "Ocurrió un error agregando la información. Intente mas tarde";
            return adiciona;
        }

        public bool ConsultarMaquina(DataTable dtMaquinas, string id, bool filtro)
        {
            bool select = false;
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT *");
            query.Append(" FROM tblMaquinas");
            if (filtro)
            {
                query.Append("where id = '" + id + "'");
            }

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            SqlDataReader result = l_objCommand.ExecuteReader();
            dtMaquinas.Load(result);
            l_objConexion.Close();
            if (dtMaquinas.Rows.Count != 0)
            {
                select = true;
            }

            return select;
        }

        public bool ActualizarMaquina(Maquina maquina, out string MensajeResult, int id)
        {
            bool actualiza = false;
            MensajeResult = "";
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" UPDATE tblMaquinas SET ");
            query.Append(" ([Id]            = " + id.ToString() + ",                                               ");
            query.Append(" [Referencia]         = '" + maquina.referencia + "',                                           ");
            query.Append(" [Nombre]      = '" + maquina.nombre + "',                                     ");
            query.Append(" [Estado]        = '" + maquina.estado + "',                                         ");
            query.Append(" [FechaCompra]     = '" + maquina.fechaCompra + "',                                         ");
            query.Append(" WHERE id = " + id);

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            int result = l_objCommand.ExecuteNonQuery();
            l_objConexion.Close();
            if (result > 0)
            {
                actualiza = true;
                MensajeResult = "Actualizacion exitosa!";
            }
            else
                MensajeResult = "Ocurrió un error actualizando la información. Intente más tarde";
            return actualiza;
        }

        public bool EliminarMaquina(int id, out string MensajeResult)
        {
            bool elimina = false;
            MensajeResult = "";
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" DELETE ");
            query.Append(" FROM tblMaquinas");
            query.Append("where Id = " + id);

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            int result = l_objCommand.ExecuteNonQuery();
            l_objConexion.Close();
            if (result > 0)
            {
                elimina = true;
                MensajeResult = "Eliminacion Exitosa!";
            }
            else
                MensajeResult = "Ocurrio un error eliminando la informacion";
            return elimina;
        }

        public bool AdicionarRutinas(Rutina rutina, int id, out string MensajeResult)
        {
            bool adiciona = false;
            MensajeResult = "";
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" INSERT INTO tblRutinas");
            query.Append(" ([Id]            ");
            query.Append(" ,[Nombre]        ");
            query.Append(" ,[Descripcion]   ");
            query.Append(" ,[Ejercicio]     ");
            query.Append(" ,[Repeticiones]  ");
            query.Append(" ,[Series])");
            query.Append(" VALUES                                                       ");
            query.Append(" (" + id.ToString() + ",                                 ");
            query.Append(" '" + rutina.Nombre + "',                          ");
            query.Append(" '" + rutina.Descripcion + "',                          ");
            query.Append(" " + rutina.Ejercicio.ToString() + ",                          ");
            query.Append(" " + rutina.repeticiones.ToString() + ",                          ");
            query.Append(" " + rutina.series.ToString() + ",                          ");

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            int result = l_objCommand.ExecuteNonQuery();
            l_objConexion.Close();
            if (result > 0)
            {
                adiciona = true;
                MensajeResult = "Rutina agregada exitosamente";
            }
            else
                MensajeResult = "Ocurrió un error agregando la información. Intente mas tarde";
            return adiciona;
        }

        public bool ConsultarRutinas(DataTable dtRutina, string id, bool filtro)
        {
            bool select = false;
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT *");
            query.Append(" FROM tblRutinas");
            if (filtro)
            {
                query.Append("where id = '" + id + "'");
            }

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            SqlDataReader result = l_objCommand.ExecuteReader();
            dtRutina.Load(result);
            l_objConexion.Close();
            if (dtRutina.Rows.Count != 0)
            {
                select = true;
            }

            return select;
        }

        public bool ActualizarRutinas(Rutina rutina, out string MensajeResult, int id)
        {
            bool actualiza = false;
            MensajeResult = "";
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" UPDATE tblRutinas SET ");
            query.Append(" ([Id]            = " + id.ToString() + ",                                               ");
            query.Append(" [Nombre]         = '" + rutina.Nombre + "',                                           ");
            query.Append(" [Descripcion]      = '" + rutina.Descripcion + "',                                     ");
            query.Append(" [Ejercicio]        = " + rutina.Ejercicio.ToString() + ",                                         ");
            query.Append(" [Repeticiones]     = " + rutina.repeticiones.ToString() + ",                                         ");
            query.Append(" [Series]     = " + rutina.series.ToString() + ",                                         ");
            query.Append(" WHERE id = " + id);

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            int result = l_objCommand.ExecuteNonQuery();
            l_objConexion.Close();
            if (result > 0)
            {
                actualiza = true;
                MensajeResult = "Actualizacion exitosa!";
            }
            else
                MensajeResult = "Ocurrió un error actualizando la información. Intente más tarde";
            return actualiza;
        }

        public bool EliminarRutina(int id, out string MensajeResult)
        {
            bool elimina = false;
            MensajeResult = "";
            SqlConnection l_objConexion = new SqlConnection(m_strConn);
            l_objConexion.Open();
            StringBuilder query = new StringBuilder();
            query.Append(" DELETE ");
            query.Append(" FROM tblRutinas");
            query.Append("where Id = " + id);

            SqlCommand l_objCommand = new SqlCommand(query.ToString(), l_objConexion);
            int result = l_objCommand.ExecuteNonQuery();
            l_objConexion.Close();
            if (result > 0)
            {
                elimina = true;
                MensajeResult = "Eliminacion Exitosa!";
            }
            else
                MensajeResult = "Ocurrio un error eliminando la informacion";
            return elimina;
        }

    }
}