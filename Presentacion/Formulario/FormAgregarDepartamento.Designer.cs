namespace Presentacion.Formulario
{
    partial class FormAgregarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarDepartamento));
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.lblNombreDepartamento = new System.Windows.Forms.Label();
            this.btnGuardarDepartamento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDepartamento.Location = new System.Drawing.Point(220, 109);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(155, 22);
            this.txtNombreDepartamento.TabIndex = 0;
            // 
            // lblNombreDepartamento
            // 
            this.lblNombreDepartamento.AutoSize = true;
            this.lblNombreDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDepartamento.Location = new System.Drawing.Point(42, 112);
            this.lblNombreDepartamento.Name = "lblNombreDepartamento";
            this.lblNombreDepartamento.Size = new System.Drawing.Size(172, 16);
            this.lblNombreDepartamento.TabIndex = 1;
            this.lblNombreDepartamento.Text = "Nombre del  departamento:";
            // 
            // btnGuardarDepartamento
            // 
            this.btnGuardarDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardarDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDepartamento.Location = new System.Drawing.Point(81, 192);
            this.btnGuardarDepartamento.Name = "btnGuardarDepartamento";
            this.btnGuardarDepartamento.Size = new System.Drawing.Size(75, 44);
            this.btnGuardarDepartamento.TabIndex = 2;
            this.btnGuardarDepartamento.Text = "Guardar";
            this.btnGuardarDepartamento.UseVisualStyleBackColor = false;
            this.btnGuardarDepartamento.Click += new System.EventHandler(this.btnGuardarDepartamento_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(264, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar un nuevo departamento";
            // 
            // FormAgregarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardarDepartamento);
            this.Controls.Add(this.lblNombreDepartamento);
            this.Controls.Add(this.txtNombreDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregarDepartamento";
            this.Text = "Agregar Departamento";
            this.Load += new System.EventHandler(this.FormAgregarDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Label lblNombreDepartamento;
        private System.Windows.Forms.Button btnGuardarDepartamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}