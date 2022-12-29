
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
    public partial class FormVariosArticulosCResguardatario : Form
    {
        Comun.Objeto.ArticuloConsulta oArticulo = null;
        public FormVariosArticulosCResguardatario()
        {
            InitializeComponent();
        }

        private void FormVariosArticulosCResguardatario_Load(object sender, EventArgs e)
        {
            dgvArticulos.Columns.Add("Num", "Num");
            dgvArticulos.Columns.Add("Id", "Id");
            dgvArticulos.Columns.Add("ClaveCabms", "Clave CABMS");
            dgvArticulos.Columns.Add("Descripcion", "Descripcion");
            dgvArticulos.Columns.Add("Responsable", "Responsable");
            dgvArticulos.Columns.Add("FkUsuario", "FkUsuario");
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtClaveCabms.Text != "")
                AgregarArticulo();
            else
                MessageBox.Show("Por favor ingrese una clave CABMS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void AgregarArticulo()
        {
            try
            {
                Logica.LArticulo CLArticulo = new Logica.LArticulo();
                oArticulo = CLArticulo.ObtenerArticuloxCABMS(txtClaveCabms.Text);
                if (oArticulo != null)
                {
                    
                    int row = dgvArticulos.RowCount - 1;
                    dgvArticulos.Rows.Add(1);
                    dgvArticulos.Rows[row].Cells["Id"].Value = oArticulo.ID;
                    dgvArticulos.Rows[row].Cells["ClaveCabms"].Value = txtClaveCabms.Text;
                    dgvArticulos.Rows[row].Cells["Descripcion"].Value = oArticulo.Descripcion;
                    dgvArticulos.Rows[row].Cells["Responsable"].Value = oArticulo.NombreDelResguardatario;
                    dgvArticulos.Rows[row].Cells["fkUsuario"].Value = oArticulo.FkUsuarios;
                    if (row >= 1)
                    {
                        dgvArticulos.Rows[row].Cells["Num"].Value = row + 1;
                    }
                    else
                    {
                        dgvArticulos.Rows[row].Cells["Num"].Value = "1";
                    }

                    this.txtClaveCabms.Text = "";
                    this.txtClaveCabms.Focus();
                    
                }
                else
                {
                    MessageBox.Show("No se ha encontrado ningun articulo con esa clave CABMS");
                }
                
            }
            catch
            { 
            
            }
        }

        private void cboResponsables_Click(object sender, EventArgs e)
        {
            Logica.LUsuario CLUsuario = new Logica.LUsuario();
            cboResguardatario.DataSource = CLUsuario.obtenerListaUsuarios(); ;
            cboResguardatario.DisplayMember = "NOMBRE";
            cboResguardatario.ValueMember = "Id";
        }

        private void btnCambioResguardatario_Click(object sender, EventArgs e)
        {
            Logica.LArticulo CLArticulo = new Logica.LArticulo();
            int row = dgvArticulos.Rows.Count - 1;
            for (int i=0; i < row; i++)
            {
                int id = int.Parse(dgvArticulos.Rows[i].Cells["Id"].Value.ToString());
                int fkUsuario = int.Parse(cboResguardatario.SelectedValue.ToString());
                CLArticulo.cambioDeResguardatario(id, fkUsuario);
            }
            MessageBox.Show("Se ha cambiado el resguardatario","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarDGV();
        }

        private void txtClaveCabms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== Convert.ToChar(Keys.Enter))
            {
                AgregarArticulo();
            }
        }
        private void limpiarDGV()
        {
            dgvArticulos.Rows.Clear();
        }

       
    }
}
