
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccesoADatos.Consulta
{
    public class CalculosArticulos
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


        public int NumeroDeArticulos()
        {

            //DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            Comun.Objeto.ArticuloConsulta oArticuloConsulta = null;
            List<Comun.Objeto.ArticuloConsulta> listaArticulos = null;
            //MessageBox.Show("CabmsEnviada:" + claveCabms);
            int rows = 0;

            try
            {
                cm.Connection = cn;
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT COUNT (Id) FROM ARTICULOS";
                //cm.CommandText = "SELECT * FROM ARTICULOS where CLAVECABMS like '%I450400028%'";
                //OleDbDataAdapter adaptador = new OleDbDataAdapter(cm.CommandText, cn);
                //adaptador.SelectCommand.Parameters.AddWithValue("@claveCabm", claveCabms);
                rows = int.Parse(cm.ExecuteScalar().ToString());

                //adaptador.Fill(ds);
                //DataRow dr = ds.Tables[0].Rows[0];
                //rows = ds.Tables[0].Rows.Count;

                //MessageBox.Show("Registros encontrados: " + rows.ToString());

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un problema con la consulta del articulo\n" + ex);
            }
            catch
            {

            }

            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return rows;
        }

        public int NumeroDeArticulosDonacion()
        {

            //DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            Comun.Objeto.ArticuloConsulta oArticuloConsulta = null;
            List<Comun.Objeto.ArticuloConsulta> listaArticulos = null;
            //MessageBox.Show("CabmsEnviada:" + claveCabms);
            int rows = 0;

            try
            {
                cm.Connection = cn;
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT COUNT (Id) FROM ARTICULOS where DONACION = 1";
                //cm.CommandText = "SELECT * FROM ARTICULOS where CLAVECABMS like '%I450400028%'";
                //OleDbDataAdapter adaptador = new OleDbDataAdapter(cm.CommandText, cn);
                //adaptador.SelectCommand.Parameters.AddWithValue("@claveCabm", claveCabms);
                rows = int.Parse(cm.ExecuteScalar().ToString());

                //adaptador.Fill(ds);
                //DataRow dr = ds.Tables[0].Rows[0];
                //rows = ds.Tables[0].Rows.Count;

                //MessageBox.Show("Registros encontrados: " + rows.ToString());

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un problema con la consulta del articulo\n" + ex);
            }
            catch
            {

            }

            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return rows;
        }


        public int NumeroDeArticulosBaja()
        {

            //DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            Comun.Objeto.ArticuloConsulta oArticuloConsulta = null;
            List<Comun.Objeto.ArticuloConsulta> listaArticulos = null;
            //MessageBox.Show("CabmsEnviada:" + claveCabms);
            int rows = 0;

            try
            {
                cm.Connection = cn;
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT COUNT (Id) FROM ARTICULOS where BAJA = 1";
                //cm.CommandText = "SELECT * FROM ARTICULOS where CLAVECABMS like '%I450400028%'";
                //OleDbDataAdapter adaptador = new OleDbDataAdapter(cm.CommandText, cn);
                //adaptador.SelectCommand.Parameters.AddWithValue("@claveCabm", claveCabms);
                rows = int.Parse(cm.ExecuteScalar().ToString());

                //adaptador.Fill(ds);
                //DataRow dr = ds.Tables[0].Rows[0];
                //rows = ds.Tables[0].Rows.Count;

                //MessageBox.Show("Registros encontrados: " + rows.ToString());

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un problema con la consulta del articulo\n" + ex);
            }
            catch
            {

            }

            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return rows;
        }



        public double costoTotalBienes()
        {
            //DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            Comun.Objeto.ArticuloConsulta oArticuloConsulta = null;
            List<Comun.Objeto.ArticuloConsulta> listaArticulos = null;
            //MessageBox.Show("CabmsEnviada:" + claveCabms);
            double costoTotal = 0;

            try
            {
                cm.Connection = cn;
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT SUM(COSTOUNITARIO) FROM ARTICULOS ";
                //cm.CommandText = "SELECT * FROM ARTICULOS where CLAVECABMS like '%I450400028%'";
                //OleDbDataAdapter adaptador = new OleDbDataAdapter(cm.CommandText, cn);
                //adaptador.SelectCommand.Parameters.AddWithValue("@claveCabm", claveCabms);
                object o = cm.ExecuteScalar();
                costoTotal= double.Parse(o.ToString());
                //adaptador.Fill(ds);
                //DataRow dr = ds.Tables[0].Rows[0];
                //rows = ds.Tables[0].Rows.Count;

                //MessageBox.Show("Registros encontrados: " + rows.ToString());

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un problema con la consulta del articulo\n" + ex);
            }
            

            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return costoTotal;
        }
    }
}
