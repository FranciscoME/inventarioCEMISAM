
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Logica
{
    public class LArticulo
    {

        public Comun.Objeto.ArticuloConsulta ObtenerArticuloxCABMS(string claveCabms)
        {
            AccesoADatos.Consulta.ConsultaAArticulos consultaArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            AccesoADatos.Consulta.ClientesConsulta CC = new AccesoADatos.Consulta.ClientesConsulta();
            Comun.Objeto.ArticuloConsulta ConsultaArticulo;
            

            ConsultaArticulo = consultaArticulos.ObtenerArticuloxCABMS(claveCabms);
            //ConsultaArticulo.NombreDelResguardatario = CC.ObtenerNombreUsuario(int.Parse(ConsultaArticulo.FkUsuarios));

            return ConsultaArticulo;

        }
        
        public List<Comun.Objeto.ArticuloConsulta> ObtenerLArticuloxCABMS(string claveCabms)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();            
            Comun.Objeto.ArticuloConsulta ConsultaArticulo;
            List<Comun.Objeto.ArticuloConsulta> listac = new List<Comun.Objeto.ArticuloConsulta>();
            ConsultaArticulo = CADArticulos.ObtenerArticuloxCABMS(claveCabms);
            

            listac.Add(ConsultaArticulo);
            return listac;

        }        
        

        public bool modificarArticulo(Comun.Objeto.Articulo oArticulo)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.modificarArticulo(oArticulo);
        }

        public int BusquedaDeArticulosxCABMSSimilar(string claveCabms)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.BusquedaDeArticulosxCABMSSimilar(claveCabms);
        }

        public List<Comun.Objeto.ArticuloConsulta> consultaArticulosCabmsYDescripcionXCaracteristica(string caracteristica)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.consultaArticulosCabmsYDescripcionXCaracteristica(caracteristica);
        }

        
        public bool insertarArticulo(Comun.Objeto.Articulo oArticulo)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.InsertarArticulo(oArticulo);
        }




        public List<Comun.Objeto.ArticuloConsulta> consultaArticulosXClavePresupuestal(int clavePresupuestal)
        {
            
            List<Comun.Objeto.ArticuloConsulta> listac = new List<Comun.Objeto.ArticuloConsulta>();
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.consultaArticulosXClavePresupuestal(clavePresupuestal);

        }


        public List<Comun.Objeto.ArticuloConsulta> consultaArticulosCabmsSimilar(string cabmsSimilar)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.consultaArticulosCabmsSimilar(cabmsSimilar);
        }


        public List<Comun.Objeto.ArticuloConsulta> consultaArticulosDescripcionSimilar(string descripcionSimilar)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.consultaArticulosDescripcionSimilar(descripcionSimilar);
        }

        public List<Comun.Objeto.ArticuloConsulta> consultaArticulosXUsuario(int fkUsuario)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.consultaArticulosXUsuario(fkUsuario);
        }

        public virtual List<Comun.Objeto.ArticuloConsulta> consultaArticulosUltimosDiez()
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.consultaArticulosUltimosDiez();
        }

        public List<Comun.Objeto.ArticuloConsulta> ConsultaArticulosDonacion()
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.ConsultaArticulosDonacion();
        }

        //public List<Comun.Objeto.ArticuloConsulta> obtenerResgurdatariosVacios()
        //{
        //    AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
        //    return CADArticulos.ObtenerResguardatariosVacios();
        //}


        public bool bajaDeArticulo(int id)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.bajaDeArticulo(id);
        }

        public bool cambioDeResguardatario(int id, int fkUsuario)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.cambioDeResguardatario(id,fkUsuario);
        }

        public bool fijarNombreResguardatario(int id, string nombreResguardatario)
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.fijarNombreResguardatario(id, nombreResguardatario);
        }

        public List<Comun.Objeto.ArticulosExport> obtenerArticulosSD()
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADAArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADAArticulos.obtenerArticulosSD();
        }

        public List<Comun.Objeto.ArticulosExport> obtenerArticulosDonacion()
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADAArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADAArticulos.obtenerArticulosDonacion();
        }

        public List<Comun.Objeto.ArticulosExport> obtenerArticulosBaja()
        {
            AccesoADatos.Consulta.ConsultaAArticulos CADArticulos = new AccesoADatos.Consulta.ConsultaAArticulos();
            return CADArticulos.obtenerArticulosBaja();
        }

        public void ExportarExcel(System.Windows.Forms.DataGridView dgvSD,System.Windows.Forms.DataGridView dgvDonacion, SaveFileDialog sd)
        {
            try
            {
                                            
                
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo2;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    hoja_trabajo2 =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(2);
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dgvSD.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvSD.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = dgvSD.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    for (int i = 0; i < dgvDonacion.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvDonacion.Columns.Count; j++)
                        {

                            hoja_trabajo2.Cells[i + 1, j + 1] = dgvDonacion.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    libros_trabajo.SaveAs(sd.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Se ha generado el archivo en el directorio seleccionado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error:/n" + ex);
            }
            
           
        }



        public void ExportarExcel(System.Windows.Forms.DataGridView dgvSD)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Reporte " + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year;
                fichero.AutoUpgradeEnabled = false;
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                   
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dgvSD.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvSD.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = dgvSD.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Se ha generado el archivo en el directorio seleccionado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:/n" + ex);
            }


        }
    }
}
