
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Comun;

namespace AccesoADatos.Consulta
{
    public class CabmsConsulta
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

        public List<Comun.Objeto.CABMS> consultaCabms()
        {
            DataSet ds = new DataSet();
            //OleDbCommand cm = new OleDbCommand();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            Comun.Objeto.CABMS oCabms = null;
            List<Comun.Objeto.CABMS> listCabms = new List<Comun.Objeto.CABMS>();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT * from CABMS";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);
                int rows = ds.Tables[0].Rows.Count-1;

                for (int i = 0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    oCabms = new Comun.Objeto.CABMS(int.Parse(dr["Id"].ToString()), dr["CLAVE"].ToString(), dr["DESCRIPCION"].ToString());
                    listCabms.Add(oCabms);
                }


            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un problema al cargar las claves CABMS\n" + ex);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return listCabms;
        }

        public List<Comun.Objeto.CABMS> consultaCabmsxCaracteristica(string caracteristica)
        {
            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            Comun.Objeto.CABMS oCabms = null;
            List<Comun.Objeto.CABMS> listCabms = new List<Comun.Objeto.CABMS>();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT * from CABMS WHERE DESCRIPCION like '%"+caracteristica+"%'";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);
                int rows = ds.Tables[0].Rows.Count - 1;

                for (int i = 0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    oCabms = new Comun.Objeto.CABMS(int.Parse(dr["Id"].ToString()), dr["CLAVE"].ToString(), dr["DESCRIPCION"].ToString());
                    listCabms.Add(oCabms);
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un problema al cargar las claves CABMS\n" + ex);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return listCabms;
        }
    }
}
