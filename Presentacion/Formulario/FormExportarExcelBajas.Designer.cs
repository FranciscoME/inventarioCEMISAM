namespace Presentacion.Formulario
{
    partial class FormExportarExcelBajas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExportarExcelBajas = new System.Windows.Forms.Button();
            this.dgvExportarBajasExcel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportarBajasExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportarExcelBajas
            // 
            this.btnExportarExcelBajas.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportarExcelBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcelBajas.Location = new System.Drawing.Point(108, 34);
            this.btnExportarExcelBajas.Name = "btnExportarExcelBajas";
            this.btnExportarExcelBajas.Size = new System.Drawing.Size(121, 58);
            this.btnExportarExcelBajas.TabIndex = 0;
            this.btnExportarExcelBajas.Text = "Exportar bajas a excel";
            this.btnExportarExcelBajas.UseVisualStyleBackColor = false;
            this.btnExportarExcelBajas.Click += new System.EventHandler(this.btnExportarExcelBajas_Click);
            // 
            // dgvExportarBajasExcel
            // 
            this.dgvExportarBajasExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExportarBajasExcel.Location = new System.Drawing.Point(56, 147);
            this.dgvExportarBajasExcel.Name = "dgvExportarBajasExcel";
            this.dgvExportarBajasExcel.Size = new System.Drawing.Size(156, 71);
            this.dgvExportarBajasExcel.TabIndex = 1;
            this.dgvExportarBajasExcel.Visible = false;
            this.dgvExportarBajasExcel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExportarBajasExcel_CellContentClick);
            // 
            // FormExportarExcelBajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 163);
            this.Controls.Add(this.dgvExportarBajasExcel);
            this.Controls.Add(this.btnExportarExcelBajas);
            this.Name = "FormExportarExcelBajas";
            this.Text = "Exportar bajas a excel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportarBajasExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportarExcelBajas;
        private System.Windows.Forms.DataGridView dgvExportarBajasExcel;
    }
}