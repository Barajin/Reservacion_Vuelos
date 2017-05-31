namespace ProyectoVuelos {
	partial class frmAltaClubPremier {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaClubPremier));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.lblClave = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblDomicilio = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.errorPNombre = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.lblEdad = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorPNombre)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Controls.Add(this.txtEdad);
			this.panel1.Controls.Add(this.lblEdad);
			this.panel1.Controls.Add(this.lblTitulo);
			this.panel1.Controls.Add(this.txtClave);
			this.panel1.Controls.Add(this.lblClave);
			this.panel1.Controls.Add(this.txtDomicilio);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Controls.Add(this.lblDomicilio);
			this.panel1.Controls.Add(this.lblNombre);
			this.panel1.Controls.Add(this.btnGuardar);
			this.panel1.Location = new System.Drawing.Point(32, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(445, 356);
			this.panel1.TabIndex = 0;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(157, 24);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(128, 26);
			this.lblTitulo.TabIndex = 8;
			this.lblTitulo.Text = "Club Premier";
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(139, 74);
			this.txtClave.Name = "txtClave";
			this.txtClave.ReadOnly = true;
			this.txtClave.Size = new System.Drawing.Size(241, 20);
			this.txtClave.TabIndex = 7;
			// 
			// lblClave
			// 
			this.lblClave.AutoSize = true;
			this.lblClave.Location = new System.Drawing.Point(66, 77);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(34, 13);
			this.lblClave.TabIndex = 6;
			this.lblClave.Text = "Clave";
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDomicilio.Location = new System.Drawing.Point(139, 157);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(241, 20);
			this.txtDomicilio.TabIndex = 1;
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Location = new System.Drawing.Point(139, 113);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(241, 20);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// lblDomicilio
			// 
			this.lblDomicilio.AutoSize = true;
			this.lblDomicilio.Location = new System.Drawing.Point(66, 160);
			this.lblDomicilio.Name = "lblDomicilio";
			this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
			this.lblDomicilio.TabIndex = 2;
			this.lblDomicilio.Text = "Domicilio";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(66, 116);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(44, 13);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnGuardar.Location = new System.Drawing.Point(162, 284);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(124, 47);
			this.btnGuardar.TabIndex = 2;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// errorPNombre
			// 
			this.errorPNombre.ContainerControl = this;
			// 
			// txtEdad
			// 
			this.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEdad.Location = new System.Drawing.Point(139, 198);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(241, 20);
			this.txtEdad.TabIndex = 9;
			this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
			// 
			// lblEdad
			// 
			this.lblEdad.AutoSize = true;
			this.lblEdad.Location = new System.Drawing.Point(66, 201);
			this.lblEdad.Name = "lblEdad";
			this.lblEdad.Size = new System.Drawing.Size(32, 13);
			this.lblEdad.TabIndex = 10;
			this.lblEdad.Text = "Edad";
			// 
			// frmAltaClubPremier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ProyectoVuelos.Properties.Resources.bg;
			this.ClientSize = new System.Drawing.Size(507, 414);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAltaClubPremier";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CLUB PREMIER";
			this.Load += new System.EventHandler(this.frmAltaClubPremier_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorPNombre)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label lblClave;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblDomicilio;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.ErrorProvider errorPNombre;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.Label lblEdad;
	}
}