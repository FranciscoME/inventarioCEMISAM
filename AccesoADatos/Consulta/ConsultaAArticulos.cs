 
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace AccesoADatos.Consulta
{
    public class ConsultaAArticulos
    {

        //public OleDbConnection conectarBD()
        //{
        //    OleDbConnection cn = new OleDbConnection();
        //    try
        //    {
        //        cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\INVCEMISAM\INVENTARIOS CEMISAM.accdb";
        //        cn.Open();
        //    }
        //    catch(OleDbException ex)
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
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="claveCabms"></param>
        /// <returns></returns>
        /// //BUSQUEDAS DE OBJETOS ##################################################################################### 

        public Comun.Objeto.ArticuloConsulta ObtenerArticuloxCABMS(string claveCabms)
        {
            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            Comun.Objeto.ArticuloConsulta oArticuloConsulta=null;
            try
            {
            cm.Connection = cn;
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = "SELECT ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.CLAVECABMS='" + claveCabms + "';";
            SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
            //adaptador.SelectCommand.Parameters.AddWithValue("@claveCabm", claveCabms);             
            adaptador.Fill(ds);
            int rows = ds.Tables[0].Rows.Count -1;

                for (int i = 0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    oArticuloConsulta = new Comun.Objeto.ArticuloConsulta(dr["Id"].ToString(), dr["CLAVECABMS"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["DESCRIPCION"].ToString(),
                                                                                                        dr["MARCA"].ToString(), dr["MODELO"].ToString(), dr["NS"].ToString(), dr["COSTOUNITARIO"].ToString(),
                                                                                                        dr["ESTADOFISICO"].ToString(),
                                                                                                        dr["FECHAALTA"].ToString(), dr["NOMBRE"].ToString(), dr["DONACION"].ToString(), dr["BAJA"].ToString(),
                                                                                                        dr["FECHABAJA"].ToString(), dr["NOTAS"].ToString(), dr["FKUSUARIOS"].ToString(), dr["ETIQUETA"].ToString(),dr["Imagen"].ToString());
                }
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un problema con la consulta del articulo\n" + ex);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            } 
            
            return oArticuloConsulta;


        }

        

        



        /// <summary>
        /// 
        /// </summary>
        /// <param name="caracteristica"></param>
        /// <returns></returns>
        /// BUSQUEDAS DE LISTAS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        public List<Comun.Objeto.ArticuloConsulta> consultaArticulosCabmsYDescripcionXCaracteristica(string caracteristica)
        {
            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();           

            List<Comun.Objeto.ArticuloConsulta> listArticulos = new List<Comun.Objeto.ArticuloConsulta>();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT CLAVECABMS,DESCRIPCION,CLAVEPRESUPUESTAL from ARTICULOS WHERE DESCRIPCION like '%" + caracteristica + "%'";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);
                int rows = ds.Tables[0].Rows.Count - 1;

                for (int i = 0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];

                    Comun.Objeto.ArticuloConsulta oArticulo1 = new Comun.Objeto.ArticuloConsulta(dr["CLAVECABMS"].ToString(), dr["DESCRIPCION"].ToString(),dr["CLAVEPRESUPUESTAL"].ToString());
                    
                    listArticulos.Add(oArticulo1);                    

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

            return listArticulos;
        }

        public List<Comun.Objeto.ArticuloConsulta> consultaArticulosCabmsSimilar(string cabmsSimilar)
        {
            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            

            List<Comun.Objeto.ArticuloConsulta> listArticulos = new List<Comun.Objeto.ArticuloConsulta>();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                //cm.CommandText = "SELECT CLAVECABMS,DESCRIPCION from ARTICULOS WHERE DESCRIPCION like '%" + caracteristica + "%'";
                cm.CommandText = "SELECT ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE CLAVECABMS like '%" + cabmsSimilar + "%';";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);
                int rows = ds.Tables[0].Rows.Count - 1;

                for (int i = 0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];

                    Comun.Objeto.ArticuloConsulta oArticuloConsulta = new Comun.Objeto.ArticuloConsulta(dr["Id"].ToString(), dr["CLAVECABMS"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["DESCRIPCION"].ToString(),
                                                                                                dr["MARCA"].ToString(), dr["MODELO"].ToString(), dr["NS"].ToString(), dr["COSTOUNITARIO"].ToString(),
                                                                                                dr["ESTADOFISICO"].ToString(),
                                                                                                dr["FECHAALTA"].ToString(), dr["NOMBRE"].ToString(), dr["DONACION"].ToString(), dr["BAJA"].ToString(),
                                                                                                dr["FECHABAJA"].ToString(), dr["NOTAS"].ToString(), dr["FKUSUARIOS"].ToString(), dr["ETIQUETA"].ToString(), dr["Imagen"].ToString());

                    listArticulos.Add(oArticuloConsulta);

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

            return listArticulos;
        }


        public List<Comun.Objeto.ArticuloConsulta> consultaArticulosDescripcionSimilar(string descripcionSimilar)
        {
            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();            

            List<Comun.Objeto.ArticuloConsulta> listArticulos = new List<Comun.Objeto.ArticuloConsulta>();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;                
                cm.CommandText = "SELECT ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE DESCRIPCION like '%" + descripcionSimilar + "%';";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);
                int rows = ds.Tables[0].Rows.Count - 1;

                for (int i = 0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];

                    Comun.Objeto.ArticuloConsulta oArticuloConsulta = new Comun.Objeto.ArticuloConsulta(dr["Id"].ToString(), dr["CLAVECABMS"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["DESCRIPCION"].ToString(),
                                                                                                dr["MARCA"].ToString(), dr["MODELO"].ToString(), dr["NS"].ToString(), dr["COSTOUNITARIO"].ToString(),
                                                                                                dr["ESTADOFISICO"].ToString(),
                                                                                                dr["FECHAALTA"].ToString(), dr["NOMBRE"].ToString(), dr["DONACION"].ToString(), dr["BAJA"].ToString(),
                                                                                                dr["FECHABAJA"].ToString(), dr["NOTAS"].ToString(), dr["FKUSUARIOS"].ToString(), dr["ETIQUETA"].ToString(), dr["Imagen"].ToString());

                    listArticulos.Add(oArticuloConsulta);

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

            return listArticulos;
        }


       public List<Comun.Objeto.ArticuloConsulta> consultaArticulosXClavePresupuestal(int clavePresupuestal)
        {
            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();            

            List<Comun.Objeto.ArticuloConsulta> listArticulos = new List<Comun.Objeto.ArticuloConsulta>();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;                
                cm.CommandText = "SELECT ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.CLAVEPRESUPUESTAL="+clavePresupuestal+";";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);
                
                int rows = ds.Tables[0].Rows.Count - 1;

                for (int i = 0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];

                     Comun.Objeto.ArticuloConsulta oArticuloConsulta = new Comun.Objeto.ArticuloConsulta(dr["Id"].ToString(), dr["CLAVECABMS"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["DESCRIPCION"].ToString(),
                                                                                                dr["MARCA"].ToString(), dr["MODELO"].ToString(), dr["NS"].ToString(), dr["COSTOUNITARIO"].ToString(),
                                                                                                dr["ESTADOFISICO"].ToString(),
                                                                                                dr["FECHAALTA"].ToString(),dr["NOMBRE"].ToString(), dr["DONACION"].ToString(), dr["BAJA"].ToString(),
                                                                                                dr["FECHABAJA"].ToString(), dr["NOTAS"].ToString(), dr["FKUSUARIOS"].ToString(), dr["ETIQUETA"].ToString(), dr["Imagen"].ToString());

                     listArticulos.Add(oArticuloConsulta);

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

            return listArticulos;
        }


       public List<Comun.Objeto.ArticuloConsulta> consultaArticulosXUsuario(int fkUsuario)
       {
           DataSet ds = new DataSet();
           SqlCommand cm = new SqlCommand();
           SqlConnection cn = conectarBD();
           List<Comun.Objeto.ArticuloConsulta> listArticulos = new List<Comun.Objeto.ArticuloConsulta>();

           try
           {
               cm.Connection = cn;
               cm.CommandType = CommandType.Text;               
               cm.CommandText = "SELECT ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.FKUSUARIOS =" + fkUsuario + "";
               SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);               
               adaptador.Fill(ds);
               int rows = ds.Tables[0].Rows.Count - 1;

               for (int i = 0; i <= rows; i++)
               {
                   DataRow dr = ds.Tables[0].Rows[i];

                   Comun.Objeto.ArticuloConsulta oArticuloConsulta = new Comun.Objeto.ArticuloConsulta(dr["Id"].ToString(), dr["CLAVECABMS"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["DESCRIPCION"].ToString(),
                                                                                              dr["MARCA"].ToString(), dr["MODELO"].ToString(), dr["NS"].ToString(), dr["COSTOUNITARIO"].ToString(),
                                                                                              dr["ESTADOFISICO"].ToString(),
                                                                                              dr["FECHAALTA"].ToString(), dr["NOMBRE"].ToString(), dr["DONACION"].ToString(), dr["BAJA"].ToString(),
                                                                                              dr["FECHABAJA"].ToString(), dr["NOTAS"].ToString(), dr["FKUSUARIOS"].ToString(), dr["ETIQUETA"].ToString(), dr["Imagen"].ToString());

                   listArticulos.Add(oArticuloConsulta);

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

           return listArticulos;
       }



       public List<Comun.Objeto.ArticuloConsulta> consultaArticulosUltimosDiez()
       {
           DataSet ds = new DataSet();
           SqlCommand cm = new SqlCommand();
           SqlConnection cn = conectarBD();

           List<Comun.Objeto.ArticuloConsulta> listArticulos = new List<Comun.Objeto.ArticuloConsulta>();

           try
           {
               cm.Connection = cn;
               cm.CommandType = CommandType.Text;
               //cm.CommandText = "SELECT ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.CLAVEPRESUPUESTAL=" + clavePresupuestal + ";";
               cm.CommandText = "SELECT TOP 10 ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS ORDER BY  ARTICULOS.Id DESC;";
               //SELECT TOP 10 * FROM ARTICULOS ORDER BY Id DESC
               SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
               adaptador.Fill(ds);
               
               int rows = ds.Tables[0].Rows.Count - 1;

               for (int i = 0; i <= rows; i++)
               {
                   DataRow dr = ds.Tables[0].Rows[i];

                   Comun.Objeto.ArticuloConsulta oArticuloConsulta = new Comun.Objeto.ArticuloConsulta(dr["Id"].ToString(), dr["CLAVECABMS"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["DESCRIPCION"].ToString(),
                                                                                              dr["MARCA"].ToString(), dr["MODELO"].ToString(), dr["NS"].ToString(), dr["COSTOUNITARIO"].ToString(),
                                                                                              dr["ESTADOFISICO"].ToString(),
                                                                                              dr["FECHAALTA"].ToString(), dr["NOMBRE"].ToString(), dr["DONACION"].ToString(), dr["BAJA"].ToString(),
                                                                                              dr["FECHABAJA"].ToString(), dr["NOTAS"].ToString(), dr["FKUSUARIOS"].ToString(), dr["ETIQUETA"].ToString(), dr["Imagen"].ToString());

                   listArticulos.Add(oArticuloConsulta);

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

           return listArticulos;
       }


       public List<Comun.Objeto.ArticuloConsulta> ConsultaArticulosDonacion()
       {

           DataSet ds = new DataSet();
           SqlCommand cm = new SqlCommand();
           SqlConnection cn = conectarBD();

           List<Comun.Objeto.ArticuloConsulta> listArticulos1 = new List<Comun.Objeto.ArticuloConsulta>() ;
           Comun.Objeto.ArticuloConsulta oArticuloConsulta = null;
           //MessageBox.Show("CabmsEnviada:" + claveCabms);
           int rows = 0;

           try
           {
               cm.Connection = cn;
               cm.CommandType = System.Data.CommandType.Text;
               cm.CommandText = "SELECT ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.DONACION=1;";
               SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
               adaptador.Fill(ds);

                rows = ds.Tables[0].Rows.Count - 1;

               for (int i = 0; i <= rows; i++)
               {
                   DataRow dr = ds.Tables[0].Rows[i];

                    oArticuloConsulta = new Comun.Objeto.ArticuloConsulta(dr["Id"].ToString(), dr["CLAVECABMS"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["DESCRIPCION"].ToString(),
                                                                                              dr["MARCA"].ToString(), dr["MODELO"].ToString(), dr["NS"].ToString(), dr["COSTOUNITARIO"].ToString(),
                                                                                              dr["ESTADOFISICO"].ToString(),
                                                                                              dr["FECHAALTA"].ToString(), dr["NOMBRE"].ToString(), dr["DONACION"].ToString(), dr["BAJA"].ToString(),
                                                                                              dr["FECHABAJA"].ToString(), dr["NOTAS"].ToString(), dr["FKUSUARIOS"].ToString(), dr["ETIQUETA"].ToString(), dr["Imagen"].ToString());

                   listArticulos1.Add(oArticuloConsulta);

               }

           }
           catch (SqlException ex)
           {
               MessageBox.Show("Ha ocurrido un problema con la consulta del articulo\n" + ex);
           }
           //catch
           //{

           //}

           finally
           {
               cn.Close();
               cn.Dispose();
           }

           return listArticulos1;
       }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="oArticulo"></param>
        // OTRAS BUSQUEDAS ****************************************************************************************************
        public bool modificarArticulo(Comun.Objeto.Articulo oArticulo)
        {
            SqlConnection cn = conectarBD();
            bool rAfectados = false;
            int ra;

            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                //cm.CommandText = "UPDATE ARTICULOS set CLAVECABMS = '"+oArticulo.ClaveCabms+"',CLAVEPRESUPUESTAL="+oArticulo.ClavePresupuestal+",DESCRIPCION= '"+oArticulo.Descripcion+"', MARCA='"+oArticulo.Marca+"', MODELO='"+oArticulo.Modelo+"', NS='"+oArticulo.NS+"',COSTOUNITARIO= "+oArticulo.CostoUnitario+",ESTADOFISICO= "+oArticulo.EstadoFisicoDelBien+",FECHAALTA= '"+oArticulo.FechaDeAlta+"',DONACION = "+oArticulo.Donacion+",BAJA="+oArticulo.Baja+",FECHABAJA = '"+oArticulo.FechaDeBaja+"',NOTAS='"+oArticulo.Notas+"',FKUSUARIOS="+oArticulo.FkUsuarios+" WHERE Id ="+oArticulo.Id+"";
                cm.CommandText = "UPDATE ARTICULOS set CLAVECABMS = '" + oArticulo.ClaveCabms + "',CLAVEPRESUPUESTAL =" + oArticulo.ClavePresupuestal + ",DESCRIPCION = '" + oArticulo.Descripcion + "', MARCA='" + oArticulo.Marca + "', MODELO='" + oArticulo.Modelo + "', NS='" + oArticulo.NS + "',COSTOUNITARIO= " + oArticulo.CostoUnitario + ",ESTADOFISICO= '" + oArticulo.EstadoFisicoDelBien + "' ,FECHAALTA= @fechaAlta, DONACION= '" + oArticulo.Donacion + "', BAJA='" + oArticulo.Baja + "',FECHABAJA = @fechaBaja, NOTAS='" + oArticulo.Notas + "',FKUSUARIOS=" + oArticulo.FkUsuarios + ",ETIQUETA='" + oArticulo.Etiqueta +"',Imagen='"+oArticulo.NombreImagen+ "' WHERE Id =" + oArticulo.Id + "";

                if (oArticulo.FechaDeAlta == "")
                    cm.Parameters.Add("@fechaAlta", DBNull.Value);
                else
                    cm.Parameters.Add("@fechaAlta", oArticulo.FechaDeAlta);
                if (oArticulo.FechaDeBaja == "")
                    cm.Parameters.Add("@fechaBaja", DBNull.Value);
                else
                    cm.Parameters.Add("@fechaBaja", oArticulo.FechaDeBaja);
                ra = cm.ExecuteNonQuery();

                if (ra >= 1)
                    rAfectados = true;

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar el usuario\n" + ex);
            }

            finally
            { 
                cn.Close();
                cn.Dispose();
            }

            return rAfectados;       

            
        }

        public bool InsertarArticulo(Comun.Objeto.Articulo oArticulo)
        {
            SqlConnection cn = conectarBD();
            bool afectados = false;
            try
            {
                string format = "yyyy-MM-dd";
                //oArticulo.FechaDeAlta.ToString(format);
                SqlCommand cm = new SqlCommand();

                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "insert into ARTICULOS (CLAVECABMS,CLAVEPRESUPUESTAL,DESCRIPCION,MARCA,MODELO,NS,COSTOUNITARIO,ESTADOFISICO,FECHAALTA,DONACION,BAJA,NOTAS,FKUSUARIOS,Etiqueta,Imagen) values ('" + oArticulo.ClaveCabms + "', " + oArticulo.ClavePresupuestal + ", '" + oArticulo.Descripcion + "', '" + oArticulo.Marca + "' ,'" + oArticulo.Modelo + "','" + oArticulo.NS + "'," + oArticulo.CostoUnitario + ",'" + oArticulo.EstadoFisicoDelBien + "',@fechaAlta,'" + oArticulo.Donacion + "','" + oArticulo.Baja + "','" + oArticulo.Notas + "'," + oArticulo.FkUsuarios + ",'" + oArticulo.Etiqueta + "','" + oArticulo.NombreImagen + "')";
                if (oArticulo.FechaDeAlta == "")
                    cm.Parameters.AddWithValue("@fechaAlta", DBNull.Value);
                else
                cm.Parameters.AddWithValue("@fechaAlta", oArticulo.FechaDeAlta);
                
                int ra = cm.ExecuteNonQuery();
                if (ra >= 1)
                {
                    afectados = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return afectados;
            

            
        }

        public int BusquedaDeArticulosxCABMSSimilar(string claveCabms)
        {
            DataSet ds = new DataSet();
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
                cm.CommandText = "SELECT * FROM ARTICULOS where CLAVECABMS like '%" + claveCabms + "%'";
                //cm.CommandText = "SELECT * FROM ARTICULOS where CLAVECABMS like '%I450400028%'";
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.SelectCommand.Parameters.AddWithValue("@claveCabm", claveCabms);


                adaptador.Fill(ds);
                DataRow dr = ds.Tables[0].Rows[0];
                rows = ds.Tables[0].Rows.Count;

                MessageBox.Show("Registros encontrados con esta clave CABMS: " + rows.ToString());

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


        public bool bajaDeArticulo(int id)
        {
            SqlConnection cn = conectarBD();
            bool rAfectados = false;
            int ra;
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                //cm.CommandText = "UPDATE ARTICULOS set CLAVECABMS = '"+oArticulo.ClaveCabms+"',CLAVEPRESUPUESTAL="+oArticulo.ClavePresupuestal+",DESCRIPCION= '"+oArticulo.Descripcion+"', MARCA='"+oArticulo.Marca+"', MODELO='"+oArticulo.Modelo+"', NS='"+oArticulo.NS+"',COSTOUNITARIO= "+oArticulo.CostoUnitario+",ESTADOFISICO= "+oArticulo.EstadoFisicoDelBien+",FECHAALTA= '"+oArticulo.FechaDeAlta+"',DONACION = "+oArticulo.Donacion+",BAJA="+oArticulo.Baja+",FECHABAJA = '"+oArticulo.FechaDeBaja+"',NOTAS='"+oArticulo.Notas+"',FKUSUARIOS="+oArticulo.FkUsuarios+" WHERE Id ="+oArticulo.Id+"";
                cm.CommandText = "UPDATE ARTICULOS set BAJA=1 WHERE Id =" + id + "";
                ra = cm.ExecuteNonQuery();
                if (ra >= 1)
                    rAfectados = true;
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar el usuario\n" + ex);
            }

            finally
            {
                cn.Close();
                cn.Dispose();
            }
            return rAfectados;
        }


        public bool cambioDeResguardatario(int id,int fkPaciente)
        {
            SqlConnection cn = conectarBD();
            bool rAfectados = false;
            int ra;
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                //cm.CommandText = "UPDATE ARTICULOS set CLAVECABMS = '"+oArticulo.ClaveCabms+"',CLAVEPRESUPUESTAL="+oArticulo.ClavePresupuestal+",DESCRIPCION= '"+oArticulo.Descripcion+"', MARCA='"+oArticulo.Marca+"', MODELO='"+oArticulo.Modelo+"', NS='"+oArticulo.NS+"',COSTOUNITARIO= "+oArticulo.CostoUnitario+",ESTADOFISICO= "+oArticulo.EstadoFisicoDelBien+",FECHAALTA= '"+oArticulo.FechaDeAlta+"',DONACION = "+oArticulo.Donacion+",BAJA="+oArticulo.Baja+",FECHABAJA = '"+oArticulo.FechaDeBaja+"',NOTAS='"+oArticulo.Notas+"',FKUSUARIOS="+oArticulo.FkUsuarios+" WHERE Id ="+oArticulo.Id+"";
                cm.CommandText = "UPDATE ARTICULOS set FKUSUARIOS=" + fkPaciente + " WHERE Id =" + id + "";
                ra = cm.ExecuteNonQuery();
                if (ra >= 1)
                    rAfectados = true;
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al Cambiar el  resguardatario\n" + ex);
            }

            finally
            {
                cn.Close();
                cn.Dispose();
            }
            return rAfectados;
        }

        public bool fijarNombreResguardatario(int id,string nombreResguardatario)
        {
            SqlConnection cn = conectarBD();
            bool rAfectados = false;
            int ra;
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                //cm.CommandText = "UPDATE ARTICULOS set CLAVECABMS = '"+oArticulo.ClaveCabms+"',CLAVEPRESUPUESTAL="+oArticulo.ClavePresupuestal+",DESCRIPCION= '"+oArticulo.Descripcion+"', MARCA='"+oArticulo.Marca+"', MODELO='"+oArticulo.Modelo+"', NS='"+oArticulo.NS+"',COSTOUNITARIO= "+oArticulo.CostoUnitario+",ESTADOFISICO= "+oArticulo.EstadoFisicoDelBien+",FECHAALTA= '"+oArticulo.FechaDeAlta+"',DONACION = "+oArticulo.Donacion+",BAJA="+oArticulo.Baja+",FECHABAJA = '"+oArticulo.FechaDeBaja+"',NOTAS='"+oArticulo.Notas+"',FKUSUARIOS="+oArticulo.FkUsuarios+" WHERE Id ="+oArticulo.Id+"";
                cm.CommandText = "UPDATE ARTICULOS set NOMBRERESGUARDATARIO='" + nombreResguardatario + "' WHERE Id =" + id + "";
                ra = cm.ExecuteNonQuery();
                if (ra >= 1)
                    rAfectados = true;
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar el usuario\n" + ex);
            }

            finally
            {
                cn.Close();
                cn.Dispose();
            }
            return rAfectados;
        }

        //public List<Comun.Objeto.ArticuloConsulta> ObtenerResguardatariosVacios()
        //{
        //    DataSet ds = new DataSet();
        //    OleDbCommand cm = new OleDbCommand();
        //    OleDbConnection cn = conectarBD();

        //    List<Comun.Objeto.ArticuloConsulta> listArticulos1 = new List<Comun.Objeto.ArticuloConsulta>();
        //    Comun.Objeto.ArticuloConsulta oArticuloConsulta = null;
        //    //MessageBox.Show("CabmsEnviada:" + claveCabms);
        //    int rows = 0;

        //    try
        //    {
        //        cm.Connection = cn;
        //        cm.CommandType = System.Data.CommandType.Text;
        //        cm.CommandText = "SELECT ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.NOMBRERESGUARDATARIO IS NULL";
        //        OleDbDataAdapter adaptador = new OleDbDataAdapter(cm.CommandText, cn);
        //        adaptador.Fill(ds);

        //        rows = ds.Tables[0].Rows.Count - 1;

        //        for (int i = 0; i <= rows; i++)
        //        {
        //            DataRow dr = ds.Tables[0].Rows[i];

        //            oArticuloConsulta = new Comun.Objeto.ArticuloConsulta(dr["Id"].ToString(), dr["CLAVECABMS"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["DESCRIPCION"].ToString(),
        //                                                                                      dr["MARCA"].ToString(), dr["MODELO"].ToString(), dr["NS"].ToString(), dr["COSTOUNITARIO"].ToString(),
        //                                                                                      dr["ESTADOFISICO"].ToString(),
        //                                                                                      dr["FECHAALTA"].ToString(), dr["NOMBRE"].ToString(), dr["DONACION"].ToString(), dr["BAJA"].ToString(),
        //                                                                                      dr["FECHABAJA"].ToString(), dr["NOTAS"].ToString(), dr["FKUSUARIOS"].ToString(), dr["ETIQUETA"].ToString());

        //            listArticulos1.Add(oArticuloConsulta);

        //        }

        //    }
        //    catch (OleDbException ex)
        //    {
        //        MessageBox.Show("Ha ocurrido un problema con la consulta del articulo\n" + ex);
        //    }
        //    //catch
        //    //{

        //    //}

        //    finally
        //    {
        //        cn.Close();
        //        cn.Dispose();
        //    }

        //    return listArticulos1;
        //}




        public List<Comun.Objeto.ArticulosExport> obtenerArticulosSD()
        {
            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            List<Comun.Objeto.ArticulosExport> listArticulos = new List<Comun.Objeto.ArticulosExport>();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                //cm.CommandText = "SELECT ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.CLAVEPRESUPUESTAL=" + clavePresupuestal + ";";
                //cm.CommandText = "SELECT TOP 10 ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS ORDER BY  ARTICULOS.Id DESC;";
                cm.CommandText = "SELECT  ARTICULOS.CLAVECABMS, ARTICULOS.DESCRIPCION, ARTICULOS.COSTOUNITARIO, ARTICULOS.CLAVEPRESUPUESTAL, USUARIOS.NOMBRE, ARTICULOS.ESTADOFISICO FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.DONACION = 0 and ARTICULOS.BAJA=0";
                //SELECT TOP 10 * FROM ARTICULOS ORDER BY Id DESC
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);

                int rows = ds.Tables[0].Rows.Count - 1;

                for (int i = 0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];

                    Comun.Objeto.ArticulosExport oArticuloConsulta = new Comun.Objeto.ArticulosExport(dr["CLAVECABMS"].ToString(), dr["DESCRIPCION"].ToString(), dr["COSTOUNITARIO"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["NOMBRE"].ToString(), dr["ESTADOFISICO"].ToString());
                    //oArticuloConsulta.ClaveCabms= dr["CLAVECABMS"].ToString();
                    //oArticuloConsulta.Descripcion= dr["DESCRIPCION"].ToString();
                    //oArticuloConsulta.CostoUnitario= dr["COSTOUNITARIO"].ToString();
                    //oArticuloConsulta.ClavePresupuestal= dr["CLAVEPRESUPUESTAL"].ToString();
                    //oArticuloConsulta.NombreDelResguardatario= dr["NOMBRE"].ToString();
                    //oArticuloConsulta.EstadoFisicoDelBien= dr["ESTADOFISICO"].ToString();

                    listArticulos.Add(oArticuloConsulta);

                }




            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un problema al cargar los articulos" + ex);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return listArticulos;
    
        }



        public List<Comun.Objeto.ArticulosExport> obtenerArticulosDonacion()
        {
            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            List<Comun.Objeto.ArticulosExport> listArticulos = new List<Comun.Objeto.ArticulosExport>();

            try
            {
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                //cm.CommandText = "SELECT ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.CLAVEPRESUPUESTAL=" + clavePresupuestal + ";";
                //cm.CommandText = "SELECT TOP 10 ARTICULOS.*, USUARIOS.NOMBRE FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS ORDER BY  ARTICULOS.Id DESC;";
                cm.CommandText = "SELECT  ARTICULOS.CLAVECABMS, ARTICULOS.DESCRIPCION, ARTICULOS.COSTOUNITARIO, ARTICULOS.CLAVEPRESUPUESTAL, USUARIOS.NOMBRE, ARTICULOS.ESTADOFISICO FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.DONACION = 1 AND ARTICULOS.BAJA=0";
                //SELECT TOP 10 * FROM ARTICULOS ORDER BY Id DESC
                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);

                int rows = ds.Tables[0].Rows.Count - 1;

                for (int i = 0; i <= rows; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];

                    Comun.Objeto.ArticulosExport oArticuloConsulta = new Comun.Objeto.ArticulosExport(dr["CLAVECABMS"].ToString(), dr["DESCRIPCION"].ToString(), dr["COSTOUNITARIO"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["NOMBRE"].ToString(), dr["ESTADOFISICO"].ToString());
                    //oArticuloConsulta.ClaveCabms= dr["CLAVECABMS"].ToString();
                    //oArticuloConsulta.Descripcion= dr["DESCRIPCION"].ToString();
                    //oArticuloConsulta.CostoUnitario= dr["COSTOUNITARIO"].ToString();
                    //oArticuloConsulta.ClavePresupuestal= dr["CLAVEPRESUPUESTAL"].ToString();
                    //oArticuloConsulta.NombreDelResguardatario= dr["NOMBRE"].ToString();
                    //oArticuloConsulta.EstadoFisicoDelBien= dr["ESTADOFISICO"].ToString();

                    listArticulos.Add(oArticuloConsulta);

                }




            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un problema al cargar los articulos" + ex);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

            return listArticulos;

        }


        public List<Comun.Objeto.ArticulosExport> obtenerArticulosBaja()
        {

            DataSet ds = new DataSet();
            SqlCommand cm = new SqlCommand();
            SqlConnection cn = conectarBD();
            List<Comun.Objeto.ArticulosExport> listaArticulosConsulta = new List<Comun.Objeto.ArticulosExport>();
            //MessageBox.Show("CabmsEnviada:" + claveCabms);
           

            try
            {
                cm.Connection = cn;
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = "SELECT  ARTICULOS.CLAVECABMS, ARTICULOS.DESCRIPCION, ARTICULOS.COSTOUNITARIO, ARTICULOS.CLAVEPRESUPUESTAL, USUARIOS.NOMBRE, ARTICULOS.ESTADOFISICO FROM USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id = ARTICULOS.FKUSUARIOS WHERE ARTICULOS.BAJA=1";
                //cm.CommandText = "SELECT ARTICULOS.CLAVECABMS, ARTICULOS.CLAVEPRESUPUESTAL, ARTICULOS.DESCRIPCION, ARTICULOS.MARCA, ARTICULOS.MODELO, ARTICULOS.NS, ARTICULOS.COSTOUNITARIO, USUARIOS.NOMBRE, ARTICULOS.ESTADOFISICO, ARTICULOS.FECHAALTA, ARTICULOS.DONACION, ARTICULOS.BAJA, ARTICULOS.FECHABAJA, ARTICULOS.NOTAS,ARTICULOS.Etiqueta, ARTICULOS.Imagen from USUARIOS INNER JOIN ARTICULOS ON USUARIOS.Id =ARTICULOS.FKUSUARIOS  where BAJA = " + true + "";
                //cm.CommandText = "SELECT * FROM ARTICULOS where CLAVECABMS like '%I450400028%'";
                //OleDbDataAdapter adaptador = new OleDbDataAdapter(cm.CommandText, cn);

                SqlDataAdapter adaptador = new SqlDataAdapter(cm.CommandText, cn);
                adaptador.Fill(ds);

                int filas = ds.Tables[0].Rows.Count - 1;

                for (int i = 0; i <= filas; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    Comun.Objeto.ArticulosExport oArticuloConsulta = new Comun.Objeto.ArticulosExport(dr["CLAVECABMS"].ToString(), dr["DESCRIPCION"].ToString(), dr["COSTOUNITARIO"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(), dr["NOMBRE"].ToString(), dr["ESTADOFISICO"].ToString());

                    //Comun.Objeto.ArticuloConsulta oArticuloConsulta = new Comun.Objeto.ArticuloConsulta(
                    //dr["Id"].ToString(), dr["CLAVECABMS"].ToString(), dr["CLAVEPRESUPUESTAL"].ToString(),
                    //dr["DESCRIPCION"].ToString(),dr["MARCA"].ToString(), dr["MODELO"].ToString(), dr["NS"].ToString(), 
                    //dr["COSTOUNITARIO"].ToString(), dr["ESTADOFISICO"].ToString(), dr["FECHAALTA"].ToString(),
                    //dr["NOMBRE"].ToString(), dr["DONACION"].ToString(), dr["BAJA"].ToString(), dr["FECHABAJA"].ToString(),
                    //dr["NOTAS"].ToString(), dr["FKUSUARIOS"].ToString(), dr["Etiqueta"].ToString(), dr["Imagen"].ToString());


                    listaArticulosConsulta.Add(oArticuloConsulta);

                }

                

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

            return listaArticulosConsulta;
        }
    }

}
