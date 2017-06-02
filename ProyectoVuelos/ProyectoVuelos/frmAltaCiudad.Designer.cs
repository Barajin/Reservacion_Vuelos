namespace ProyectoVuelos {
	partial class frmAltaCiudad {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaCiudad));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.errorPCiudad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPClave = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnGuardar.Location = new System.Drawing.Point(773, 371);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 41);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblCiudad);
            this.panel1.Controls.Add(this.lblClave);
            this.panel1.Location = new System.Drawing.Point(622, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 341);
            this.panel1.TabIndex = 1;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(115, 211);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 2;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            // 
            // txtCiudad
            // 
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Location = new System.Drawing.Point(115, 126);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 1;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // txtClave
            // 
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.Location = new System.Drawing.Point(115, 38);
            this.txtClave.MaxLength = 3;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 0;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 211);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado / País";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(12, 129);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 1;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(18, 41);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // errorPCiudad
            // 
            this.errorPCiudad.ContainerControl = this;
            // 
            // errorPEstado
            // 
            this.errorPEstado.ContainerControl = this;
            // 
            // errorPClave
            // 
            this.errorPClave.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectoVuelos.Properties.Resources.map;
            this.pictureBox1.InitialImage = global::ProyectoVuelos.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBuscar.Location = new System.Drawing.Point(637, 371);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 41);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmAltaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(892, 431);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAltaCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTA DE CIUDADES";
            this.Load += new System.EventHandler(this.frmAltaCiudad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtCiudad;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label lblCiudad;
		private System.Windows.Forms.Label lblClave;
		private System.Windows.Forms.ErrorProvider errorPCiudad;
		private System.Windows.Forms.ErrorProvider errorPEstado;
		private System.Windows.Forms.ErrorProvider errorPClave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscar;
    }
}