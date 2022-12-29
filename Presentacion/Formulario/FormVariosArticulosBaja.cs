
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
    public partial class FormVariosArticulosBaja : Form
    {

        public Comun.Objeto.ArticuloConsulta oArticulo = null;
        
        public FormVariosArticulosBaja()
        {
            InitializeComponent();
        }

        private void FormVariosArticulosBaja_Load(object sender, EventArgs e)
        {
            dgvArticulos.Columns.Add("Num", "Num.");
            dgvArticulos.Columns.Add("Id", "Id");
            dgvArticulos.Columns.Add("ClaveCabms", "Clave CABMS");
            dgvArticulos.Columns.Add("descripcion", "Descripcion");
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtClaveCabms.Text != "")
                AgregarArticulo();
            else
                MessageBox.Show("Por favor ingrese una clave CABMS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnBajaArticulo_Click(object sender, EventArgs e)
        {
            int row = dgvArticulos.RowCount - 1;
            //MessageBox.Show("numero de filas:" + row);


            Logica.LArticulo articulo = new Logica.LArticulo();

            for (int i = 0; i < row; i++)
            {

                articulo.bajaDeArticulo(int.Parse(dgvArticulos.Rows[i].Cells[1].Value.ToString()));                
                
            }
            MessageBox.Show("Registros dados de baja satisfactoriamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            limpiarDGV();
        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvArticulos.Rows.RemoveAt(dgvArticulos.CurrentCell.RowIndex);
        }


        private void limpiarDGV()
        {            
            dgvArticulos.Rows.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtClaveCabms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(Convert.ToChar(Keys.Enter)))
            {
                AgregarArticulo();
            }
        }

        private void AgregarArticulo()
        {

            try
            {
            Logica.LArticulo ClArticulo = new Logica.LArticulo();
            oArticulo = ClArticulo.ObtenerArticuloxCABMS(txtClaveCabms.Text);
            if (oArticulo != null)
            {
                int row = dgvArticulos.RowCount - 1;
                dgvArticulos.Rows.Add(1);
                dgvArticulos.Rows[row].Cells["descripcion"].Value = oArticulo.Descripcion;
                dgvArticulos.Rows[row].Cells["ClaveCabms"].Value = txtClaveCabms.Text;
                dgvArticulos.Rows[row].Cells["Id"].Value = oArticulo.ID;

                if (row >= 1)
                {
                    dgvArticulos.Rows[row].Cells["Num"].Value = row + 1;
                }
                else
                {
                    dgvArticulos.Rows[row].Cells["Num"].Value = "1";
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun articulo con esa clave CABMS","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            }
            catch
            {
                MessageBox.Show("No se ha encontrado ningun articulos con esa clave CABMS","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            this.txtClaveCabms.Text = "";
            this.txtClaveCabms.Focus();
        }
    }
}
