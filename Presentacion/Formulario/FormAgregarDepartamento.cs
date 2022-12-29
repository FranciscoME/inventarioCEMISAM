
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
    public partial class FormAgregarDepartamento : Form
    {
        public FormAgregarDepartamento()
        {
            InitializeComponent();
        }

        private void btnGuardarDepartamento_Click(object sender, EventArgs e)
        {
            
            Logica.LDepartamento CLDepartamento = new Logica.LDepartamento();
            bool DepartamentoInsertado = CLDepartamento.insertarDepartamento(txtNombreDepartamento.Text.ToUpper());
            if (DepartamentoInsertado == true)
            {
                MessageBox.Show("Se ha insertado el departamento correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }                
            else
                MessageBox.Show("Error al insertar el departamento","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormAgregarDepartamento_Load(object sender, EventArgs e)
        {

        }
    }
}
