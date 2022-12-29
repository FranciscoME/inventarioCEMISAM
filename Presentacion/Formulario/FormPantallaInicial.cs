
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
    public partial class FormPantallaInicial : Form
    {
        public FormPantallaInicial()
        {
            InitializeComponent();
            numeroDeArticulosDonacion();
            numeroDeArticulosBaja();
            costoTotalBienes();
            //mostrarUltimosDiez();
        }

        private void FormPantallaInicial_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            numeroDeArticulos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void numeroDeArticulos()
        { 
            Logica.LCalculosArticulos CLAT = new Logica.LCalculosArticulos();
            lblArticulosTotales.Text = CLAT.NumeroDeArticulos().ToString();
        }

        private void numeroDeArticulosDonacion()
        {
            Logica.LCalculosArticulos CLAT = new Logica.LCalculosArticulos();
            lblNumDonacion.Text = CLAT.ArticulosDonacion().ToString();
        }

        private void numeroDeArticulosBaja()
        {
            Logica.LCalculosArticulos CLAT = new Logica.LCalculosArticulos();
            lblArticulosBaja.Text = CLAT.ArticulosBaja().ToString();
        }

        private void costoTotalBienes()
        {
            Logica.LCalculosArticulos CLAT = new Logica.LCalculosArticulos();
            //lblCostoTotalDeBienes.Text = CLAT.costoTotalBienes().ToString();
            //lblCostoTotalDeBienes.Text = string.Format(,);
            lblCostoTotalDeBienes.Text = String.Format("{0:c}", CLAT.costoTotalBienes());
        }

        //private void mostrarUltimosDiez()
        //{
        //    dgvUltimosDiezArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        //    Logica.LArticulo CLArticulos = new Logica.LArticulo();
        //    dgvUltimosDiezArticulos.DataSource = CLArticulos.consultaArticulosUltimosDiez();
        //}

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software elaborado exclusivamente para el Centro Michoacano de Salud Mental\nPor el L.I. Francisco Márquez Estrada");
            Application.Exit();
        }

        //private void ExportarExcel()
        //{
        //    Logica.LArticulo CLArticulos = new Logica.LArticulo();
        //    CLArticulos.ExportarExcel(dgvUltimosDiezArticulos);
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ExportarExcel();
        //}
    }
}
