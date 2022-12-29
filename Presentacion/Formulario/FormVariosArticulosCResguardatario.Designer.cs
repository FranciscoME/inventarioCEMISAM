namespace Presentacion.Formulario
{
    partial class FormVariosArticulosCResguardatario
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
            this.txtClaveCabms = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnCambioResguardatario = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cboResguardatario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClaveCabms
            // 
            this.txtClaveCabms.Location = new System.Drawing.Point(166, 39);
            this.txtClaveCabms.Name = "txtClaveCabms";
            this.txtClaveCabms.Size = new System.Drawing.Size(182, 20);
            this.txtClaveCabms.TabIndex = 0;
            this.txtClaveCabms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveCabms_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(370, 31);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 34);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar artículo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(13, 88);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(514, 225);
            this.dgvArticulos.TabIndex = 2;
            // 
            // btnCambioResguardatario
            // 
            this.btnCambioResguardatario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCambioResguardatario.Location = new System.Drawing.Point(74, 381);
            this.btnCambioResguardatario.Name = "btnCambioResguardatario";
            this.btnCambioResguardatario.Size = new System.Drawing.Size(90, 38);
            this.btnCambioResguardatario.TabIndex = 3;
            this.btnCambioResguardatario.Text = "Cambiar Resguardatario";
            this.btnCambioResguardatario.UseVisualStyleBackColor = false;
            this.btnCambioResguardatario.Click += new System.EventHandler(this.btnCambioResguardatario_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.Location = new System.Drawing.Point(358, 381);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 38);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cboResguardatario
            // 
            this.cboResguardatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResguardatario.FormattingEnabled = true;
            this.cboResguardatario.Location = new System.Drawing.Point(106, 328);
            this.cboResguardatario.Name = "cboResguardatario";
            this.cboResguardatario.Size = new System.Drawing.Size(303, 21);
            this.cboResguardatario.TabIndex = 5;
            this.cboResguardatario.Click += new System.EventHandler(this.cboResponsables_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Introduce la clave CABMS:";
            // 
            // FormVariosArticulosCResguardatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboResguardatario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCambioResguardatario);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtClaveCabms);
            this.Name = "FormVariosArticulosCResguardatario";
            this.Text = "Cambiar varios artículos de resguardatario";
            this.Load += new System.EventHandler(this.FormVariosArticulosCResguardatario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClaveCabms;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnCambioResguardatario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboResguardatario;
        private System.Windows.Forms.Label label1;
    }
}