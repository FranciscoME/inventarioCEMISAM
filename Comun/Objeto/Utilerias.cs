
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Comun.Objeto
{
    public class Utilerias
    {
        public SqlConnection conectar()
        {
            SqlConnection cn=null;
            try
            {
                
                ConnectionStringSettings cnSettings = ConfigurationManager.ConnectionStrings["conection"];
                string cs = cnSettings.ConnectionString;
                cn = new SqlConnection(cs);
                cn.Open();
            }
            catch (SqlException ex)
            {
               MessageBox.Show("No se ha podido establecer conexion a la base de datos\n" + ex);
            }

            return cn;
        }
    }
}
