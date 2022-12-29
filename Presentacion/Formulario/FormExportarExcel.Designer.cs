namespace Presentacion.Formulario
{
    partial class FormExportarExcel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportarExcel));
            this.dgvArticulosSD = new System.Windows.Forms.DataGridView();
            this.dgvArticulosDonacion = new System.Windows.Forms.DataGridView();
            this.btnObtenerArticulosSD = new System.Windows.Forms.Button();
            this.ttpExportarRPrincipal = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosDonacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulosSD
            // 
            this.dgvArticulosSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosSD.Location = new System.Drawing.Point(90, 117);
            this.dgvArticulosSD.Name = "dgvArticulosSD";
            this.dgvArticulosSD.Size = new System.Drawing.Size(27, 27);
            this.dgvArticulosSD.TabIndex = 1;
            this.dgvArticulosSD.Visible = false;
            // 
            // dgvArticulosDonacion
            // 
            this.dgvArticulosDonacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosDonacion.Location = new System.Drawing.Point(193, 117);
            this.dgvArticulosDonacion.Name = "dgvArticulosDonacion";
            this.dgvArticulosDonacion.Size = new System.Drawing.Size(32, 27);
            this.dgvArticulosDonacion.TabIndex = 2;
            this.dgvArticulosDonacion.Visible = false;
            // 
            // btnObtenerArticulosSD
            // 
            this.btnObtenerArticulosSD.BackColor = System.Drawing.Color.LimeGreen;
            this.btnObtenerArticulosSD.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnObtenerArticulosSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerArticulosSD.Location = new System.Drawing.Point(90, 29);
            this.btnObtenerArticulosSD.Name = "btnObtenerArticulosSD";
            this.btnObtenerArticulosSD.Size = new System.Drawing.Size(135, 71);
            this.btnObtenerArticulosSD.TabIndex = 0;
            this.btnObtenerArticulosSD.Text = "Exportar a excel";
            this.ttpExportarRPrincipal.SetToolTip(this.btnObtenerArticulosSD, resources.GetString("btnObtenerArticulosSD.ToolTip"));
            this.btnObtenerArticulosSD.UseVisualStyleBackColor = false;
            this.btnObtenerArticulosSD.Click += new System.EventHandler(this.btnObtenerArticulosSD_Click);
            // 
            // ttpExportarRPrincipal
            // 
            this.ttpExportarRPrincipal.AutoPopDelay = 15000;
            this.ttpExportarRPrincipal.InitialDelay = 500;
            this.ttpExportarRPrincipal.ReshowDelay = 1000;
            // 
            // FormExportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 161);
            this.Controls.Add(this.dgvArticulosDonacion);
            this.Controls.Add(this.dgvArticulosSD);
            this.Controls.Add(this.btnObtenerArticulosSD);
            this.Name = "FormExportarExcel";
            this.Text = "Exportar reporte a Excel";
            this.Load += new System.EventHandler(this.FormExportarExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosDonacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObtenerArticulosSD;
        private System.Windows.Forms.DataGridView dgvArticulosSD;
        private System.Windows.Forms.DataGridView dgvArticulosDonacion;
        private System.Windows.Forms.ToolTip ttpExportarRPrincipal;
    }
}