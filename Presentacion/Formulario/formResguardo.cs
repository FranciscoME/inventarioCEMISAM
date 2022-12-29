 
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
    public partial class formResguardo : Form
    {
        public string IdResponsable;
        public formResguardo()
        {
            InitializeComponent();
        }

        private void formResguardo_Load(object sender, EventArgs e)
        {
            
            
            Logica.LArticulo CALArticulo = new Logica.LArticulo();
            var articulos = CALArticulo.consultaArticulosXUsuario(int.Parse(IdResponsable.ToString()));
            this.ArticuloResguardoBindingSource.DataSource = articulos;
            this.reportViewer1.RefreshReport();
        }
    }
}
