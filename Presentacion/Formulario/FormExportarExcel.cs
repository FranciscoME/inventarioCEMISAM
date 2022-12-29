
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Presentacion.Formulario
{
    public partial class FormExportarExcel : Form
    {
        SaveFileDialog sfd;
        public FormExportarExcel()
        {
            InitializeComponent();
            sfd = new SaveFileDialog();
        }

        private void btnObtenerArticulosSD_Click(object sender, EventArgs e)
        {
            //if(sfdExportar.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            Logica.LArticulo CAL = new Logica.LArticulo();
            dgvArticulosSD.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArticulosSD.DataSource = CAL.obtenerArticulosSD();
            dgvArticulosDonacion.DataSource = CAL.obtenerArticulosDonacion();

            sfd.AutoUpgradeEnabled = false;
            sfd.Filter = "Excel (*.xls)|*.xls";
            sfd.FileName = "Reporte" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year;

            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {

                CAL.ExportarExcel(dgvArticulosSD, dgvArticulosDonacion, sfd);
            }
        }

        //public void Hilo2()
        //{
        //    timer1.Start();
        //}

        private void FormExportarExcel_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pbExportarExcel.Increment(10);
            
        }
    }
}
