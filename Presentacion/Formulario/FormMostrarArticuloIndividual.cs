
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Formulario
{
    public partial class FormMostrarArticuloIndividual : Form
    {
        public FormMostrarArticuloIndividual()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiarybloquearControles();
            buscarArticuloIndividual();
            
        }


        private void btnHaabilitarCampos_Click(object sender, EventArgs e)
        {
            desbloquearControles();
        }

        private void lblBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Comun.Objeto.Articulo oArticulo = new Comun.Objeto.Articulo();

            try
            {
                oArticulo.FkUsuarios = int.Parse(cboResguardatario.SelectedValue.ToString());
            }
            catch
            {
                oArticulo.FkUsuarios = int.Parse(lblIdUsuario.Text);
            }

            try
            {
                oArticulo.Id = int.Parse(lblIdArticulo.Text);
                oArticulo.ClavePresupuestal = int.Parse(txtClavePresupuestal.Text);
                oArticulo.CostoUnitario = double.Parse(txtCostoUnitario.Text);
                oArticulo.ClaveCabms = txtClaveCabms.Text;

                oArticulo.Descripcion = txtDescripcion.Text.ToUpper();
                oArticulo.Marca = txtMarca.Text.ToUpper();
                oArticulo.Modelo = txtModelo.Text.ToUpper();
                oArticulo.NS = txtNS.Text.ToUpper();
                oArticulo.EstadoFisicoDelBien = txtEstadoFisico.Text.ToUpper();
                if (txtFechaAlta.Text == "")
                { oArticulo.FechaDeAlta = ""; }
                else { oArticulo.FechaDeAlta = Convert.ToDateTime(txtFechaAlta.Text).ToString("yyyy/MM/dd"); }
                if (rbDonacionSi.Checked) oArticulo.Donacion = true; else oArticulo.Donacion = false;
                if (rbBajaSi.Checked) oArticulo.Baja = true; else oArticulo.Baja = false;
                if (rbEtiquetaSi.Checked) oArticulo.Etiqueta = true; else oArticulo.Etiqueta = false;
                if ( txtFechaBaja.Text == "")
                { oArticulo.FechaDeBaja = ""; }
                else { oArticulo.FechaDeBaja = Convert.ToDateTime(txtFechaBaja.Text).ToString("yyyy/MM/dd"); }
                
                oArticulo.Notas = txtNotas.Text.ToUpper();
                if (rbEtiquetaSi.Checked) oArticulo.Etiqueta = true; else oArticulo.Etiqueta = false;
                oArticulo.NombreImagen = txtNombreImagen.Text;

                Logica.LArticulo LUsuario = new Logica.LArticulo();

                bool filasAfectadas = LUsuario.modificarArticulo(oArticulo);
                if (filasAfectadas == true)
                { MessageBox.Show("Artículo modificado satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Dispose(); }
                else { MessageBox.Show("Error al modificar el registro","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            catch
            {
                MessageBox.Show("Se han introducido datos no validos ","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }


        }

        private void txtIntClaveCabms_Enter(object sender, EventArgs e)
        {
            //buscarIndividual();
        }



        public void buscarArticuloIndividual()
        {
            Logica.LUsuario lUsuarioConsulta = new Logica.LUsuario();
            Logica.LArticulo lArticuloConsulta = new Logica.LArticulo();
            Comun.Objeto.ArticuloConsulta articulo;
            Comun.Objeto.Usuario usuario;
            articulo = lArticuloConsulta.ObtenerArticuloxCABMS(txtIntClaveCabms.Text);
            //articulo = lArticuloConsulta.ObtenerArticuloxCABMS(txtIntClaveCabms.Text);

            if (articulo == null)
                MessageBox.Show("No se ha encontrado ningun articulo con esta clave CABMS");
            else
            {
                txtClaveCabms.Text = articulo.ClaveCabms;
                txtClavePresupuestal.Text = articulo.ClavePresupuestal;
                txtDescripcion.Text = articulo.Descripcion;
                txtCostoUnitario.Text = articulo.CostoUnitario;
                txtEstadoFisico.Text = articulo.EstadoFisicoDelBien;
                txtMarca.Text = articulo.Marca;
                txtModelo.Text = articulo.Modelo;
                txtNS.Text = articulo.NS;
                lblIdArticulo.Text = articulo.ID;
                lblIdUsuario.Text = articulo.FkUsuarios;
                txtNotas.Text = articulo.Notas;
                string fileNameImage = articulo.NombreImagen;
                if (articulo.FechaDeAlta != "")
                    txtFechaAlta.Text = DateTime.Parse(articulo.FechaDeAlta.ToString()).ToString("dd/MM/yyyy");
                if (articulo.FechaDeBaja != "")
                    txtFechaBaja.Text = DateTime.Parse(articulo.FechaDeBaja.ToString()).ToString("dd/MM/yyyy");

                usuario = lUsuarioConsulta.obtenerUsuario(int.Parse(lblIdUsuario.Text));                
                cboResguardatario.Text = usuario.Nombre.ToString();
                //cboResguardatario.ValueMember = usuario.ID.ToString();

                if (articulo.Donacion == "True")
                { rbDonacionSi.Checked = true; }
                else { rbDonacionNo.Checked = true; }

                if (articulo.Baja == "True")
                { rbBajaSi.Checked = true; }
                else { rbBajaNo.Checked = true; }

                if (articulo.Etiqueta == "True")
                { rbEtiquetaSi.Checked = true; }
                else { rbEtiquetaNo.Checked = true; }

                btnHaabilitarCampos.Enabled = true;
                btnHaabilitarCampos.BackColor = Color.Orange;
                btnModificarArticulo.Enabled = true;
                btnModificarArticulo.BackColor = Color.FromArgb(128, 128, 255);

                this.txtIntClaveCabms.Text = "";
                this.txtIntClaveCabms.Focus();

                txtNombreImagen.Text = articulo.NombreImagen;
                System.IO.FileInfo fi = new System.IO.FileInfo(@"C:\INVCEMISAM\imagenes\" + fileNameImage);
                
                fileNameImage = fi.Directory + @"\" + fi.Name;
                pbImagen.ImageLocation = fileNameImage;

            }




        }

        private void txtIntClaveCabms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscarArticuloIndividual();
            }
        }

        private void FormMostrarArticuloIndividual_Load(object sender, EventArgs e)
        {

            limpiarybloquearControles();
            this.Show();
            txtIntClaveCabms.Focus();

        }

        private void cboResguardatario_Click(object sender, EventArgs e)
        {
            Logica.LUsuario CLUsuario = new Logica.LUsuario();
            cboResguardatario.DataSource = CLUsuario.obtenerListaUsuarios(); ;
            cboResguardatario.DisplayMember = "NOMBRE";
            cboResguardatario.ValueMember = "Id";
        }

        public void limpiarybloquearControles()
        {
            txtClaveCabms.Text = "";
            txtClaveCabms.Enabled = false;
            txtClavePresupuestal.Text = "";
            txtClavePresupuestal.Enabled = false;
            txtCostoUnitario.Text = "";
            txtCostoUnitario.Enabled = false;
            txtEstadoFisico.Text = "";
            txtEstadoFisico.Enabled = false;
            txtDescripcion.Text = "";
            txtDescripcion.Enabled = false;
            cboResguardatario.Text = "";
            cboResguardatario.Enabled = false;
            txtMarca.Text = "";
            txtMarca.Enabled = false;
            txtModelo.Text = "";
            txtModelo.Enabled = false;
            txtNS.Text = "";
            txtNS.Enabled = false;
            txtFechaAlta.Text = "";            
            txtFechaAlta.Enabled = false;
            dtpFechaAlta.Visible = false;
            txtFechaBaja.Text = "";
            txtFechaBaja.Enabled = false;
            dtpFechaBaja.Visible = false;
            txtNotas.Text = "";
            txtNotas.Enabled = false;

            rbDonacionSi.Enabled = false;
            rbDonacionNo.Enabled = false;
            rbBajaSi.Enabled = false;
            rbBajaNo.Enabled = false;
            rbEtiquetaSi.Enabled = false;
            rbEtiquetaNo.Enabled = false;

            btnHaabilitarCampos.BackColor = Color.Gray;
            btnHaabilitarCampos.Enabled = false;
            btnModificarArticulo.BackColor = Color.Gray;
            btnModificarArticulo.Enabled = false;
            
            btnModificarArticulo.Enabled = false;
            btnSelecImagen.Enabled = false;
            btnSinImagen.Enabled = false;
            txtNombreImagen.Enabled = false;
            pbImagen.Image = null;
            txtIntClaveCabms.Focus();
            
        }

        public void desbloquearControles()
        {

            txtClaveCabms.Enabled = true;
            txtClavePresupuestal.Enabled = true;
            txtCostoUnitario.Enabled = true;
            txtEstadoFisico.Enabled = true;
            txtDescripcion.Enabled = true;
            cboResguardatario.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtNS.Enabled = true;
            txtFechaAlta.Enabled = true;
            dtpFechaAlta.Visible = true;
            txtFechaBaja.Enabled = true;
            dtpFechaBaja.Visible = true;
            txtNotas.Enabled = true;
            rbDonacionSi.Enabled = true;
            rbDonacionNo.Enabled = true;
            rbBajaSi.Enabled = true;
            rbBajaNo.Enabled = true;
            rbEtiquetaSi.Enabled = true;
            rbEtiquetaNo.Enabled = true;
            btnModificarArticulo.Enabled = true;
            txtNombreImagen.Enabled = true;
            btnSelecImagen.Enabled = true;
            btnSinImagen.Enabled = true;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSelecImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            try
            {

                buscar.Filter = "Archivos JPEG(*.jpg)|*.jpg";
                buscar.InitialDirectory = @"C:\INVCEMISAM\imagenes\";
                buscar.AutoUpgradeEnabled = false;
                if (buscar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtNombreImagen.Text = buscar.SafeFileName;
                    Bitmap bm = new Bitmap(@"C:\INVCEMISAM\imagenes\" + txtNombreImagen.Text);
                    pbImagen.Image = (Image)bm;
                }
                else if (buscar.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar la imagen:\n"+ex+"","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                buscar.Reset();
                buscar.Dispose();
            }

        }

        private void btnSinImagen_Click(object sender, EventArgs e)
        {
            txtNombreImagen.Text = "";
            pbImagen.ImageLocation = txtNombreImagen.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtFechaBaja.Text = dtpFechaBaja.Value.Date.ToShortDateString();
        }

        private void dtpFechaAlta_ValueChanged(object sender, EventArgs e)
        {
            txtFechaAlta.Text = dtpFechaAlta.Value.Date.ToShortDateString();
        }
    }
}
