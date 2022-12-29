
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Presentacion.Formulario
{
    public partial class FormBuscarClaveCabms : Form
    {
        public FormBuscarClaveCabms()
        {
            InitializeComponent();
        }

        private void btnTodosCambs_Click(object sender, EventArgs e)
        {
            lblBuscandoPor.Text = "Todos";
            dgvClavesCabms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
            Logica.LCabms LLCabms = new Logica.LCabms();
            dgvClavesCabms.DataSource = LLCabms.consultaCabms();
        }

        private void dgvClavesCabms_SelectionChanged(object sender, EventArgs e)
        {
            int row = int.Parse(dgvClavesCabms.CurrentCell.RowIndex.ToString());

            try
            {
                
                txtClaveCabms.Text = dgvClavesCabms[1, row].Value.ToString();
                lblClavePresupuestal.Text = dgvClavesCabms[2, row].Value.ToString();
                lblClavePresupuestal.Text = dgvClavesCabms["DESCRIPCION",row].Value.ToString();
                
                string cadenaCabmsCompleta = txtClaveCabms.Text;
                txtClaveCabms.Text = cadenaCabmsCompleta.Substring(10, 10);
            }
            catch
            {
                txtClaveCabms.Text = dgvClavesCabms[1, row].Value.ToString();
            }
        }

        private void btnUsarClaveCabms_Click(object sender, EventArgs e)
        {
            if(txtClaveCabms.Text!="")
            {
                FormAgregarArticulo frmAA = new FormAgregarArticulo();

                Logica.LArticulo LLArticulo = new Logica.LArticulo();
                int existen = LLArticulo.BusquedaDeArticulosxCABMSSimilar(txtClaveCabms.Text);
                existen = existen + 1;

                //MessageBox.Show(txtClaveCabms.Text+existen.ToString());
                string sal = "1616053006" + txtClaveCabms.Text + existen.ToString();

                if (sal.Length <= 21)
                {
                    frmAA.txtClaveCabms.Text = "1616053006" + txtClaveCabms.Text + "0" + existen.ToString();
                    frmAA.txtDescripcion.Text = lblClavePresupuestal.Text;
                }
                else
                {
                    frmAA.txtClaveCabms.Text = "1616053006" + txtClaveCabms.Text + existen.ToString();
                    frmAA.txtDescripcion.Text = lblClavePresupuestal.Text;
                }

                frmAA.Show();

            }
            else
            {
                MessageBox.Show("Favor de seleccionar una clave CABMS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnBuscarCabms_Click(object sender, EventArgs e)
        {
            if (txtCaracteristica.Text != "")
            {
                lblBuscandoPor.Text = txtCaracteristica.Text;
                dgvClavesCabms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Logica.LCabms LLClaveCabms = new Logica.LCabms();
                dgvClavesCabms.DataSource = LLClaveCabms.consultaCabmsxCaracteristica(txtCaracteristica.Text);
                txtCaracteristica.Text = "";
            }
            else
            {
                MessageBox.Show("Favor de introducir una característica un artículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           

        }

        private void btnBuscarArticuloSimilar_Click(object sender, EventArgs e)
        {
            if (txtArticuloSimilar.Text != "")
            {
                lblBuscandoPor.Text = txtArticuloSimilar.Text;
                dgvClavesCabms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Logica.LArticulo LLBusquedaCabmsYDescripcionXCaracteristicas = new Logica.LArticulo();
                dgvClavesCabms.DataSource = LLBusquedaCabmsYDescripcionXCaracteristicas.consultaArticulosCabmsYDescripcionXCaracteristica(txtArticuloSimilar.Text);
                txtArticuloSimilar.Text = "";
            }
            else
            {
                MessageBox.Show("Favor de introducir una descripcion de un artículo ingresado previamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCaracteristica_TextChanged(object sender, EventArgs e)
        {
            //lblBuscandoPor.Text = txtCaracteristica.Text;
            //dgvClavesCabms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //Logica.LCabms LLClaveCabms = new Logica.LCabms();
            //dgvClavesCabms.DataSource = LLClaveCabms.consultaCabmsxCaracteristica(txtCaracteristica.Text);
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            FormAgregarArticulo frmAA = new FormAgregarArticulo();
            
            frmAA.Show();
        }

        private void FormBuscarClaveCabms_Load(object sender, EventArgs e)
        {
            txtArticuloSimilar.Focus();
        }

        private void txtArticuloSimilar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtArticuloSimilar.Text != "")
                {
                    lblBuscandoPor.Text = txtArticuloSimilar.Text;
                    dgvClavesCabms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    Logica.LArticulo LLBusquedaCabmsYDescripcionXCaracteristicas = new Logica.LArticulo();
                    dgvClavesCabms.DataSource = LLBusquedaCabmsYDescripcionXCaracteristicas.consultaArticulosCabmsYDescripcionXCaracteristica(txtArticuloSimilar.Text);
                    txtArticuloSimilar.Text = "";
                }
                else
                {
                    MessageBox.Show("Favor de introducir una descripcion de un artículo ingresado previamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtCaracteristica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar== (int)Keys.Enter)
            {
                if (txtCaracteristica.Text != "")
                {
                    lblBuscandoPor.Text = txtCaracteristica.Text;
                    dgvClavesCabms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    Logica.LCabms LLClaveCabms = new Logica.LCabms();
                    dgvClavesCabms.DataSource = LLClaveCabms.consultaCabmsxCaracteristica(txtCaracteristica.Text);
                    txtCaracteristica.Text = "";
                }
                else
                {
                    MessageBox.Show("Favor de introducir una característica un artículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
            
    }
}
