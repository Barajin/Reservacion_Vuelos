namespace ProyectoVuelos {
	partial class frmConsultaClubPremier {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaClubPremier));
			this.cmbCve = new System.Windows.Forms.ComboBox();
			this.lblClave = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.txtMillas = new System.Windows.Forms.TextBox();
			this.lblDomicilio = new System.Windows.Forms.Label();
			this.lblMillas = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmbCve
			// 
			this.cmbCve.FormattingEnabled = true;
			this.cmbCve.Location = new System.Drawing.Point(42, 31);
			this.cmbCve.Name = "cmbCve";
			this.cmbCve.Size = new System.Drawing.Size(200, 21);
			this.cmbCve.TabIndex = 0;
			this.cmbCve.SelectedIndexChanged += new System.EventHandler(this.cmbCve_SelectedIndexChanged);
			// 
			// lblClave
			// 
			this.lblClave.AutoSize = true;
			this.lblClave.BackColor = System.Drawing.Color.Transparent;
			this.lblClave.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
			this.lblClave.Location = new System.Drawing.Point(42, 9);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(46, 19);
			this.lblClave.TabIndex = 1;
			this.lblClave.Text = "Clave";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.BackColor = System.Drawing.Color.Transparent;
			this.lblNombre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
			this.lblNombre.Location = new System.Drawing.Point(42, 56);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(67, 19);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(42, 78);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.ReadOnly = true;
			this.txtNombre.Size = new System.Drawing.Size(200, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Location = new System.Drawing.Point(42, 134);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.ReadOnly = true;
			this.txtDomicilio.Size = new System.Drawing.Size(200, 20);
			this.txtDomicilio.TabIndex = 4;
			// 
			// txtMillas
			// 
			this.txtMillas.Location = new System.Drawing.Point(46, 182);
			this.txtMillas.Name = "txtMillas";
			this.txtMillas.ReadOnly = true;
			this.txtMillas.Size = new System.Drawing.Size(200, 20);
			this.txtMillas.TabIndex = 5;
			// 
			// lblDomicilio
			// 
			this.lblDomicilio.AutoSize = true;
			this.lblDomicilio.BackColor = System.Drawing.Color.Transparent;
			this.lblDomicilio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDomicilio.Location = new System.Drawing.Point(38, 112);
			this.lblDomicilio.Name = "lblDomicilio";
			this.lblDomicilio.Size = new System.Drawing.Size(75, 19);
			this.lblDomicilio.TabIndex = 6;
			this.lblDomicilio.Text = "Domicilio";
			// 
			// lblMillas
			// 
			this.lblMillas.AutoSize = true;
			this.lblMillas.BackColor = System.Drawing.Color.Transparent;
			this.lblMillas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblMillas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMillas.Location = new System.Drawing.Point(42, 160);
			this.lblMillas.Name = "lblMillas";
			this.lblMillas.Size = new System.Drawing.Size(135, 19);
			this.lblMillas.TabIndex = 7;
			this.lblMillas.Text = "Millas acumuladas";
			// 
			// frmConsultaClubPremier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImage = global::ProyectoVuelos.Properties.Resources.how_to_ovvercome_fear_of_flying_asaptickets_5;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(576, 239);
			this.Controls.Add(this.lblMillas);
			this.Controls.Add(this.lblDomicilio);
			this.Controls.Add(this.txtMillas);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblClave);
			this.Controls.Add(this.cmbCve);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsultaClubPremier";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CLUB PREMIER";
			this.Load += new System.EventHandler(this.frmConsultaClubPremier_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbCve;
		private System.Windows.Forms.Label lblClave;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.TextBox txtMillas;
		private System.Windows.Forms.Label lblDomicilio;
		private System.Windows.Forms.Label lblMillas;
	}
}