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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtMillas = new System.Windows.Forms.TextBox();
            this.txtCveVuelo = new System.Windows.Forms.TextBox();
            this.lblCveVuelo = new System.Windows.Forms.Label();
            this.lblNumPasajeros = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblMillas = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.numericNumPasajeros = new System.Windows.Forms.NumericUpDown();
            this.errorPCosto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPMillas = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker0 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDias.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPMillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(112, 80);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 1;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // cmbDestino
            // 
            this.cmbDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(112, 145);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 2;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // grpDias
            // 
            this.grpDias.BackColor = System.Drawing.Color.Transparent;
            this.grpDias.Controls.Add(this.panel1);
            this.grpDias.Location = new System.Drawing.Point(792, 12);
            this.grpDias.Name = "grpDias";
            this.grpDias.Size = new System.Drawing.Size(273, 290);
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
            this.panel1.Location = new System.Drawing.Point(9, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 255);
            this.panel1.TabIndex = 125;
            // 
            // chkFecha4
            // 
            this.chkFecha4.AutoSize = true;
            this.chkFecha4.Location = new System.Drawing.Point(17, 215);
            this.chkFecha4.Name = "chkFecha4";
            this.chkFecha4.Size = new System.Drawing.Size(15, 14);
            this.chkFecha4.TabIndex = 8;
            this.chkFecha4.UseVisualStyleBackColor = true;
            this.chkFecha4.CheckedChanged += new System.EventHandler(this.chkFecha1_CheckedChanged);
            // 
            // chkFecha1
            // 
            this.chkFecha1.AutoSize = true;
            this.chkFecha1.Location = new System.Drawing.Point(17, 19);
            this.chkFecha1.Name = "chkFecha1";
            this.chkFecha1.Size = new System.Drawing.Size(15, 14);
            this.chkFecha1.TabIndex = 5;
            this.chkFecha1.UseVisualStyleBackColor = true;
            this.chkFecha1.CheckedChanged += new System.EventHandler(this.chkFecha1_CheckedChanged);
            // 
            // chkFecha3
            // 
            this.chkFecha3.AutoSize = true;
            this.chkFecha3.Location = new System.Drawing.Point(17, 148);
            this.chkFecha3.Name = "chkFecha3";
            this.chkFecha3.Size = new System.Drawing.Size(15, 14);
            this.chkFecha3.TabIndex = 7;
            this.chkFecha3.UseVisualStyleBackColor = true;
            this.chkFecha3.CheckedChanged += new System.EventHandler(this.chkFecha1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 17);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // chkFecha2
            // 
            this.chkFecha2.AutoSize = true;
            this.chkFecha2.Location = new System.Drawing.Point(17, 81);
            this.chkFecha2.Name = "chkFecha2";
            this.chkFecha2.Size = new System.Drawing.Size(15, 14);
            this.chkFecha2.TabIndex = 6;
            this.chkFecha2.UseVisualStyleBackColor = true;
            this.chkFecha2.CheckedChanged += new System.EventHandler(this.chkFecha1_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(38, 81);
            this.dateTimePicker2.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Location = new System.Drawing.Point(38, 148);
            this.dateTimePicker3.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 3;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Location = new System.Drawing.Point(38, 215);
            this.dateTimePicker4.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(458, 334);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(314, 48);
            this.btnAgregar.TabIndex = 126;
            this.btnAgregar.Text = "Agregar más días";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(105, 282);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(123, 20);
            this.txtCosto.TabIndex = 4;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // txtMillas
            // 
            this.txtMillas.Location = new System.Drawing.Point(112, 193);
            this.txtMillas.Name = "txtMillas";
            this.txtMillas.Size = new System.Drawing.Size(123, 20);
            this.txtMillas.TabIndex = 5;
            this.txtMillas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMillas_KeyPress);
            // 
            // txtCveVuelo
            // 
            this.txtCveVuelo.Location = new System.Drawing.Point(114, 39);
            this.txtCveVuelo.Name = "txtCveVuelo";
            this.txtCveVuelo.ReadOnly = true;
            this.txtCveVuelo.Size = new System.Drawing.Size(121, 20);
            this.txtCveVuelo.TabIndex = 0;
            // 
            // lblCveVuelo
            // 
            this.lblCveVuelo.AutoSize = true;
            this.lblCveVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblCveVuelo.Location = new System.Drawing.Point(31, 46);
            this.lblCveVuelo.Name = "lblCveVuelo";
            this.lblCveVuelo.Size = new System.Drawing.Size(34, 13);
            this.lblCveVuelo.TabIndex = 7;
            this.lblCveVuelo.Text = "Clave";
            // 
            // lblNumPasajeros
            // 
            this.lblNumPasajeros.AutoSize = true;
            this.lblNumPasajeros.BackColor = System.Drawing.Color.Transparent;
            this.lblNumPasajeros.Location = new System.Drawing.Point(22, 234);
            this.lblNumPasajeros.Name = "lblNumPasajeros";
            this.lblNumPasajeros.Size = new System.Drawing.Size(63, 13);
            this.lblNumPasajeros.TabIndex = 8;
            this.lblNumPasajeros.Text = "# Pasajeros";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigen.Location = new System.Drawing.Point(27, 88);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 8;
            this.lblOrigen.Text = "Origen";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.Location = new System.Drawing.Point(27, 153);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 9;
            this.lblDestino.Text = "Destino";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.Location = new System.Drawing.Point(22, 282);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 123;
            this.lblCosto.Text = "Costo";
            // 
            // lblMillas
            // 
            this.lblMillas.AutoSize = true;
            this.lblMillas.BackColor = System.Drawing.Color.Transparent;
            this.lblMillas.Location = new System.Drawing.Point(27, 196);
            this.lblMillas.Name = "lblMillas";
            this.lblMillas.Size = new System.Drawing.Size(33, 13);
            this.lblMillas.TabIndex = 11;
            this.lblMillas.Text = "Millas";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(263, 334);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 48);
            this.btnGuardar.TabIndex = 120;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // numericNumPasajeros
            // 
            this.numericNumPasajeros.Location = new System.Drawing.Point(105, 232);
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
            this.numericNumPasajeros.Size = new System.Drawing.Size(120, 20);
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
            this.dateTimePicker0.Location = new System.Drawing.Point(30, 362);
            this.dateTimePicker0.MaxDate = new System.DateTime(2017, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker0.MinDate = new System.DateTime(2017, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker0.Name = "dateTimePicker0";
            this.dateTimePicker0.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker0.TabIndex = 0;
            this.dateTimePicker0.Value = new System.DateTime(2017, 6, 2, 0, 48, 19, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(263, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 290);
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // frmAltaVuelo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 404);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericNumPasajeros);
            this.Controls.Add(this.btnGuardar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
		private System.Windows.Forms.Button btnGuardar;
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}