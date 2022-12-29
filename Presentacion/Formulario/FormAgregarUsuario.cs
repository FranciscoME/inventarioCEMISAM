
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
    public partial class FormAgregarUsuario : Form
    {
        public FormAgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            
            Comun.Objeto.Usuario oUsuario = new Comun.Objeto.Usuario();
            Logica.LUsuario CLUsuario = new Logica.LUsuario();
            oUsuario.Nombre = txtNombreUsuario.Text.ToUpper();
            oUsuario.FkDepartamento = int.Parse(cboDepartamento.SelectedValue.ToString());
            bool resultado = CLUsuario.InsertarUsuario(oUsuario);

            if (resultado == true)
            {
                MessageBox.Show("Usuario ingresado correctamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al ingresar el usuario","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void cboDepartamento_Click(object sender, EventArgs e)
        {
            Logica.LDepartamento CLDepartamento = new Logica.LDepartamento();
            cboDepartamento.DataSource = CLDepartamento.ObtenerDepartamentos();
            cboDepartamento.DisplayMember = "NombreDepartamento";
            cboDepartamento.ValueMember = "Id";
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
