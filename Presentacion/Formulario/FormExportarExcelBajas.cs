
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
    public partial class FormExportarExcelBajas : Form
    {
        public FormExportarExcelBajas()
        {
            InitializeComponent();
        }

        private void btnExportarExcelBajas_Click(object sender, EventArgs e)
        {
            Logica.LArticulo CADLogica = new Logica.LArticulo();
            dgvExportarBajasExcel.DataSource = CADLogica.obtenerArticulosBaja();
            CADLogica.ExportarExcel(dgvExportarBajasExcel);
        }

        private void dgvExportarBajasExcel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
