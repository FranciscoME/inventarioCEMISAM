
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace AccesoADatos.Consulta
{
    public class DepartamentoConsulta
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

        public bool insertarDepartamento(string nombreDepartamento)
        {
            SqlConnection cn = conectarBD();
            bool insertado = false;
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "insert into DEPARTAMENTO (NOMBREDEPARTAMENTO) values (@Nombre)";
                cm.Parameters.AddWithValue("@Nombre", nombreDepartamento);
                int ra = cm.ExecuteNonQuery();
                if (ra >= 1)
                    insertado = true;

            }
            catch
            {
                
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
            return insertado;
        }

        public List<Comun.Objeto.Departamento> ObtenerDepartamentos()
        {
            DataSet ds = new DataSet(); 
            SqlConnection cn = conectarBD();
            Comun.Objeto.Departamento oDepartamento; ;
            List<Comun.Objeto.Departamento> listDepartamentos = new List<Comun.Objeto.Departamento>();
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT Id,NOMBREDEPARTAMENTO FROM DEPARTAMENTO";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);
                int rows = ds.Tables[0].Rows.Count - 1;

                for (int i=0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    oDepartamento = new Comun.Objeto.Departamento(int.Parse(dr["Id"].ToString()),dr["NOMBREDEPARTAMENTO"].ToString());
                    listDepartamentos.Add(oDepartamento);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error al consultar los departamentos\n" + ex);
            }
            return listDepartamentos;
        }


        public List<Comun.Objeto.Departamento> ObtenerDepartamento(int Id)
        {
            DataSet ds = new DataSet();
            SqlConnection cn = conectarBD();
            Comun.Objeto.Departamento oDepartamento; ;
            List<Comun.Objeto.Departamento> listDepartamentos = new List<Comun.Objeto.Departamento>();
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT Id,NOMBREDEPARTAMENTO FROM DEPARTAMENTO where Id ="+Id+"";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);
                int rows = ds.Tables[0].Rows.Count - 1;

                for (int i = 0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    oDepartamento = new Comun.Objeto.Departamento(int.Parse(dr["Id"].ToString()), dr["NOMBREDEPARTAMENTO"].ToString());
                    listDepartamentos.Add(oDepartamento);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al consultar los departamentos\n" + ex);
            }
            return listDepartamentos;
        }
   
    }
}
