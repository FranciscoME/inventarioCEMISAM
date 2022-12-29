namespace Presentacion.Formulario
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.msInventarios = new System.Windows.Forms.MenuStrip();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesConVariosArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeResguardatarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fijarNombresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarBajasAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msInventarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // msInventarios
            // 
            this.msInventarios.AutoSize = false;
            this.msInventarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.busquedasToolStripMenuItem,
            this.articuloToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.msInventarios.Location = new System.Drawing.Point(0, 0);
            this.msInventarios.Name = "msInventarios";
            this.msInventarios.Size = new System.Drawing.Size(1026, 24);
            this.msInventarios.Stretch = false;
            this.msInventarios.TabIndex = 1;
            this.msInventarios.Text = "menuStrip1";
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDepartamentoToolStripMenuItem});
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            // 
            // agregarDepartamentoToolStripMenuItem
            // 
            this.agregarDepartamentoToolStripMenuItem.Name = "agregarDepartamentoToolStripMenuItem";
            this.agregarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.agregarDepartamentoToolStripMenuItem.Text = "Agregar Departamento";
            this.agregarDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.agregarDepartamentoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // busquedasToolStripMenuItem
            // 
            this.busquedasToolStripMenuItem.Name = "busquedasToolStripMenuItem";
            this.busquedasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.busquedasToolStripMenuItem.Text = "Busquedas";
            this.busquedasToolStripMenuItem.Click += new System.EventHandler(this.busquedasToolStripMenuItem_Click);
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArticuloToolStripMenuItem,
            this.modificarArticuloToolStripMenuItem,
            this.operacionesConVariosArticulosToolStripMenuItem});
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.articuloToolStripMenuItem.Text = "Articulo";
            this.articuloToolStripMenuItem.Click += new System.EventHandler(this.articuloToolStripMenuItem_Click);
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar Articulo";
            this.agregarArticuloToolStripMenuItem.Click += new System.EventHandler(this.agregarArticuloToolStripMenuItem_Click);
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.modificarArticuloToolStripMenuItem.Text = "Modificar Articulo";
            this.modificarArticuloToolStripMenuItem.Click += new System.EventHandler(this.modificarArticuloToolStripMenuItem_Click);
            // 
            // operacionesConVariosArticulosToolStripMenuItem
            // 
            this.operacionesConVariosArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bajasToolStripMenuItem,
            this.cambioDeResguardatarioToolStripMenuItem});
            this.operacionesConVariosArticulosToolStripMenuItem.Name = "operacionesConVariosArticulosToolStripMenuItem";
            this.operacionesConVariosArticulosToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.operacionesConVariosArticulosToolStripMenuItem.Text = "Operaciones con varios articulos";
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.bajasToolStripMenuItem.Text = "Bajas";
            this.bajasToolStripMenuItem.Click += new System.EventHandler(this.bajasToolStripMenuItem_Click);
            // 
            // cambioDeResguardatarioToolStripMenuItem
            // 
            this.cambioDeResguardatarioToolStripMenuItem.Name = "cambioDeResguardatarioToolStripMenuItem";
            this.cambioDeResguardatarioToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.cambioDeResguardatarioToolStripMenuItem.Text = "Cambio de Resguardatario";
            this.cambioDeResguardatarioToolStripMenuItem.Click += new System.EventHandler(this.cambioDeResguardatarioToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fijarNombresToolStripMenuItem,
            this.exportarBajasAExcelToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // fijarNombresToolStripMenuItem
            // 
            this.fijarNombresToolStripMenuItem.Name = "fijarNombresToolStripMenuItem";
            this.fijarNombresToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.fijarNombresToolStripMenuItem.Text = "Exportar reportes a Excel";
            this.fijarNombresToolStripMenuItem.Click += new System.EventHandler(this.fijarNombresToolStripMenuItem_Click);
            // 
            // exportarBajasAExcelToolStripMenuItem
            // 
            this.exportarBajasAExcelToolStripMenuItem.Name = "exportarBajasAExcelToolStripMenuItem";
            this.exportarBajasAExcelToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exportarBajasAExcelToolStripMenuItem.Text = "Exportar bajas a Excel";
            this.exportarBajasAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarBajasAExcelToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1026, 519);
            this.Controls.Add(this.msInventarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msInventarios;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario CEMISAM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.msInventarios.ResumeLayout(false);
            this.msInventarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msInventarios;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fijarNombresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesConVariosArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeResguardatarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarBajasAExcelToolStripMenuItem;

    }
}