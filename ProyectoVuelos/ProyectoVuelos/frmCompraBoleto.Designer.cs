namespace ProyectoVuelos {
	partial class frmCompraBoleto {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraBoleto));
            this.cmbCveVuelo = new System.Windows.Forms.ComboBox();
            this.chkClubPremier = new System.Windows.Forms.CheckBox();
            this.txtNombrePasajero = new System.Windows.Forms.TextBox();
            this.txtClaveBoleto = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.grpClubPremier = new System.Windows.Forms.GroupBox();
            this.txtClavePremier = new System.Windows.Forms.TextBox();
            this.lblCvePremier = new System.Windows.Forms.Label();
            this.lblCveVuelo = new System.Windows.Forms.Label();
            this.grpVuelo = new System.Windows.Forms.GroupBox();
            this.lblHora1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCveBoleto = new System.Windows.Forms.Label();
            this.errorPCvePremier = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPEdad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegresar = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtEdad = new System.Windows.Forms.NumericUpDown();
            this.btnComprar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblTitutlo = new System.Windows.Forms.Label();
            this.grpClubPremier.SuspendLayout();
            this.grpVuelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPCvePremier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPNombre)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCveVuelo
            // 
            this.cmbCveVuelo.FormattingEnabled = true;
            this.cmbCveVuelo.Location = new System.Drawing.Point(9, 70);
            this.cmbCveVuelo.Name = "cmbCveVuelo";
            this.cmbCveVuelo.Size = new System.Drawing.Size(200, 26);
            this.cmbCveVuelo.TabIndex = 0;
            this.cmbCveVuelo.SelectedIndexChanged += new System.EventHandler(this.cmbCveVuelo_SelectedIndexChanged);
            // 
            // chkClubPremier
            // 
            this.chkClubPremier.AutoSize = true;
            this.chkClubPremier.Location = new System.Drawing.Point(21, 34);
            this.chkClubPremier.Name = "chkClubPremier";
            this.chkClubPremier.Size = new System.Drawing.Size(97, 22);
            this.chkClubPremier.TabIndex = 1;
            this.chkClubPremier.Text = "¡Soy parte!";
            this.chkClubPremier.UseVisualStyleBackColor = true;
            this.chkClubPremier.CheckedChanged += new System.EventHandler(this.chkClubPremier_CheckedChanged);
            // 
            // txtNombrePasajero
            // 
            this.txtNombrePasajero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNombrePasajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombrePasajero.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePasajero.Location = new System.Drawing.Point(306, 271);
            this.txtNombrePasajero.Name = "txtNombrePasajero";
            this.txtNombrePasajero.Size = new System.Drawing.Size(201, 25);
            this.txtNombrePasajero.TabIndex = 2;
            this.txtNombrePasajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePasajero_KeyPress);
            this.txtNombrePasajero.Leave += new System.EventHandler(this.txtNombrePasajero_Leave);
            // 
            // txtClaveBoleto
            // 
            this.txtClaveBoleto.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveBoleto.Location = new System.Drawing.Point(37, 85);
            this.txtClaveBoleto.Name = "txtClaveBoleto";
            this.txtClaveBoleto.ReadOnly = true;
            this.txtClaveBoleto.Size = new System.Drawing.Size(182, 25);
            this.txtClaveBoleto.TabIndex = 3;
            // 
            // txtOrigen
            // 
            this.txtOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrigen.Location = new System.Drawing.Point(9, 120);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(200, 25);
            this.txtOrigen.TabIndex = 5;
            // 
            // txtDestino
            // 
            this.txtDestino.AcceptsReturn = true;
            this.txtDestino.AcceptsTab = true;
            this.txtDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDestino.Location = new System.Drawing.Point(9, 186);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(200, 25);
            this.txtDestino.TabIndex = 6;
            // 
            // grpClubPremier
            // 
            this.grpClubPremier.BackColor = System.Drawing.Color.Transparent;
            this.grpClubPremier.Controls.Add(this.txtClavePremier);
            this.grpClubPremier.Controls.Add(this.lblCvePremier);
            this.grpClubPremier.Controls.Add(this.chkClubPremier);
            this.grpClubPremier.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClubPremier.Location = new System.Drawing.Point(309, 70);
            this.grpClubPremier.Name = "grpClubPremier";
            this.grpClubPremier.Size = new System.Drawing.Size(198, 133);
            this.grpClubPremier.TabIndex = 7;
            this.grpClubPremier.TabStop = false;
            this.grpClubPremier.Text = "Club Premier";
            // 
            // txtClavePremier
            // 
            this.txtClavePremier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtClavePremier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClavePremier.Enabled = false;
            this.txtClavePremier.Location = new System.Drawing.Point(17, 88);
            this.txtClavePremier.MaxLength = 8;
            this.txtClavePremier.Name = "txtClavePremier";
            this.txtClavePremier.Size = new System.Drawing.Size(157, 25);
            this.txtClavePremier.TabIndex = 3;
            this.txtClavePremier.Visible = false;
            this.txtClavePremier.AcceptsTabChanged += new System.EventHandler(this.txtClavePremier_AcceptsTabChanged);
            this.txtClavePremier.Enter += new System.EventHandler(this.txtClavePremier_AcceptsTabChanged);
            this.txtClavePremier.Leave += new System.EventHandler(this.txtClavePremier_Leave);
            // 
            // lblCvePremier
            // 
            this.lblCvePremier.AutoSize = true;
            this.lblCvePremier.Enabled = false;
            this.lblCvePremier.Location = new System.Drawing.Point(18, 59);
            this.lblCvePremier.Name = "lblCvePremier";
            this.lblCvePremier.Size = new System.Drawing.Size(51, 18);
            this.lblCvePremier.TabIndex = 2;
            this.lblCvePremier.Text = "Clave:";
            this.lblCvePremier.Visible = false;
            // 
            // lblCveVuelo
            // 
            this.lblCveVuelo.AutoSize = true;
            this.lblCveVuelo.Location = new System.Drawing.Point(6, 47);
            this.lblCveVuelo.Name = "lblCveVuelo";
            this.lblCveVuelo.Size = new System.Drawing.Size(47, 18);
            this.lblCveVuelo.TabIndex = 9;
            this.lblCveVuelo.Text = "Clave";
            // 
            // grpVuelo
            // 
            this.grpVuelo.BackColor = System.Drawing.Color.Transparent;
            this.grpVuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpVuelo.Controls.Add(this.lblHora1);
            this.grpVuelo.Controls.Add(this.lblHora);
            this.grpVuelo.Controls.Add(this.label1);
            this.grpVuelo.Controls.Add(this.dateTimePicker1);
            this.grpVuelo.Controls.Add(this.lblDestino);
            this.grpVuelo.Controls.Add(this.lblOrigen);
            this.grpVuelo.Controls.Add(this.lblCveVuelo);
            this.grpVuelo.Controls.Add(this.cmbCveVuelo);
            this.grpVuelo.Controls.Add(this.txtOrigen);
            this.grpVuelo.Controls.Add(this.txtDestino);
            this.grpVuelo.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVuelo.ForeColor = System.Drawing.Color.Black;
            this.grpVuelo.Location = new System.Drawing.Point(37, 129);
            this.grpVuelo.Name = "grpVuelo";
            this.grpVuelo.Size = new System.Drawing.Size(232, 338);
            this.grpVuelo.TabIndex = 10;
            this.grpVuelo.TabStop = false;
            this.grpVuelo.Text = "VUELO";
            // 
            // lblHora1
            // 
            this.lblHora1.AutoSize = true;
            this.lblHora1.Location = new System.Drawing.Point(10, 293);
            this.lblHora1.Name = "lblHora1";
            this.lblHora1.Size = new System.Drawing.Size(43, 18);
            this.lblHora1.TabIndex = 28;
            this.lblHora1.Text = "Hora:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(75, 293);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(55, 19);
            this.lblHora.TabIndex = 27;
            this.lblHora.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 150);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(57, 18);
            this.lblDestino.TabIndex = 11;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 99);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(53, 18);
            this.lblOrigen.TabIndex = 10;
            this.lblOrigen.Text = "Origen";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(306, 246);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 18);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Edad";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(306, 387);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(47, 18);
            this.lblCosto.TabIndex = 15;
            this.lblCosto.Text = "Costo";
            // 
            // lblCveBoleto
            // 
            this.lblCveBoleto.AutoSize = true;
            this.lblCveBoleto.BackColor = System.Drawing.Color.Transparent;
            this.lblCveBoleto.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCveBoleto.Location = new System.Drawing.Point(37, 55);
            this.lblCveBoleto.Name = "lblCveBoleto";
            this.lblCveBoleto.Size = new System.Drawing.Size(94, 18);
            this.lblCveBoleto.TabIndex = 17;
            this.lblCveBoleto.Text = "Clave boleto";
            // 
            // errorPCvePremier
            // 
            this.errorPCvePremier.ContainerControl = this;
            // 
            // errorPEdad
            // 
            this.errorPEdad.ContainerControl = this;
            // 
            // errorPNombre
            // 
            this.errorPNombre.ContainerControl = this;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Advantage", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(372, 375);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(76, 32);
            this.lblCostoTotal.TabIndex = 26;
            this.lblCostoTotal.Text = "$ 0.0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblTitutlo);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 44);
            this.panel2.TabIndex = 27;
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
            this.btnRegresar.Location = new System.Drawing.Point(-13, 6);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(76, 38);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdad.Location = new System.Drawing.Point(306, 338);
            this.txtEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(204, 20);
            this.txtEdad.TabIndex = 28;
            this.txtEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // btnComprar
            // 
            this.btnComprar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnComprar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComprar.BorderRadius = 0;
            this.btnComprar.ButtonText = "Comprar";
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.DisabledColor = System.Drawing.Color.Gray;
            this.btnComprar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnComprar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnComprar.Iconimage")));
            this.btnComprar.Iconimage_right = null;
            this.btnComprar.Iconimage_right_Selected = null;
            this.btnComprar.Iconimage_Selected = null;
            this.btnComprar.IconMarginLeft = 0;
            this.btnComprar.IconMarginRight = 0;
            this.btnComprar.IconRightVisible = true;
            this.btnComprar.IconRightZoom = 0D;
            this.btnComprar.IconVisible = true;
            this.btnComprar.IconZoom = 90D;
            this.btnComprar.IsTab = false;
            this.btnComprar.Location = new System.Drawing.Point(302, 419);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnComprar.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnComprar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnComprar.selected = false;
            this.btnComprar.Size = new System.Drawing.Size(205, 48);
            this.btnComprar.TabIndex = 29;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnComprar.Textcolor = System.Drawing.Color.White;
            this.btnComprar.TextFont = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Advantage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(322, 216);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(164, 19);
            this.lblDatos.TabIndex = 30;
            this.lblDatos.Text = "DATOS DEL PASAJERO";
            // 
            // lblTitutlo
            // 
            this.lblTitutlo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitutlo.Font = new System.Drawing.Font("Advantage", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutlo.ForeColor = System.Drawing.Color.White;
            this.lblTitutlo.Location = new System.Drawing.Point(154, 6);
            this.lblTitutlo.Name = "lblTitutlo";
            this.lblTitutlo.Size = new System.Drawing.Size(224, 35);
            this.lblTitutlo.TabIndex = 18;
            this.lblTitutlo.Text = "VENTA DE BOLETOS";
            this.lblTitutlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCompraBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(534, 486);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.lblCveBoleto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.grpVuelo);
            this.Controls.Add(this.grpClubPremier);
            this.Controls.Add(this.txtClaveBoleto);
            this.Controls.Add(this.txtNombrePasajero);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompraBoleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTA DE BOLETOS";
            this.Load += new System.EventHandler(this.frmCompraBoleto_Load);
            this.grpClubPremier.ResumeLayout(false);
            this.grpClubPremier.PerformLayout();
            this.grpVuelo.ResumeLayout(false);
            this.grpVuelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPCvePremier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPNombre)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbCveVuelo;
		private System.Windows.Forms.CheckBox chkClubPremier;
		private System.Windows.Forms.TextBox txtNombrePasajero;
		private System.Windows.Forms.TextBox txtClaveBoleto;
		private System.Windows.Forms.TextBox txtOrigen;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.GroupBox grpClubPremier;
		private System.Windows.Forms.Label lblCveVuelo;
		private System.Windows.Forms.GroupBox grpVuelo;
		private System.Windows.Forms.Label lblDestino;
		private System.Windows.Forms.Label lblOrigen;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblCosto;
		private System.Windows.Forms.Label lblCveBoleto;
		private System.Windows.Forms.TextBox txtClavePremier;
		private System.Windows.Forms.Label lblCvePremier;
		private System.Windows.Forms.ErrorProvider errorPCvePremier;
		private System.Windows.Forms.ErrorProvider errorPEdad;
		private System.Windows.Forms.ErrorProvider errorPNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblHora1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton btnRegresar;
        private System.Windows.Forms.Label lblDatos;
        private Bunifu.Framework.UI.BunifuFlatButton btnComprar;
        private System.Windows.Forms.NumericUpDown txtEdad;
        private System.Windows.Forms.Label lblTitutlo;
    }
}