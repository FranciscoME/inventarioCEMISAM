
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace AccesoADatos.Consulta
{
    public class ClientesConsulta
    {
        //public OleDbConnection conectarBD()
        //{
        //    OleDbConnection cn = new OleDbConnection();
        //    try
        //    {
        //        cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\INVCEMISAM\INVENTARIOS CEMISAM.accdb";
        //        cn.Open();
        //    }
        //    catch (OleDbException ex)
        //    {
        //        MessageBox.Show("No se ha podido establecer conexion a la base de datos\n" + ex);
        //    }

        //    return cn;
        //}

        //public SqlConnection conectarBD()
        //{
        //    SqlConnection cn = new SqlConnection();
        //    try
        //    {
        //        //cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\INVCEMISAM\INVENTARIOS CEMISAM.accdb";
        //        //cn.ConnectionString = @"Data Source=PC01\SQLEXPRESS;Initial Catalog=invCEMISAM;User ID=ejemplo2;Password=ejemplo2";
        //        cn.ConnectionString = @"Data Source=PC-VAIO\SQLEXPRESS;Initial Catalog=invCEMISAM;User ID=ejemplo3;Password=ejemplo3";
        //        cn.Open();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("No se ha podido establecer conexion a la base de datos\n" + ex);
        //    }

        //    return cn;
        //}

        public SqlConnection conectarBD()
        {

            Comun.Objeto.Utilerias util = new Comun.Objeto.Utilerias();
            return util.conectar();
        }


        public Comun.Objeto.Usuario obtenerUsuario(int idUsuario)
        {
            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            Comun.Objeto.Usuario oUsuario =null;

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT * FROM USUARIOS where Id =@idUsuario";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                adaptador.Fill(ds);
                DataRow dr = ds.Tables[0].Rows[0];

                oUsuario = new Comun.Objeto.Usuario(int.Parse(dr["Id"].ToString()), dr["RFC"].ToString(), dr["NOMBRE"].ToString(),int.Parse( dr["FKDEPARTAMENTO"].ToString()));
            }
            catch
            {

            }

            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return oUsuario;

        }


        public List<Comun.Objeto.Usuario> obtenerListaUsuarios()
        {
            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            Comun.Objeto.Usuario oUsuario = null;
            List<Comun.Objeto.Usuario> listUsuario = new List<Comun.Objeto.Usuario>();
            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT * FROM USUARIOS ORDER BY NOMBRE";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);                
                adaptador.Fill(ds);
                

                int rows = ds.Tables[0].Rows.Count-1;

                for (int i = 0; i < rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    oUsuario = new Comun.Objeto.Usuario(int.Parse(dr["Id"].ToString()), dr["RFC"].ToString(), dr["NOMBRE"].ToString(), int.Parse(dr["FKDEPARTAMENTO"].ToString()));
                    listUsuario.Add(oUsuario);
                }

                              
            }
            catch
            {

            }

            finally
            {
                cn.Close();
                cn.Dispose();
            }

            

            return listUsuario;

        }

        public string ObtenerNombreUsuario(int fkUsuario)
        {
            //DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            //Comun.Objeto.Usuario oUsuario = null;
            string nombre = "";

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT NOMBRE FROM USUARIOS where Id ="+fkUsuario+"";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                nombre = cm.ExecuteScalar().ToString();                
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un problema con la consulta\n" + ex);
            }

            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return nombre; 
        }

        public bool insertarUsuario(Comun.Objeto.Usuario oUsuario)
        {
            bool resultado = false;
            SqlConnection cn = conectarBD();
            SqlCommand cm = new SqlCommand();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "Insert into usuarios (NOMBRE,FKDEPARTAMENTO) values ('" + oUsuario.Nombre + "'," + oUsuario.FkDepartamento + ")";
                int ra = cm.ExecuteNonQuery();
                if (ra >= 1)
                {
                    resultado = true;
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error al insertar el usuario\n" + ex);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
            return resultado;
        }

        public bool modificarUsuario(Comun.Objeto.Usuario oUsuario)
        {
            bool resultado = false;
            SqlConnection cn = conectarBD();
            SqlCommand cm = new SqlCommand();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "UPDATE USUARIOS SET NOMBRE = '" + oUsuario.Nombre + "',  FKDEPARTAMENTO = " + oUsuario.FkDepartamento + " where Id=" + oUsuario.ID + "";
                int ra = cm.ExecuteNonQuery();
                if (ra >= 1)
                {
                    resultado = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar el usuario\n" + ex);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
            return resultado;
        }


        public bool eliminarUsuario(int idUsuario)
        {
            bool resultado = false;
            SqlConnection cn = conectarBD();
            SqlCommand cm = new SqlCommand();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "DELETE FROM USUARIOS WHERE Id =@Id ";
                cm.Parameters.AddWithValue("@Id", idUsuario);
                int ra = cm.ExecuteNonQuery();
                
                if (ra >= 1)
                {
                    resultado = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al eliminar el usuario\n" + ex);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
            return resultado;
        }
    }
}
