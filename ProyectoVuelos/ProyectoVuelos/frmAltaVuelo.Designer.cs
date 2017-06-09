namespace ProyectoVuelos {
	partial class frmAltaVuelo {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaVuelo));
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.grpDias = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkFecha4 = new System.Windows.Forms.CheckBox();
            this.chkFecha1 = new System.Windows.Forms.CheckBox();
            this.chkFecha3 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkFecha2 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtMillas = new System.Windows.Forms.TextBox();
            this.txtCveVuelo = new System.Windows.Forms.TextBox();
            this.lblCveVuelo = new System.Windows.Forms.Label();
            this.lblNumPasajeros = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblMillas = new System.Windows.Forms.Label();
            this.numericNumPasajeros = new System.Windows.Forms.NumericUpDown();
            this.errorPCosto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPMillas = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker0 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblFecha = new System.Windows.Forms.Label();
            this.grpDias.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPMillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrigen.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(105, 130);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 27);
            this.cmbOrigen.TabIndex = 1;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // cmbDestino
            // 
            this.cmbDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDestino.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(105, 184);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 27);
            this.cmbDestino.TabIndex = 2;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // grpDias
            // 
            this.grpDias.BackColor = System.Drawing.Color.Transparent;
            this.grpDias.Controls.Add(this.panel1);
            this.grpDias.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDias.Location = new System.Drawing.Point(802, 73);
            this.grpDias.Name = "grpDias";
            this.grpDias.Size = new System.Drawing.Size(273, 357);
            this.grpDias.TabIndex = 6;
            this.grpDias.TabStop = false;
            this.grpDias.Text = "Frecuencia";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkFecha4);
            this.panel1.Controls.Add(this.chkFecha1);
            this.panel1.Controls.Add(this.chkFecha3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.chkFecha2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.dateTimePicker4);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 323);
            this.panel1.TabIndex = 125;
            // 
            // chkFecha4
            // 
            this.chkFecha4.AutoSize = true;
            this.chkFecha4.Location = new System.Drawing.Point(17, 244);
            this.chkFecha4.Name = "chkFecha4";
            this.chkFecha4.Size = new System.Drawing.Size(15, 14);
            this.chkFecha4.TabIndex = 8;
            this.chkFecha4.UseVisualStyleBackColor = true;
            this.chkFecha4.CheckedChanged += new System.EventHandler(this.chkFecha1_CheckedChanged);
            // 
            // chkFecha1
            // 
            this.chkFecha1.AutoSize = true;
            this.chkFecha1.Location = new System.Drawing.Point(17, 48);
            this.chkFecha1.Name = "chkFecha1";
            this.chkFecha1.Size = new System.Drawing.Size(15, 14);
            this.chkFecha1.TabIndex = 5;
            this.chkFecha1.UseVisualStyleBackColor = true;
            this.chkFecha1.CheckedChanged += new System.EventHandler(this.chkFecha1_CheckedChanged);
            // 
            // chkFecha3
            // 
            this.chkFecha3.AutoSize = true;
            this.chkFecha3.Location = new System.Drawing.Point(17, 177);
            this.chkFecha3.Name = "chkFecha3";
            this.chkFecha3.Size = new System.Drawing.Size(15, 14);
            this.chkFecha3.TabIndex = 7;
            this.chkFecha3.UseVisualStyleBackColor = true;
            this.chkFecha3.CheckedChanged += new System.EventHandler(this.chkFecha1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 39);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // chkFecha2
            // 
            this.chkFecha2.AutoSize = true;
            this.chkFecha2.Location = new System.Drawing.Point(17, 110);
            this.chkFecha2.Name = "chkFecha2";
            this.chkFecha2.Size = new System.Drawing.Size(15, 14);
            this.chkFecha2.TabIndex = 6;
            this.chkFecha2.UseVisualStyleBackColor = true;
            this.chkFecha2.CheckedChanged += new System.EventHandler(this.chkFecha1_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(38, 101);
            this.dateTimePicker2.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(38, 168);
            this.dateTimePicker3.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker3.TabIndex = 3;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(38, 240);
            this.dateTimePicker4.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker4.TabIndex = 4;
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(105, 340);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(123, 27);
            this.txtCosto.TabIndex = 4;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // txtMillas
            // 
            this.txtMillas.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMillas.Location = new System.Drawing.Point(105, 239);
            this.txtMillas.Name = "txtMillas";
            this.txtMillas.Size = new System.Drawing.Size(123, 27);
            this.txtMillas.TabIndex = 5;
            this.txtMillas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMillas_KeyPress);
            // 
            // txtCveVuelo
            // 
            this.txtCveVuelo.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCveVuelo.Location = new System.Drawing.Point(105, 80);
            this.txtCveVuelo.Name = "txtCveVuelo";
            this.txtCveVuelo.ReadOnly = true;
            this.txtCveVuelo.Size = new System.Drawing.Size(121, 27);
            this.txtCveVuelo.TabIndex = 0;
            // 
            // lblCveVuelo
            // 
            this.lblCveVuelo.AutoSize = true;
            this.lblCveVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblCveVuelo.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCveVuelo.Location = new System.Drawing.Point(15, 83);
            this.lblCveVuelo.Name = "lblCveVuelo";
            this.lblCveVuelo.Size = new System.Drawing.Size(52, 19);
            this.lblCveVuelo.TabIndex = 7;
            this.lblCveVuelo.Text = "Clave";
            // 
            // lblNumPasajeros
            // 
            this.lblNumPasajeros.AutoSize = true;
            this.lblNumPasajeros.BackColor = System.Drawing.Color.Transparent;
            this.lblNumPasajeros.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPasajeros.Location = new System.Drawing.Point(15, 293);
            this.lblNumPasajeros.Name = "lblNumPasajeros";
            this.lblNumPasajeros.Size = new System.Drawing.Size(76, 19);
            this.lblNumPasajeros.TabIndex = 8;
            this.lblNumPasajeros.Text = "Pasajeros";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigen.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(15, 133);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(58, 19);
            this.lblOrigen.TabIndex = 8;
            this.lblOrigen.Text = "Origen";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(15, 192);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(62, 19);
            this.lblDestino.TabIndex = 9;
            this.lblDestino.Text = "Destino";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(15, 343);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(51, 19);
            this.lblCosto.TabIndex = 123;
            this.lblCosto.Text = "Costo";
            // 
            // lblMillas
            // 
            this.lblMillas.AutoSize = true;
            this.lblMillas.BackColor = System.Drawing.Color.Transparent;
            this.lblMillas.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMillas.Location = new System.Drawing.Point(15, 242);
            this.lblMillas.Name = "lblMillas";
            this.lblMillas.Size = new System.Drawing.Size(47, 19);
            this.lblMillas.TabIndex = 11;
            this.lblMillas.Text = "Millas";
            // 
            // numericNumPasajeros
            // 
            this.numericNumPasajeros.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNumPasajeros.Location = new System.Drawing.Point(105, 291);
            this.numericNumPasajeros.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericNumPasajeros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumPasajeros.Name = "numericNumPasajeros";
            this.numericNumPasajeros.Size = new System.Drawing.Size(123, 27);
            this.numericNumPasajeros.TabIndex = 124;
            this.numericNumPasajeros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errorPCosto
            // 
            this.errorPCosto.ContainerControl = this;
            // 
            // errorPMillas
            // 
            this.errorPMillas.ContainerControl = this;
            // 
            // dateTimePicker0
            // 
            this.dateTimePicker0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker0.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker0.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker0.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker0.Location = new System.Drawing.Point(105, 391);
            this.dateTimePicker0.MaxDate = new System.DateTime(2017, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker0.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker0.Name = "dateTimePicker0";
            this.dateTimePicker0.Size = new System.Drawing.Size(0, 27);
            this.dateTimePicker0.TabIndex = 0;
            this.dateTimePicker0.Value = new System.DateTime(2017, 6, 2, 0, 48, 19, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoVuelos.Properties.Resources.how_to_ovvercome_fear_of_flying_asaptickets_5;
            this.pictureBox1.Location = new System.Drawing.Point(261, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 294);
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegresar.color = System.Drawing.Color.SteelBlue;
            this.btnRegresar.colorActive = System.Drawing.Color.SteelBlue;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Image = global::ProyectoVuelos.Properties.Resources.fic;
            this.btnRegresar.ImagePosition = 0;
            this.btnRegresar.ImageZoom = 50;
            this.btnRegresar.LabelPosition = 0;
            this.btnRegresar.LabelText = "";
            this.btnRegresar.Location = new System.Drawing.Point(-5, 9);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(76, 38);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 53);
            this.panel2.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Advantage", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "ALTA DE VUELOS";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.DimGray;
            this.btnAgregar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 1;
            this.btnAgregar.ButtonText = "Agregar más días";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Iconimage")));
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 90D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(319, 382);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.DarkGray;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(416, 45);
            this.btnAgregar.TabIndex = 128;
            this.btnAgregar.Text = "Agregar más días";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Advantage", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Honeydew;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 20;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.IdleForecolor = System.Drawing.Color.Lavender;
            this.btnGuardar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Location = new System.Drawing.Point(360, 436);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 50);
            this.btnGuardar.TabIndex = 129;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 391);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 19);
            this.lblFecha.TabIndex = 130;
            this.lblFecha.Text = "Fecha";
            // 
            // frmAltaVuelo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 501);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericNumPasajeros);
            this.Controls.Add(this.dateTimePicker0);
            this.Controls.Add(this.lblMillas);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblNumPasajeros);
            this.Controls.Add(this.lblCveVuelo);
            this.Controls.Add(this.txtCveVuelo);
            this.Controls.Add(this.txtMillas);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.grpDias);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbOrigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaVuelo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTA DE VUELOS";
            this.Load += new System.EventHandler(this.frmAltaVuelo_Load);
            this.grpDias.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPMillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbOrigen;
		private System.Windows.Forms.ComboBox cmbDestino;
		private System.Windows.Forms.GroupBox grpDias;
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.TextBox txtMillas;
		private System.Windows.Forms.TextBox txtCveVuelo;
		private System.Windows.Forms.Label lblCveVuelo;
		private System.Windows.Forms.Label lblNumPasajeros;
		private System.Windows.Forms.Label lblOrigen;
		private System.Windows.Forms.Label lblDestino;
		private System.Windows.Forms.Label lblCosto;
		private System.Windows.Forms.Label lblMillas;
		private System.Windows.Forms.NumericUpDown numericNumPasajeros;
		private System.Windows.Forms.ErrorProvider errorPCosto;
		private System.Windows.Forms.ErrorProvider errorPMillas;
        private System.Windows.Forms.CheckBox chkFecha4;
        private System.Windows.Forms.CheckBox chkFecha3;
        private System.Windows.Forms.CheckBox chkFecha2;
        private System.Windows.Forms.CheckBox chkFecha1;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton btnRegresar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
    }
}