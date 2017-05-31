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
			this.lblDestino = new System.Windows.Forms.Label();
			this.lblOrigen = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblCosto = new System.Windows.Forms.Label();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.btnComprar = new System.Windows.Forms.Button();
			this.lblCveBoleto = new System.Windows.Forms.Label();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.errorPCvePremier = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorPEdad = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorPNombre = new System.Windows.Forms.ErrorProvider(this.components);
			this.grpClubPremier.SuspendLayout();
			this.grpVuelo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorPCvePremier)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorPEdad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorPNombre)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbCveVuelo
			// 
			this.cmbCveVuelo.FormattingEnabled = true;
			this.cmbCveVuelo.Location = new System.Drawing.Point(6, 49);
			this.cmbCveVuelo.Name = "cmbCveVuelo";
			this.cmbCveVuelo.Size = new System.Drawing.Size(139, 21);
			this.cmbCveVuelo.TabIndex = 0;
			this.cmbCveVuelo.SelectedIndexChanged += new System.EventHandler(this.cmbCveVuelo_SelectedIndexChanged);
			// 
			// chkClubPremier
			// 
			this.chkClubPremier.AutoSize = true;
			this.chkClubPremier.Location = new System.Drawing.Point(25, 22);
			this.chkClubPremier.Name = "chkClubPremier";
			this.chkClubPremier.Size = new System.Drawing.Size(77, 17);
			this.chkClubPremier.TabIndex = 1;
			this.chkClubPremier.Text = "¡Soy parte!";
			this.chkClubPremier.UseVisualStyleBackColor = true;
			this.chkClubPremier.CheckedChanged += new System.EventHandler(this.chkClubPremier_CheckedChanged);
			// 
			// txtNombrePasajero
			// 
			this.txtNombrePasajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombrePasajero.Location = new System.Drawing.Point(272, 131);
			this.txtNombrePasajero.Name = "txtNombrePasajero";
			this.txtNombrePasajero.Size = new System.Drawing.Size(152, 20);
			this.txtNombrePasajero.TabIndex = 2;
			this.txtNombrePasajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePasajero_KeyPress);
			// 
			// txtClaveBoleto
			// 
			this.txtClaveBoleto.Location = new System.Drawing.Point(29, 36);
			this.txtClaveBoleto.Name = "txtClaveBoleto";
			this.txtClaveBoleto.ReadOnly = true;
			this.txtClaveBoleto.Size = new System.Drawing.Size(168, 20);
			this.txtClaveBoleto.TabIndex = 3;
			// 
			// txtOrigen
			// 
			this.txtOrigen.Location = new System.Drawing.Point(6, 106);
			this.txtOrigen.Name = "txtOrigen";
			this.txtOrigen.ReadOnly = true;
			this.txtOrigen.Size = new System.Drawing.Size(139, 20);
			this.txtOrigen.TabIndex = 5;
			// 
			// txtDestino
			// 
			this.txtDestino.Location = new System.Drawing.Point(6, 161);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.ReadOnly = true;
			this.txtDestino.Size = new System.Drawing.Size(139, 20);
			this.txtDestino.TabIndex = 6;
			// 
			// grpClubPremier
			// 
			this.grpClubPremier.BackColor = System.Drawing.Color.Transparent;
			this.grpClubPremier.Controls.Add(this.txtClavePremier);
			this.grpClubPremier.Controls.Add(this.lblCvePremier);
			this.grpClubPremier.Controls.Add(this.chkClubPremier);
			this.grpClubPremier.Location = new System.Drawing.Point(272, 16);
			this.grpClubPremier.Name = "grpClubPremier";
			this.grpClubPremier.Size = new System.Drawing.Size(152, 86);
			this.grpClubPremier.TabIndex = 7;
			this.grpClubPremier.TabStop = false;
			this.grpClubPremier.Text = "Club Premier";
			// 
			// txtClavePremier
			// 
			this.txtClavePremier.Enabled = false;
			this.txtClavePremier.Location = new System.Drawing.Point(15, 60);
			this.txtClavePremier.Name = "txtClavePremier";
			this.txtClavePremier.Size = new System.Drawing.Size(100, 20);
			this.txtClavePremier.TabIndex = 3;
			this.txtClavePremier.Visible = false;
			this.txtClavePremier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClavePremier_KeyPress);
			this.txtClavePremier.Leave += new System.EventHandler(this.txtClavePremier_Leave);
			// 
			// lblCvePremier
			// 
			this.lblCvePremier.AutoSize = true;
			this.lblCvePremier.Enabled = false;
			this.lblCvePremier.Location = new System.Drawing.Point(43, 44);
			this.lblCvePremier.Name = "lblCvePremier";
			this.lblCvePremier.Size = new System.Drawing.Size(37, 13);
			this.lblCvePremier.TabIndex = 2;
			this.lblCvePremier.Text = "Clave:";
			this.lblCvePremier.Visible = false;
			// 
			// lblCveVuelo
			// 
			this.lblCveVuelo.AutoSize = true;
			this.lblCveVuelo.Location = new System.Drawing.Point(3, 33);
			this.lblCveVuelo.Name = "lblCveVuelo";
			this.lblCveVuelo.Size = new System.Drawing.Size(34, 13);
			this.lblCveVuelo.TabIndex = 9;
			this.lblCveVuelo.Text = "Clave";
			// 
			// grpVuelo
			// 
			this.grpVuelo.BackColor = System.Drawing.Color.Transparent;
			this.grpVuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.grpVuelo.Controls.Add(this.lblDestino);
			this.grpVuelo.Controls.Add(this.lblOrigen);
			this.grpVuelo.Controls.Add(this.lblCveVuelo);
			this.grpVuelo.Controls.Add(this.cmbCveVuelo);
			this.grpVuelo.Controls.Add(this.txtOrigen);
			this.grpVuelo.Controls.Add(this.txtDestino);
			this.grpVuelo.ForeColor = System.Drawing.Color.Black;
			this.grpVuelo.Location = new System.Drawing.Point(29, 72);
			this.grpVuelo.Name = "grpVuelo";
			this.grpVuelo.Size = new System.Drawing.Size(168, 210);
			this.grpVuelo.TabIndex = 10;
			this.grpVuelo.TabStop = false;
			this.grpVuelo.Text = "VUELO";
			// 
			// lblDestino
			// 
			this.lblDestino.AutoSize = true;
			this.lblDestino.Location = new System.Drawing.Point(3, 136);
			this.lblDestino.Name = "lblDestino";
			this.lblDestino.Size = new System.Drawing.Size(43, 13);
			this.lblDestino.TabIndex = 11;
			this.lblDestino.Text = "Destino";
			// 
			// lblOrigen
			// 
			this.lblOrigen.AutoSize = true;
			this.lblOrigen.Location = new System.Drawing.Point(3, 85);
			this.lblOrigen.Name = "lblOrigen";
			this.lblOrigen.Size = new System.Drawing.Size(38, 13);
			this.lblOrigen.TabIndex = 10;
			this.lblOrigen.Text = "Origen";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.BackColor = System.Drawing.Color.Transparent;
			this.lblNombre.Location = new System.Drawing.Point(272, 112);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(44, 13);
			this.lblNombre.TabIndex = 11;
			this.lblNombre.Text = "Nombre";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(272, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Edad";
			// 
			// lblCosto
			// 
			this.lblCosto.AutoSize = true;
			this.lblCosto.BackColor = System.Drawing.Color.Transparent;
			this.lblCosto.Location = new System.Drawing.Point(272, 214);
			this.lblCosto.Name = "lblCosto";
			this.lblCosto.Size = new System.Drawing.Size(34, 13);
			this.lblCosto.TabIndex = 15;
			this.lblCosto.Text = "Costo";
			// 
			// txtCosto
			// 
			this.txtCosto.Location = new System.Drawing.Point(272, 233);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.ReadOnly = true;
			this.txtCosto.Size = new System.Drawing.Size(152, 20);
			this.txtCosto.TabIndex = 14;
			// 
			// btnComprar
			// 
			this.btnComprar.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnComprar.ForeColor = System.Drawing.Color.White;
			this.btnComprar.Location = new System.Drawing.Point(175, 310);
			this.btnComprar.Name = "btnComprar";
			this.btnComprar.Size = new System.Drawing.Size(131, 46);
			this.btnComprar.TabIndex = 16;
			this.btnComprar.Text = "Comprar boleto";
			this.btnComprar.UseVisualStyleBackColor = false;
			this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
			// 
			// lblCveBoleto
			// 
			this.lblCveBoleto.AutoSize = true;
			this.lblCveBoleto.BackColor = System.Drawing.Color.Transparent;
			this.lblCveBoleto.Location = new System.Drawing.Point(29, 13);
			this.lblCveBoleto.Name = "lblCveBoleto";
			this.lblCveBoleto.Size = new System.Drawing.Size(66, 13);
			this.lblCveBoleto.TabIndex = 17;
			this.lblCveBoleto.Text = "Clave boleto";
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(272, 185);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(152, 20);
			this.txtEdad.TabIndex = 18;
			this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
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
			// frmCompraBoleto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ProyectoVuelos.Properties.Resources.asdf;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(492, 453);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.lblCveBoleto);
			this.Controls.Add(this.btnComprar);
			this.Controls.Add(this.lblCosto);
			this.Controls.Add(this.txtCosto);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.grpVuelo);
			this.Controls.Add(this.grpClubPremier);
			this.Controls.Add(this.txtClaveBoleto);
			this.Controls.Add(this.txtNombrePasajero);
			this.DoubleBuffered = true;
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
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.Button btnComprar;
		private System.Windows.Forms.Label lblCveBoleto;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.TextBox txtClavePremier;
		private System.Windows.Forms.Label lblCvePremier;
		private System.Windows.Forms.ErrorProvider errorPCvePremier;
		private System.Windows.Forms.ErrorProvider errorPEdad;
		private System.Windows.Forms.ErrorProvider errorPNombre;
	}
}