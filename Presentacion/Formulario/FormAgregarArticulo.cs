 
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
    public partial class FormAgregarArticulo : Form
    {
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }

        private void FormAgregarArticulo_Load(object sender, EventArgs e)
        {
            Logica.LUsuario LogicaUsuarios = new Logica.LUsuario();

            cboResguardatario.DataSource = LogicaUsuarios.obtenerListaUsuarios(); ;
            cboResguardatario.DisplayMember = "NOMBRE";
            cboResguardatario.ValueMember = "Id";
            cboResguardatario.SelectedIndex = -1;

            txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");

            
        }

        private void btnInsertarArticulo_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txtClaveCabms.Text != "") && (txtClavePresupuestal.Text != "") && (txtDescripcion.Text != "") && (txtCostoUnitario.Text != "") && (cboEstadoFisico.SelectedItem.ToString() != "") && (cboResguardatario.SelectedItem.ToString() != ""))
                {
                    Comun.Objeto.Articulo oArticulo = new Comun.Objeto.Articulo();

                    Convert.ToInt32(txtClavePresupuestal.Text.ToString());
                    oArticulo.ClavePresupuestal = int.Parse(txtClavePresupuestal.Text);
                    oArticulo.CostoUnitario = double.Parse(txtCostoUnitario.Text);
                    oArticulo.FkUsuarios = int.Parse(cboResguardatario.SelectedValue.ToString());
                    oArticulo.EstadoFisicoDelBien = cboEstadoFisico.SelectedItem.ToString();
                    oArticulo.ClaveCabms = txtClaveCabms.Text;
                    oArticulo.Descripcion = txtDescripcion.Text.ToUpper();
                    oArticulo.Marca = txtMarca.Text.ToUpper();
                    oArticulo.Modelo = txtModelo.Text.ToUpper();
                    oArticulo.NS = txtNS.Text;

                    if(txtFecha.Text=="")
                    { oArticulo.FechaDeAlta = ""; }
                    else {oArticulo.FechaDeAlta= Convert.ToDateTime(txtFecha.Text).ToString("yyyy/MM/dd"); }

                    //oArticulo.FechaDeAlta = string.Format("{0:yyyy/MM/dd}",txtFecha.Text);
                    if (rbDonacionSi.Checked) oArticulo.Donacion = true; else oArticulo.Donacion = false;
                    oArticulo.Baja = false;
                    oArticulo.Notas = txtNotas.Text.ToUpper();
                    oArticulo.NombreImagen = txtNombreImagen.Text;
                    Logica.LArticulo LArticulo = new Logica.LArticulo();
                    //LArticulo.insertarArticulo(oArticulo);
                    if (LArticulo.insertarArticulo(oArticulo) == true)
                    {
                        MessageBox.Show("Artículo ingresado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }                         
                    else
                        MessageBox.Show("Error al ingresar el artículo:\nVerifica que no haya articulos ya ingresados con esa clave CABMS","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    MessageBox.Show("Faltan datos a ingresar antes de dar de alta el artículo","Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Existen datos erroneos en el formulario ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtClaveCabms_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtClaveCabms_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string cadenaCabmsCompleta = txtClaveCabms.Text;
            //string colorRojo = cadenaCabmsCompleta.Substring(1, 10);
            //colorRojo = Color.Yellow;
            //txtClaveCabms.Text = colorRojo + "01";
        }

        private void btnSelecImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.AutoUpgradeEnabled = false;
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNombreImagen.Text = buscar.SafeFileName;
                pbImagen.ImageLocation = @"C:\INVCEMISAM\imagenes\" + txtNombreImagen.Text;
            }
            else
            {
            }
        }

        private void btnSinImagen_Click(object sender, EventArgs e)
        {
            txtNombreImagen.Text = "";
            pbImagen.ImageLocation = txtNombreImagen.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        public void limpiarControlesAgregarArticulo()
        {
            txtClaveCabms.Text = "";
            txtClavePresupuestal.Text = "";
            txtCostoUnitario.Text = "";
            txtDescripcion.Text = "";
            cboEstadoFisico.SelectedIndex= -1;
            cboResguardatario.SelectedIndex = -1;
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtNS.Text = "";
            txtFecha.Text = "";
            txtNotas.Text = "";
            rbDonacionNo.Checked = true;
            txtNombreImagen.Text = "";
        }

        private void dtpFechaAlta_ValueChanged(object sender, EventArgs e)
        {
            txtFecha.Text = dtpFechaAlta.Value.Date.ToShortDateString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
