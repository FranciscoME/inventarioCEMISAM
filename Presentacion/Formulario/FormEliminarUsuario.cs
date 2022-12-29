
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
    public partial class FormEliminarUsuario : Form
    {
        public FormEliminarUsuario()
        {
            InitializeComponent();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            Logica.LUsuario CLUsuario = new Logica.LUsuario();
            cboUsuario.DataSource = CLUsuario.obtenerListaUsuarios();
            cboUsuario.DisplayMember = "NOMBRE";
            cboUsuario.ValueMember = "Id";
        }

        private void FormEliminarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            List<Comun.Objeto.ArticuloConsulta> ListArticulosxUsuario = new List<Comun.Objeto.ArticuloConsulta>();
            Logica.LArticulo CLArticulo = new Logica.LArticulo();        
            
            
            try
            {

                ListArticulosxUsuario = CLArticulo.consultaArticulosXUsuario(int.Parse(cboUsuario.SelectedValue.ToString()));
                if (ListArticulosxUsuario.Count <  1)
                {

                    Logica.LUsuario CLUsuario = new Logica.LUsuario();
                    bool resultado = CLUsuario.eliminarUsuario(int.Parse(cboUsuario.SelectedValue.ToString()));
                    if (resultado == true)
                    {
                        MessageBox.Show("Se ha eliminado correctamente el usuario","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Este Usuario aun no puede ser eliminado debido a que tiene articulos a su responsabilidad","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Si usted desea eliminar un usuario por favor seleccionelo","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
            
            
        }
    }
}
