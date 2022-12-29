
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
    public partial class FormModificarUsuario : Form
    {
        public FormModificarUsuario()
        {
            InitializeComponent();
        }

        private void cboUsuarios_Click(object sender, EventArgs e)
        {
            Logica.LUsuario CLUsuarios = new Logica.LUsuario();
            cboUsuarios.DataSource = CLUsuarios.obtenerListaUsuarios();
            cboUsuarios.DisplayMember = "NOMBRE";
            cboUsuarios.ValueMember = "Id";
            
        }

        private void cboUsuarios_SelectedValueChanged(object sender, EventArgs e)
        {

            
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            btnModificarUsuario.Enabled = false;
            cboDepartamento.Enabled = false;
            txtNuevoNombreUsuario.Enabled = false;            
            btnBuscar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Logica.LUsuario CLusuario = new Logica.LUsuario();
            Comun.Objeto.Usuario oUsuario = new Comun.Objeto.Usuario();
            List<Comun.Objeto.Departamento> ListDepartamento = null;

            txtNuevoNombreUsuario.Text = cboUsuarios.Text;
            oUsuario = CLusuario.obtenerUsuario(int.Parse(cboUsuarios.SelectedValue.ToString()));
            int fKDepartamento = oUsuario.FkDepartamento;

            Logica.LDepartamento CLDepartamento = new Logica.LDepartamento();
            ListDepartamento = CLDepartamento.ObtenerDepartamento(fKDepartamento);
            lblIdusuario.Text = ListDepartamento[0].Id.ToString();
            cboDepartamento.Text = ListDepartamento[0].NombreDepartamento;
            txtNuevoNombreUsuario.Enabled = true;
            cboDepartamento.Enabled = true;
        }

        private void cboDepartamento_Click(object sender, EventArgs e)
        {
            Logica.LDepartamento CLObtenerDepartamento = new Logica.LDepartamento();
            cboDepartamento.DataSource = CLObtenerDepartamento.ObtenerDepartamentos();
            cboDepartamento.DisplayMember = "NOMBREDEPARTAMENTO";
            cboDepartamento.ValueMember = "Id";
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            Logica.LUsuario CLDepartamento = new Logica.LUsuario();
            Comun.Objeto.Usuario oUsuario = new Comun.Objeto.Usuario();
            
            try
            {
                oUsuario.FkDepartamento = int.Parse(cboDepartamento.SelectedValue.ToString());
            }
            catch
            {
                oUsuario.FkDepartamento = int.Parse(lblIdusuario.Text);
            }
            
            
            oUsuario.Nombre = txtNuevoNombreUsuario.Text;           
            
            oUsuario.ID = int.Parse(cboUsuarios.SelectedValue.ToString());

            bool resultado=CLDepartamento.modificarUsuario(oUsuario);

            if (resultado == true)
            {
                MessageBox.Show("Usuario modificado correctamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al modificar el usuario","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cboUsuarios_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNuevoNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnModificarUsuario.Enabled = true;
        }

        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
        }
    }
}
