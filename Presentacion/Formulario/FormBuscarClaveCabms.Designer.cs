namespace Presentacion.Formulario
{
    partial class FormBuscarClaveCabms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarClaveCabms));
            this.txtCaracteristica = new System.Windows.Forms.TextBox();
            this.dgvClavesCabms = new System.Windows.Forms.DataGridView();
            this.btnBuscarCabms = new System.Windows.Forms.Button();
            this.btnTodosCambs = new System.Windows.Forms.Button();
            this.txtClaveCabms = new System.Windows.Forms.TextBox();
            this.btnUsarClaveCabms = new System.Windows.Forms.Button();
            this.lblBuscarXCaracteristicaClaveCabms = new System.Windows.Forms.Label();
            this.lblBuscarXArticulosSimilares = new System.Windows.Forms.Label();
            this.txtArticuloSimilar = new System.Windows.Forms.TextBox();
            this.btnBuscarArticuloSimilar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblBuscandoPor = new System.Windows.Forms.Label();
            this.lblCriterioDeBusqueda = new System.Windows.Forms.Label();
            this.lblClavePresupuestal = new System.Windows.Forms.Label();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClavesCabms)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCaracteristica
            // 
            this.txtCaracteristica.Location = new System.Drawing.Point(221, 57);
            this.txtCaracteristica.Name = "txtCaracteristica";
            this.txtCaracteristica.Size = new System.Drawing.Size(149, 20);
            this.txtCaracteristica.TabIndex = 2;
            this.txtCaracteristica.TextChanged += new System.EventHandler(this.txtCaracteristica_TextChanged);
            this.txtCaracteristica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracteristica_KeyPress);
            // 
            // dgvClavesCabms
            // 
            this.dgvClavesCabms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClavesCabms.Location = new System.Drawing.Point(12, 106);
            this.dgvClavesCabms.Name = "dgvClavesCabms";
            this.dgvClavesCabms.Size = new System.Drawing.Size(980, 299);
            this.dgvClavesCabms.TabIndex = 1;
            this.dgvClavesCabms.SelectionChanged += new System.EventHandler(this.dgvClavesCabms_SelectionChanged);
            // 
            // btnBuscarCabms
            // 
            this.btnBuscarCabms.BackColor = System.Drawing.Color.Chocolate;
            this.btnBuscarCabms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCabms.Location = new System.Drawing.Point(394, 51);
            this.btnBuscarCabms.Name = "btnBuscarCabms";
            this.btnBuscarCabms.Size = new System.Drawing.Size(80, 40);
            this.btnBuscarCabms.TabIndex = 3;
            this.btnBuscarCabms.Text = "Buscar";
            this.btnBuscarCabms.UseVisualStyleBackColor = false;
            this.btnBuscarCabms.Click += new System.EventHandler(this.btnBuscarCabms_Click);
            // 
            // btnTodosCambs
            // 
            this.btnTodosCambs.BackColor = System.Drawing.Color.Chocolate;
            this.btnTodosCambs.Location = new System.Drawing.Point(12, 413);
            this.btnTodosCambs.Name = "btnTodosCambs";
            this.btnTodosCambs.Size = new System.Drawing.Size(95, 49);
            this.btnTodosCambs.TabIndex = 4;
            this.btnTodosCambs.Text = "Mostrar Todas las CABMS";
            this.btnTodosCambs.UseVisualStyleBackColor = false;
            this.btnTodosCambs.Click += new System.EventHandler(this.btnTodosCambs_Click);
            // 
            // txtClaveCabms
            // 
            this.txtClaveCabms.Location = new System.Drawing.Point(669, 32);
            this.txtClaveCabms.Name = "txtClaveCabms";
            this.txtClaveCabms.Size = new System.Drawing.Size(77, 20);
            this.txtClaveCabms.TabIndex = 4;
            // 
            // btnUsarClaveCabms
            // 
            this.btnUsarClaveCabms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUsarClaveCabms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsarClaveCabms.Location = new System.Drawing.Point(774, 20);
            this.btnUsarClaveCabms.Name = "btnUsarClaveCabms";
            this.btnUsarClaveCabms.Size = new System.Drawing.Size(109, 42);
            this.btnUsarClaveCabms.TabIndex = 5;
            this.btnUsarClaveCabms.Text = "Usar esta cabms";
            this.btnUsarClaveCabms.UseVisualStyleBackColor = false;
            this.btnUsarClaveCabms.Click += new System.EventHandler(this.btnUsarClaveCabms_Click);
            // 
            // lblBuscarXCaracteristicaClaveCabms
            // 
            this.lblBuscarXCaracteristicaClaveCabms.AutoSize = true;
            this.lblBuscarXCaracteristicaClaveCabms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarXCaracteristicaClaveCabms.Location = new System.Drawing.Point(12, 57);
            this.lblBuscarXCaracteristicaClaveCabms.Name = "lblBuscarXCaracteristicaClaveCabms";
            this.lblBuscarXCaracteristicaClaveCabms.Size = new System.Drawing.Size(204, 16);
            this.lblBuscarXCaracteristicaClaveCabms.TabIndex = 6;
            this.lblBuscarXCaracteristicaClaveCabms.Text = "Buscar en caracteristica CABMS:";
            // 
            // lblBuscarXArticulosSimilares
            // 
            this.lblBuscarXArticulosSimilares.AutoSize = true;
            this.lblBuscarXArticulosSimilares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarXArticulosSimilares.Location = new System.Drawing.Point(12, 15);
            this.lblBuscarXArticulosSimilares.Name = "lblBuscarXArticulosSimilares";
            this.lblBuscarXArticulosSimilares.Size = new System.Drawing.Size(142, 16);
            this.lblBuscarXArticulosSimilares.TabIndex = 7;
            this.lblBuscarXArticulosSimilares.Text = "Buscar Artículo similar:";
            // 
            // txtArticuloSimilar
            // 
            this.txtArticuloSimilar.Location = new System.Drawing.Point(223, 14);
            this.txtArticuloSimilar.Name = "txtArticuloSimilar";
            this.txtArticuloSimilar.Size = new System.Drawing.Size(147, 20);
            this.txtArticuloSimilar.TabIndex = 0;
            this.txtArticuloSimilar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticuloSimilar_KeyPress);
            // 
            // btnBuscarArticuloSimilar
            // 
            this.btnBuscarArticuloSimilar.BackColor = System.Drawing.Color.Chocolate;
            this.btnBuscarArticuloSimilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArticuloSimilar.Location = new System.Drawing.Point(394, 5);
            this.btnBuscarArticuloSimilar.Name = "btnBuscarArticuloSimilar";
            this.btnBuscarArticuloSimilar.Size = new System.Drawing.Size(80, 40);
            this.btnBuscarArticuloSimilar.TabIndex = 1;
            this.btnBuscarArticuloSimilar.Text = "Buscar";
            this.btnBuscarArticuloSimilar.UseVisualStyleBackColor = false;
            this.btnBuscarArticuloSimilar.Click += new System.EventHandler(this.btnBuscarArticuloSimilar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.Location = new System.Drawing.Point(906, 414);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 48);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblBuscandoPor
            // 
            this.lblBuscandoPor.AutoSize = true;
            this.lblBuscandoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscandoPor.Location = new System.Drawing.Point(141, 88);
            this.lblBuscandoPor.Name = "lblBuscandoPor";
            this.lblBuscandoPor.Size = new System.Drawing.Size(0, 16);
            this.lblBuscandoPor.TabIndex = 11;
            // 
            // lblCriterioDeBusqueda
            // 
            this.lblCriterioDeBusqueda.AutoSize = true;
            this.lblCriterioDeBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioDeBusqueda.Location = new System.Drawing.Point(11, 88);
            this.lblCriterioDeBusqueda.Name = "lblCriterioDeBusqueda";
            this.lblCriterioDeBusqueda.Size = new System.Drawing.Size(124, 15);
            this.lblCriterioDeBusqueda.TabIndex = 12;
            this.lblCriterioDeBusqueda.Text = "Criterio de busqueda:";
            // 
            // lblClavePresupuestal
            // 
            this.lblClavePresupuestal.AutoSize = true;
            this.lblClavePresupuestal.Location = new System.Drawing.Point(827, 451);
            this.lblClavePresupuestal.Name = "lblClavePresupuestal";
            this.lblClavePresupuestal.Size = new System.Drawing.Size(0, 13);
            this.lblClavePresupuestal.TabIndex = 13;
            this.lblClavePresupuestal.Visible = false;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(479, 413);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(157, 48);
            this.btnAgregarArticulo.TabIndex = 14;
            this.btnAgregarArticulo.Text = "Ir a la pantalla para agregar un nuevo articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "CABMS a utilizar:";
            // 
            // FormBuscarClaveCabms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.lblClavePresupuestal);
            this.Controls.Add(this.lblCriterioDeBusqueda);
            this.Controls.Add(this.lblBuscandoPor);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscarArticuloSimilar);
            this.Controls.Add(this.txtArticuloSimilar);
            this.Controls.Add(this.lblBuscarXArticulosSimilares);
            this.Controls.Add(this.lblBuscarXCaracteristicaClaveCabms);
            this.Controls.Add(this.btnUsarClaveCabms);
            this.Controls.Add(this.txtClaveCabms);
            this.Controls.Add(this.btnTodosCambs);
            this.Controls.Add(this.btnBuscarCabms);
            this.Controls.Add(this.dgvClavesCabms);
            this.Controls.Add(this.txtCaracteristica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarClaveCabms";
            this.Text = "Agregar nuevo artículo";
            this.Load += new System.EventHandler(this.FormBuscarClaveCabms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClavesCabms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaracteristica;
        private System.Windows.Forms.DataGridView dgvClavesCabms;
        private System.Windows.Forms.Button btnBuscarCabms;
        private System.Windows.Forms.Button btnTodosCambs;
        private System.Windows.Forms.TextBox txtClaveCabms;
        private System.Windows.Forms.Button btnUsarClaveCabms;
        private System.Windows.Forms.Label lblBuscarXCaracteristicaClaveCabms;
        private System.Windows.Forms.Label lblBuscarXArticulosSimilares;
        private System.Windows.Forms.TextBox txtArticuloSimilar;
        private System.Windows.Forms.Button btnBuscarArticuloSimilar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblBuscandoPor;
        private System.Windows.Forms.Label lblCriterioDeBusqueda;
        private System.Windows.Forms.Label lblClavePresupuestal;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Label label1;
    }
}