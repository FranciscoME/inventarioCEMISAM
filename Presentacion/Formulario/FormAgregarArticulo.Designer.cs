namespace Presentacion.Formulario
{
    partial class FormAgregarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarArticulo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboEstadoFisico = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.txtClavePresupuestal = new System.Windows.Forms.TextBox();
            this.cboResguardatario = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblResguardatario = new System.Windows.Forms.Label();
            this.lblEstadoFisico = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClavePresupuestal = new System.Windows.Forms.Label();
            this.lblClaveCabms = new System.Windows.Forms.Label();
            this.lblDescripcionClaveCabms = new System.Windows.Forms.Label();
            this.txtClaveCabms = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDonacionNo = new System.Windows.Forms.RadioButton();
            this.rbDonacionSi = new System.Windows.Forms.RadioButton();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblDonacion = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblNumeroDeSerie = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tabImagen = new System.Windows.Forms.TabPage();
            this.btnSinImagen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreImagen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelecImagen = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnInsertarArticulo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabImagen);
            this.tabControl1.Location = new System.Drawing.Point(24, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(709, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.YellowGreen;
            this.tabPage1.Controls.Add(this.cboEstadoFisico);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.txtCostoUnitario);
            this.tabPage1.Controls.Add(this.txtClavePresupuestal);
            this.tabPage1.Controls.Add(this.cboResguardatario);
            this.tabPage1.Controls.Add(this.lblDescripcion);
            this.tabPage1.Controls.Add(this.lblResguardatario);
            this.tabPage1.Controls.Add(this.lblEstadoFisico);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblClavePresupuestal);
            this.tabPage1.Controls.Add(this.lblClaveCabms);
            this.tabPage1.Controls.Add(this.lblDescripcionClaveCabms);
            this.tabPage1.Controls.Add(this.txtClaveCabms);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informacion General";
            // 
            // cboEstadoFisico
            // 
            this.cboEstadoFisico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoFisico.FormattingEnabled = true;
            this.cboEstadoFisico.Items.AddRange(new object[] {
            "BUENO",
            "REGULAR",
            "MALO"});
            this.cboEstadoFisico.Location = new System.Drawing.Point(151, 211);
            this.cboEstadoFisico.Name = "cboEstadoFisico";
            this.cboEstadoFisico.Size = new System.Drawing.Size(100, 24);
            this.cboEstadoFisico.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(350, 74);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(332, 186);
            this.txtDescripcion.TabIndex = 14;
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnitario.Location = new System.Drawing.Point(151, 137);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(100, 22);
            this.txtCostoUnitario.TabIndex = 12;
            // 
            // txtClavePresupuestal
            // 
            this.txtClavePresupuestal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClavePresupuestal.Location = new System.Drawing.Point(151, 74);
            this.txtClavePresupuestal.Name = "txtClavePresupuestal";
            this.txtClavePresupuestal.Size = new System.Drawing.Size(100, 22);
            this.txtClavePresupuestal.TabIndex = 11;
            // 
            // cboResguardatario
            // 
            this.cboResguardatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResguardatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboResguardatario.FormattingEnabled = true;
            this.cboResguardatario.Location = new System.Drawing.Point(151, 291);
            this.cboResguardatario.Name = "cboResguardatario";
            this.cboResguardatario.Size = new System.Drawing.Size(339, 23);
            this.cboResguardatario.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(481, 43);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 16);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblResguardatario
            // 
            this.lblResguardatario.AutoSize = true;
            this.lblResguardatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResguardatario.Location = new System.Drawing.Point(9, 294);
            this.lblResguardatario.Name = "lblResguardatario";
            this.lblResguardatario.Size = new System.Drawing.Size(105, 16);
            this.lblResguardatario.TabIndex = 8;
            this.lblResguardatario.Text = "Resguardatario:";
            // 
            // lblEstadoFisico
            // 
            this.lblEstadoFisico.AutoSize = true;
            this.lblEstadoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFisico.Location = new System.Drawing.Point(9, 217);
            this.lblEstadoFisico.Name = "lblEstadoFisico";
            this.lblEstadoFisico.Size = new System.Drawing.Size(93, 16);
            this.lblEstadoFisico.TabIndex = 7;
            this.lblEstadoFisico.Text = "Estado Fisico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Costo Unitario:";
            // 
            // lblClavePresupuestal
            // 
            this.lblClavePresupuestal.AutoSize = true;
            this.lblClavePresupuestal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClavePresupuestal.Location = new System.Drawing.Point(9, 77);
            this.lblClavePresupuestal.Name = "lblClavePresupuestal";
            this.lblClavePresupuestal.Size = new System.Drawing.Size(128, 16);
            this.lblClavePresupuestal.TabIndex = 5;
            this.lblClavePresupuestal.Text = "Clave Presupuestal:";
            // 
            // lblClaveCabms
            // 
            this.lblClaveCabms.AutoSize = true;
            this.lblClaveCabms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCabms.Location = new System.Drawing.Point(6, 20);
            this.lblClaveCabms.Name = "lblClaveCabms";
            this.lblClaveCabms.Size = new System.Drawing.Size(96, 16);
            this.lblClaveCabms.TabIndex = 4;
            this.lblClaveCabms.Text = "Clave CABMS:";
            // 
            // lblDescripcionClaveCabms
            // 
            this.lblDescripcionClaveCabms.AutoSize = true;
            this.lblDescripcionClaveCabms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionClaveCabms.Location = new System.Drawing.Point(219, 17);
            this.lblDescripcionClaveCabms.Name = "lblDescripcionClaveCabms";
            this.lblDescripcionClaveCabms.Size = new System.Drawing.Size(0, 16);
            this.lblDescripcionClaveCabms.TabIndex = 3;
            // 
            // txtClaveCabms
            // 
            this.txtClaveCabms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveCabms.Location = new System.Drawing.Point(151, 13);
            this.txtClaveCabms.Name = "txtClaveCabms";
            this.txtClaveCabms.Size = new System.Drawing.Size(169, 22);
            this.txtClaveCabms.TabIndex = 2;
            this.txtClaveCabms.TextChanged += new System.EventHandler(this.txtClaveCabms_TextChanged);
            this.txtClaveCabms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveCabms_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.YellowGreen;
            this.tabPage2.Controls.Add(this.dtpFechaAlta);
            this.tabPage2.Controls.Add(this.txtFecha);
            this.tabPage2.Controls.Add(this.lblNotas);
            this.tabPage2.Controls.Add(this.txtNotas);
            this.tabPage2.Controls.Add(this.lblFechaAlta);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.txtNS);
            this.tabPage2.Controls.Add(this.txtModelo);
            this.tabPage2.Controls.Add(this.lblDonacion);
            this.tabPage2.Controls.Add(this.txtMarca);
            this.tabPage2.Controls.Add(this.lblNumeroDeSerie);
            this.tabPage2.Controls.Add(this.lblModelo);
            this.tabPage2.Controls.Add(this.lblMarca);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Otra Informacion";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(429, 55);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAlta.TabIndex = 14;
            this.dtpFechaAlta.ValueChanged += new System.EventHandler(this.dtpFechaAlta_ValueChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(429, 29);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 13;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(474, 133);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(47, 16);
            this.lblNotas.TabIndex = 12;
            this.lblNotas.Text = "Notas:";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(328, 149);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(330, 140);
            this.txtNotas.TabIndex = 11;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(325, 29);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(93, 16);
            this.lblFechaAlta.TabIndex = 9;
            this.lblFechaAlta.Text = "Fecha de alta:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDonacionNo);
            this.panel1.Controls.Add(this.rbDonacionSi);
            this.panel1.Location = new System.Drawing.Point(111, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 27);
            this.panel1.TabIndex = 8;
            // 
            // rbDonacionNo
            // 
            this.rbDonacionNo.AutoSize = true;
            this.rbDonacionNo.Checked = true;
            this.rbDonacionNo.Location = new System.Drawing.Point(79, 2);
            this.rbDonacionNo.Name = "rbDonacionNo";
            this.rbDonacionNo.Size = new System.Drawing.Size(39, 17);
            this.rbDonacionNo.TabIndex = 1;
            this.rbDonacionNo.TabStop = true;
            this.rbDonacionNo.Text = "No";
            this.rbDonacionNo.UseVisualStyleBackColor = true;
            // 
            // rbDonacionSi
            // 
            this.rbDonacionSi.AutoSize = true;
            this.rbDonacionSi.Location = new System.Drawing.Point(21, 3);
            this.rbDonacionSi.Name = "rbDonacionSi";
            this.rbDonacionSi.Size = new System.Drawing.Size(34, 17);
            this.rbDonacionSi.TabIndex = 0;
            this.rbDonacionSi.Text = "Si";
            this.rbDonacionSi.UseVisualStyleBackColor = true;
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(120, 177);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(100, 20);
            this.txtNS.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(120, 106);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 6;
            // 
            // lblDonacion
            // 
            this.lblDonacion.AutoSize = true;
            this.lblDonacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonacion.Location = new System.Drawing.Point(32, 255);
            this.lblDonacion.Name = "lblDonacion";
            this.lblDonacion.Size = new System.Drawing.Size(69, 16);
            this.lblDonacion.TabIndex = 4;
            this.lblDonacion.Text = "Donacion:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(120, 29);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // lblNumeroDeSerie
            // 
            this.lblNumeroDeSerie.AutoSize = true;
            this.lblNumeroDeSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeSerie.Location = new System.Drawing.Point(33, 182);
            this.lblNumeroDeSerie.Name = "lblNumeroDeSerie";
            this.lblNumeroDeSerie.Size = new System.Drawing.Size(34, 16);
            this.lblNumeroDeSerie.TabIndex = 2;
            this.lblNumeroDeSerie.Text = "N/S:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(33, 106);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(57, 16);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(33, 37);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(49, 16);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // tabImagen
            // 
            this.tabImagen.BackColor = System.Drawing.Color.YellowGreen;
            this.tabImagen.Controls.Add(this.btnSinImagen);
            this.tabImagen.Controls.Add(this.label4);
            this.tabImagen.Controls.Add(this.txtNombreImagen);
            this.tabImagen.Controls.Add(this.label3);
            this.tabImagen.Controls.Add(this.btnSelecImagen);
            this.tabImagen.Controls.Add(this.pbImagen);
            this.tabImagen.Location = new System.Drawing.Point(4, 22);
            this.tabImagen.Name = "tabImagen";
            this.tabImagen.Padding = new System.Windows.Forms.Padding(3);
            this.tabImagen.Size = new System.Drawing.Size(701, 344);
            this.tabImagen.TabIndex = 2;
            this.tabImagen.Text = "Imagen";
            // 
            // btnSinImagen
            // 
            this.btnSinImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSinImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinImagen.Location = new System.Drawing.Point(438, 24);
            this.btnSinImagen.Name = "btnSinImagen";
            this.btnSinImagen.Size = new System.Drawing.Size(87, 31);
            this.btnSinImagen.TabIndex = 6;
            this.btnSinImagen.Text = "Sin imagen";
            this.btnSinImagen.UseVisualStyleBackColor = false;
            this.btnSinImagen.Click += new System.EventHandler(this.btnSinImagen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre del archivo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombreImagen
            // 
            this.txtNombreImagen.Location = new System.Drawing.Point(374, 80);
            this.txtNombreImagen.Name = "txtNombreImagen";
            this.txtNombreImagen.Size = new System.Drawing.Size(67, 20);
            this.txtNombreImagen.TabIndex = 4;
            this.txtNombreImagen.TextChanged += new System.EventHandler(this.txtNombreImagen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccionar imagen..";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSelecImagen
            // 
            this.btnSelecImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelecImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecImagen.Location = new System.Drawing.Point(189, 24);
            this.btnSelecImagen.Name = "btnSelecImagen";
            this.btnSelecImagen.Size = new System.Drawing.Size(84, 31);
            this.btnSelecImagen.TabIndex = 1;
            this.btnSelecImagen.Text = "Seleccionar";
            this.btnSelecImagen.UseVisualStyleBackColor = false;
            this.btnSelecImagen.Click += new System.EventHandler(this.btnSelecImagen_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(189, 103);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(329, 226);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // btnInsertarArticulo
            // 
            this.btnInsertarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInsertarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarArticulo.Location = new System.Drawing.Point(184, 417);
            this.btnInsertarArticulo.Name = "btnInsertarArticulo";
            this.btnInsertarArticulo.Size = new System.Drawing.Size(95, 39);
            this.btnInsertarArticulo.TabIndex = 1;
            this.btnInsertarArticulo.Text = "Agregar Artículo";
            this.btnInsertarArticulo.UseVisualStyleBackColor = false;
            this.btnInsertarArticulo.Click += new System.EventHandler(this.btnInsertarArticulo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(481, 417);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(95, 38);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agregar un nuevo artículo";
            // 
            // FormAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnInsertarArticulo);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar artículo al inventario";
            this.Load += new System.EventHandler(this.FormAgregarArticulo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabImagen.ResumeLayout(false);
            this.tabImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblDescripcionClaveCabms;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox txtClaveCabms;
        private System.Windows.Forms.Label lblClaveCabms;
        private System.Windows.Forms.Label lblClavePresupuestal;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblResguardatario;
        private System.Windows.Forms.Label lblEstadoFisico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboResguardatario;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.ComboBox cboEstadoFisico;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblNumeroDeSerie;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblDonacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDonacionNo;
        private System.Windows.Forms.RadioButton rbDonacionSi;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Button btnInsertarArticulo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabImagen;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelecImagen;
        private System.Windows.Forms.Button btnSinImagen;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtClavePresupuestal;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
    }
}