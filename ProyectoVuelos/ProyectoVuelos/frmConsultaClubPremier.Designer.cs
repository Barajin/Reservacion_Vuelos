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
            this.btnRegresar = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCve
            // 
            this.cmbCve.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCve.FormattingEnabled = true;
            this.cmbCve.Location = new System.Drawing.Point(27, 90);
            this.cmbCve.Name = "cmbCve";
            this.cmbCve.Size = new System.Drawing.Size(200, 26);
            this.cmbCve.TabIndex = 0;
            this.cmbCve.SelectedIndexChanged += new System.EventHandler(this.cmbCve_SelectedIndexChanged);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(24, 68);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(47, 18);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(272, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(272, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(200, 25);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(272, 146);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(200, 25);
            this.txtDomicilio.TabIndex = 4;
            // 
            // txtMillas
            // 
            this.txtMillas.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMillas.Location = new System.Drawing.Point(271, 205);
            this.txtMillas.Name = "txtMillas";
            this.txtMillas.ReadOnly = true;
            this.txtMillas.Size = new System.Drawing.Size(200, 25);
            this.txtMillas.TabIndex = 5;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilio.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(268, 124);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(71, 18);
            this.lblDomicilio.TabIndex = 6;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblMillas
            // 
            this.lblMillas.AutoSize = true;
            this.lblMillas.BackColor = System.Drawing.Color.Transparent;
            this.lblMillas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMillas.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMillas.Location = new System.Drawing.Point(268, 184);
            this.lblMillas.Name = "lblMillas";
            this.lblMillas.Size = new System.Drawing.Size(132, 18);
            this.lblMillas.TabIndex = 7;
            this.lblMillas.Text = "Millas acumuladas";
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
            this.panel2.Size = new System.Drawing.Size(523, 53);
            this.panel2.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Advantage", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "CLUB PREMIER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoVuelos.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultaClubPremier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(502, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMillas);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtMillas);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cmbCve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaClubPremier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLUB PREMIER";
            this.Load += new System.EventHandler(this.frmConsultaClubPremier_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuTileButton btnRegresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}