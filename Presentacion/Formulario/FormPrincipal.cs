
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void busquedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBusquedas frmB = new formBusquedas();
            frmB.MdiParent = this;
            frmB.Show();
        }

        private void agregarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarDepartamento frmAD = new FormAgregarDepartamento();
            frmAD.Show();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario frmAU = new FormAgregarUsuario();
            frmAU.Show();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarUsuario frmMU = new FormModificarUsuario();
            frmMU.Show();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarUsuario frmEU = new FormEliminarUsuario();
            frmEU.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormPantallaInicial frmPI = new FormPantallaInicial();
            frmPI.MdiParent = this;
            frmPI.Show();
        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarArticuloIndividual frmMAI = new FormMostrarArticuloIndividual();
            //frmMAI.MdiParent = this;
            frmMAI.Show();
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscarClaveCabms frmAgregarArticulo = new FormBuscarClaveCabms();
            frmAgregarArticulo.MdiParent = this;
            frmAgregarArticulo.Show();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nuevaBusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVariosArticulosBaja frmAB = new FormVariosArticulosBaja();
            frmAB.Show();
        }

        private void cambioDeResguardatarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVariosArticulosCResguardatario frmVACR = new FormVariosArticulosCResguardatario();
            frmVACR.Show();
        }

        private void fijarNombresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExportarExcel frmEAE = new FormExportarExcel();
            frmEAE.Show();
        }

        private void exportarBajasAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExportarExcelBajas frmEEB = new FormExportarExcelBajas();
            frmEEB.Show();
        }

        private void resguardosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formResguardo frmResguardo = new formResguardo();
            frmResguardo.Show();
        }
    }
}
