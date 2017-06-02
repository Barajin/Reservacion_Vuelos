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
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblCveBoleto = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.errorPCvePremier = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPEdad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBoletoExtra = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panelBoletoExtra = new System.Windows.Forms.Panel();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grpClubPremier.SuspendLayout();
            this.grpVuelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPCvePremier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPNombre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelBoletoExtra.SuspendLayout();
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
            this.txtNombrePasajero.Location = new System.Drawing.Point(510, 55);
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
            this.txtClaveBoleto.Size = new System.Drawing.Size(182, 20);
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
            this.txtDestino.Location = new System.Drawing.Point(6, 172);
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
            this.grpClubPremier.Location = new System.Drawing.Point(301, 43);
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
            this.grpVuelo.Controls.Add(this.label1);
            this.grpVuelo.Controls.Add(this.dateTimePicker1);
            this.grpVuelo.Controls.Add(this.lblDestino);
            this.grpVuelo.Controls.Add(this.lblOrigen);
            this.grpVuelo.Controls.Add(this.lblCveVuelo);
            this.grpVuelo.Controls.Add(this.cmbCveVuelo);
            this.grpVuelo.Controls.Add(this.txtOrigen);
            this.grpVuelo.Controls.Add(this.txtDestino);
            this.grpVuelo.ForeColor = System.Drawing.Color.Black;
            this.grpVuelo.Location = new System.Drawing.Point(29, 72);
            this.grpVuelo.Name = "grpVuelo";
            this.grpVuelo.Size = new System.Drawing.Size(232, 275);
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
            this.lblNombre.Location = new System.Drawing.Point(510, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(510, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Edad";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.Location = new System.Drawing.Point(192, 398);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 15;
            this.lblCosto.Text = "Costo";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(439, 382);
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
            this.txtEdad.Location = new System.Drawing.Point(510, 109);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // chkBoletoExtra
            // 
            this.chkBoletoExtra.AutoSize = true;
            this.chkBoletoExtra.Location = new System.Drawing.Point(301, 144);
            this.chkBoletoExtra.Name = "chkBoletoExtra";
            this.chkBoletoExtra.Size = new System.Drawing.Size(83, 17);
            this.chkBoletoExtra.TabIndex = 19;
            this.chkBoletoExtra.Text = "Boleto Extra";
            this.chkBoletoExtra.UseVisualStyleBackColor = true;
            this.chkBoletoExtra.CheckedChanged += new System.EventHandler(this.chkBoletoExtra_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(243, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(243, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(34, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 86);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Club Premier";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(15, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(43, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Clave:";
            this.label4.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "¡Soy parte!";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Location = new System.Drawing.Point(243, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 20;
            // 
            // panelBoletoExtra
            // 
            this.panelBoletoExtra.Controls.Add(this.label7);
            this.panelBoletoExtra.Controls.Add(this.textBox4);
            this.panelBoletoExtra.Controls.Add(this.groupBox1);
            this.panelBoletoExtra.Controls.Add(this.textBox1);
            this.panelBoletoExtra.Controls.Add(this.textBox3);
            this.panelBoletoExtra.Controls.Add(this.label2);
            this.panelBoletoExtra.Controls.Add(this.label3);
            this.panelBoletoExtra.Location = new System.Drawing.Point(301, 176);
            this.panelBoletoExtra.Name = "panelBoletoExtra";
            this.panelBoletoExtra.Size = new System.Drawing.Size(442, 171);
            this.panelBoletoExtra.TabIndex = 25;
            this.panelBoletoExtra.Visible = false;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(252, 383);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(91, 32);
            this.lblCostoTotal.TabIndex = 26;
            this.lblCostoTotal.Text = "$ 0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(36, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Clave boleto";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(36, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(182, 20);
            this.textBox4.TabIndex = 25;
            // 
            // frmCompraBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(768, 453);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.panelBoletoExtra);
            this.Controls.Add(this.chkBoletoExtra);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblCveBoleto);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblCosto);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBoletoExtra.ResumeLayout(false);
            this.panelBoletoExtra.PerformLayout();
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
		private System.Windows.Forms.Button btnComprar;
		private System.Windows.Forms.Label lblCveBoleto;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.TextBox txtClavePremier;
		private System.Windows.Forms.Label lblCvePremier;
		private System.Windows.Forms.ErrorProvider errorPCvePremier;
		private System.Windows.Forms.ErrorProvider errorPEdad;
		private System.Windows.Forms.ErrorProvider errorPNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Panel panelBoletoExtra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBoletoExtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
    }
}