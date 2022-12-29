 
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
    public partial class formBusquedas : Form
    {
        public formBusquedas()
        {
            InitializeComponent();
        }

        private void btnBuscarxClaveCabms_Click(object sender, EventArgs e)
        {
            if (txtClaveCabms.Text != "")
            {
                buscarXClaveCabms();
            }
            else
            {
                MessageBox.Show("Favor de ingresar la clave CABMS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarXClavePresupuestal_Click(object sender, EventArgs e)
        {
            if (txtclavePresupuestal.Text != "")
            {
                buscarXClavePresupuestal();
            }
            else
            {
                MessageBox.Show("Favor de introducir una clave presupuestal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void btnSCABMS_Click(object sender, EventArgs e)
        {
            if (txtCabmsSimilar.Text != "")
            {
                BusquedaCabmsSimilar();
            }
            else
            {
                MessageBox.Show("Favor de ingresar algunos digitos de la clave CABMS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnBuscarXDescripcion_Click(object sender, EventArgs e)
        {
            if (txtDescripcionDelProducto.Text != "")
            {
                buscarXDescripcion();
            }
            else
            {
                MessageBox.Show("Favor de ingresar alguna descripcion del artículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            
        }

        private void cboResguardatario_Click(object sender, EventArgs e)
        {
            Logica.LUsuario CLUsuario = new Logica.LUsuario();
            cboResguardatario.DataSource = CLUsuario.obtenerListaUsuarios(); ;
            cboResguardatario.DisplayMember = "NOMBRE";
            cboResguardatario.ValueMember = "Id";
        }

        private void cboResguardatario_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboResguardatario_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarXUsuario_Click(object sender, EventArgs e)
        {

            if (cboResguardatario.Text != "")
            {
                dgvBusquedaXUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Logica.LArticulo CLArticulo = new Logica.LArticulo();
                dgvBusquedaXUsuario.DataSource = CLArticulo.consultaArticulosXUsuario(int.Parse(cboResguardatario.SelectedValue.ToString()));
                lblResponsable.Text = cboResguardatario.SelectedValue.ToString();
                btnMostrarResguardo.Visible = true;
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
    
            try
            {
                FormMostrarArticuloIndividual frmArticuloIndividual = new FormMostrarArticuloIndividual();
                int row = int.Parse(dgvBusquedaClaveCabms.CurrentCell.Value.ToString());
                frmArticuloIndividual.txtIntClaveCabms.Text = dgvBusquedaClaveCabms[1, 0].FormattedValue.ToString();
                frmArticuloIndividual.Show();
                frmArticuloIndividual.txtIntClaveCabms.Focus();
            }
            catch
            {
                MessageBox.Show("Ha seleccionado un elemento no valido");
            }
        }

        private void btnModificarXClavePresupuestal_Click(object sender, EventArgs e)
        {
            try
            {
                FormMostrarArticuloIndividual frmArticuloIndividual = new FormMostrarArticuloIndividual();
                int row = int.Parse(dgvBusquedaClavePresupuestal.CurrentCell.RowIndex.ToString());                
                frmArticuloIndividual.txtIntClaveCabms.Text = dgvBusquedaClavePresupuestal["ClaveCabms", row].Value.ToString();
                frmArticuloIndividual.Show();
                frmArticuloIndividual.txtIntClaveCabms.Focus();
            }
            catch
            {
                MessageBox.Show("Ha seleccionado un elemento no valido");
            }
        }

        private void btnModificarXCabmsSimilar_Click(object sender, EventArgs e)
        {
            try
            {
                FormMostrarArticuloIndividual frmArticuloIndividual = new FormMostrarArticuloIndividual();
                int row = int.Parse(dgvBusquedaCabmsSimilar.CurrentCell.RowIndex.ToString());
                frmArticuloIndividual.txtIntClaveCabms.Text = dgvBusquedaCabmsSimilar["ClaveCabms", row].Value.ToString();
                frmArticuloIndividual.Show();
                frmArticuloIndividual.txtIntClaveCabms.Focus();
            }
            catch
            {
                MessageBox.Show("Ha seleccionado un elemento no valido");
            }
        }

        private void btnModificarXDescripcionArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                FormMostrarArticuloIndividual frmArticuloIndividual = new FormMostrarArticuloIndividual();
                int row = int.Parse(dgvBusuquedaPorDescripcionDelArticulo.CurrentCell.RowIndex.ToString());
                frmArticuloIndividual.txtIntClaveCabms.Text = dgvBusuquedaPorDescripcionDelArticulo["ClaveCabms", row].Value.ToString();
                frmArticuloIndividual.Show();
                frmArticuloIndividual.txtIntClaveCabms.Focus();
            }
            catch
            {
                MessageBox.Show("Ha seleccionado un elemento no valido");
            }
        }

        private void btnModificarXUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                FormMostrarArticuloIndividual frmArticuloIndividual = new FormMostrarArticuloIndividual();
                int row = int.Parse(dgvBusquedaXUsuario.CurrentCell.RowIndex.ToString());
                frmArticuloIndividual.txtIntClaveCabms.Text = dgvBusquedaXUsuario["ClaveCabms", row].Value.ToString();
                frmArticuloIndividual.Show();
                frmArticuloIndividual.txtIntClaveCabms.Focus();
            }
            catch
            {
                MessageBox.Show("Ha seleccionado un elemento no valido");
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void formBusquedas_Load(object sender, EventArgs e)
        {
           
        }

        private void btnMostrarArticulosDonacion_Click(object sender, EventArgs e)
        {
            dgvArticulosDonacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Logica.LArticulo CLArticulo = new Logica.LArticulo();            
            dgvArticulosDonacion.DataSource = CLArticulo.ConsultaArticulosDonacion();
        }

        private void txtDescripcionDelProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscarXDescripcion();
            }
        }

        private void buscarXDescripcion()
        {
            dgvBusuquedaPorDescripcionDelArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Logica.LArticulo CLArticulo = new Logica.LArticulo();
            dgvBusuquedaPorDescripcionDelArticulo.DataSource = CLArticulo.consultaArticulosDescripcionSimilar(txtDescripcionDelProducto.Text);
            //DataGridViewButtonColumn cbnt = new DataGridViewButtonColumn();
            //dgvBusuquedaPorDescripcionDelArticulo.Columns.Add(cbnt);
            //cbnt.HeaderText = "Acceder";
            //cbnt.Name = "btnModificar";
            //cbnt.Text = "Modificar";
            //cbnt.UseColumnTextForButtonValue = true;
            //dgvBusuquedaPorDescripcionDelArticulo.Columns["btnModificar"].DisplayIndex = 0;
        }

        private void BusquedaCabmsSimilar()
        {
            dgvBusquedaCabmsSimilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Logica.LArticulo CLArticulo = new Logica.LArticulo();
            dgvBusquedaCabmsSimilar.DataSource = CLArticulo.consultaArticulosCabmsSimilar(txtCabmsSimilar.Text);
        }

        private void buscarXClaveCabms()
        {
            dgvBusquedaClaveCabms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Logica.LArticulo CLArticulo = new Logica.LArticulo();
            dgvBusquedaClaveCabms.DataSource = CLArticulo.ObtenerLArticuloxCABMS(txtClaveCabms.Text);
            txtClaveCabms.Text = "";
            txtClaveCabms.Focus();
        }

        private void buscarXClavePresupuestal()
        {
            dgvBusquedaClavePresupuestal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Logica.LArticulo CLArticulo = new Logica.LArticulo();
            dgvBusquedaClavePresupuestal.DataSource = CLArticulo.consultaArticulosXClavePresupuestal(int.Parse(txtclavePresupuestal.Text));
        }

        private void txtCabmsSimilar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BusquedaCabmsSimilar();
            }
        }

        private void txtClaveCabms_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscarXClaveCabms();
            }            
        }

        private void txtclavePresupuestal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscarXClavePresupuestal();
            }  
        }

        private void btnModificarXDonacion_Click(object sender, EventArgs e)
        {
            try
            {
                FormMostrarArticuloIndividual frmArticuloIndividual = new FormMostrarArticuloIndividual();
                int row = int.Parse(dgvArticulosDonacion.CurrentCell.RowIndex.ToString());
                frmArticuloIndividual.txtIntClaveCabms.Text = dgvArticulosDonacion["ClaveCabms", row].Value.ToString();
                frmArticuloIndividual.Show();
                frmArticuloIndividual.txtIntClaveCabms.Focus();
            }
            catch
            {
                MessageBox.Show("Ha seleccionado un elemento no valido");
            }
        }

        private void dgvBusuquedaPorDescripcionDelArticulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 17)
            {
                MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
            }
        }

        private void btnMostrarResguardo_Click(object sender, EventArgs e)
        {
            if (cboResguardatario.Text != "")
            {
                formResguardo frmResguardo = new formResguardo();
                frmResguardo.IdResponsable = lblResponsable.Text;
                frmResguardo.Show();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar primero a un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
