namespace Presentacion.Formulario
{
    partial class FormVariosArticulosBaja
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
            this.txtClaveCabms = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBajaArticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.cmsEliminarArticulo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.cmsEliminarArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClaveCabms
            // 
            this.txtClaveCabms.Location = new System.Drawing.Point(173, 46);
            this.txtClaveCabms.Name = "txtClaveCabms";
            this.txtClaveCabms.Size = new System.Drawing.Size(157, 20);
            this.txtClaveCabms.TabIndex = 0;
            this.txtClaveCabms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveCabms_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(349, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar artículo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBajaArticulo
            // 
            this.btnBajaArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBajaArticulo.Location = new System.Drawing.Point(105, 337);
            this.btnBajaArticulo.Name = "btnBajaArticulo";
            this.btnBajaArticulo.Size = new System.Drawing.Size(75, 40);
            this.btnBajaArticulo.TabIndex = 2;
            this.btnBajaArticulo.Text = "Dar de baja";
            this.btnBajaArticulo.UseVisualStyleBackColor = false;
            this.btnBajaArticulo.Click += new System.EventHandler(this.btnBajaArticulo_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.ContextMenuStrip = this.cmsEliminarArticulo;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 83);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(612, 229);
            this.dgvArticulos.TabIndex = 3;
            // 
            // cmsEliminarArticulo
            // 
            this.cmsEliminarArticulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarArticuloToolStripMenuItem});
            this.cmsEliminarArticulo.Name = "cmsEliminarArticulo";
            this.cmsEliminarArticulo.Size = new System.Drawing.Size(163, 26);
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.eliminarArticuloToolStripMenuItem.Text = "Eliminar Articulo";
            this.eliminarArticuloToolStripMenuItem.Click += new System.EventHandler(this.eliminarArticuloToolStripMenuItem_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.Location = new System.Drawing.Point(440, 337);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Introduce la clave CABMS:";
            // 
            // FormVariosArticulosBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnBajaArticulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtClaveCabms);
            this.Name = "FormVariosArticulosBaja";
            this.Text = "Baja de varios artículos";
            this.Load += new System.EventHandler(this.FormVariosArticulosBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.cmsEliminarArticulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClaveCabms;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBajaArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ContextMenuStrip cmsEliminarArticulo;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}