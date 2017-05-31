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
			this.chkDias = new System.Windows.Forms.CheckedListBox();
			this.rdDias = new System.Windows.Forms.RadioButton();
			this.rdDiario = new System.Windows.Forms.RadioButton();
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
			this.grpDias.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericNumPasajeros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorPCosto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorPMillas)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbOrigen
			// 
			this.cmbOrigen.FormattingEnabled = true;
			this.cmbOrigen.Location = new System.Drawing.Point(116, 113);
			this.cmbOrigen.Name = "cmbOrigen";
			this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
			this.cmbOrigen.TabIndex = 1;
			// 
			// cmbDestino
			// 
			this.cmbDestino.FormattingEnabled = true;
			this.cmbDestino.Location = new System.Drawing.Point(116, 178);
			this.cmbDestino.Name = "cmbDestino";
			this.cmbDestino.Size = new System.Drawing.Size(121, 21);
			this.cmbDestino.TabIndex = 2;
			// 
			// grpDias
			// 
			this.grpDias.BackColor = System.Drawing.Color.Transparent;
			this.grpDias.Controls.Add(this.chkDias);
			this.grpDias.Controls.Add(this.rdDias);
			this.grpDias.Controls.Add(this.rdDiario);
			this.grpDias.Location = new System.Drawing.Point(274, 30);
			this.grpDias.Name = "grpDias";
			this.grpDias.Size = new System.Drawing.Size(200, 233);
			this.grpDias.TabIndex = 6;
			this.grpDias.TabStop = false;
			this.grpDias.Text = "Frecuencia";
			// 
			// chkDias
			// 
			this.chkDias.BackColor = System.Drawing.Color.WhiteSmoke;
			this.chkDias.Enabled = false;
			this.chkDias.FormattingEnabled = true;
			this.chkDias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
			this.chkDias.Location = new System.Drawing.Point(20, 91);
			this.chkDias.Name = "chkDias";
			this.chkDias.Size = new System.Drawing.Size(152, 124);
			this.chkDias.TabIndex = 9;
			this.chkDias.SelectedIndexChanged += new System.EventHandler(this.chkDias_SelectedIndexChanged);
			// 
			// rdDias
			// 
			this.rdDias.AutoSize = true;
			this.rdDias.Location = new System.Drawing.Point(20, 60);
			this.rdDias.Name = "rdDias";
			this.rdDias.Size = new System.Drawing.Size(105, 17);
			this.rdDias.TabIndex = 8;
			this.rdDias.Text = "Seleccionar días";
			this.rdDias.UseVisualStyleBackColor = true;
			this.rdDias.CheckedChanged += new System.EventHandler(this.rdDias_CheckedChanged);
			// 
			// rdDiario
			// 
			this.rdDiario.AutoSize = true;
			this.rdDiario.Checked = true;
			this.rdDiario.Location = new System.Drawing.Point(20, 36);
			this.rdDiario.Name = "rdDiario";
			this.rdDiario.Size = new System.Drawing.Size(52, 17);
			this.rdDiario.TabIndex = 7;
			this.rdDiario.TabStop = true;
			this.rdDiario.Text = "Diario";
			this.rdDiario.UseVisualStyleBackColor = true;
			this.rdDiario.CheckedChanged += new System.EventHandler(this.rdDiario_CheckedChanged);
			// 
			// txtCosto
			// 
			this.txtCosto.Location = new System.Drawing.Point(114, 281);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(123, 20);
			this.txtCosto.TabIndex = 4;
			this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
			// 
			// txtMillas
			// 
			this.txtMillas.Location = new System.Drawing.Point(116, 335);
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
			this.lblNumPasajeros.Location = new System.Drawing.Point(31, 233);
			this.lblNumPasajeros.Name = "lblNumPasajeros";
			this.lblNumPasajeros.Size = new System.Drawing.Size(63, 13);
			this.lblNumPasajeros.TabIndex = 8;
			this.lblNumPasajeros.Text = "# Pasajeros";
			// 
			// lblOrigen
			// 
			this.lblOrigen.AutoSize = true;
			this.lblOrigen.BackColor = System.Drawing.Color.Transparent;
			this.lblOrigen.Location = new System.Drawing.Point(31, 121);
			this.lblOrigen.Name = "lblOrigen";
			this.lblOrigen.Size = new System.Drawing.Size(38, 13);
			this.lblOrigen.TabIndex = 8;
			this.lblOrigen.Text = "Origen";
			// 
			// lblDestino
			// 
			this.lblDestino.AutoSize = true;
			this.lblDestino.BackColor = System.Drawing.Color.Transparent;
			this.lblDestino.Location = new System.Drawing.Point(31, 186);
			this.lblDestino.Name = "lblDestino";
			this.lblDestino.Size = new System.Drawing.Size(43, 13);
			this.lblDestino.TabIndex = 9;
			this.lblDestino.Text = "Destino";
			// 
			// lblCosto
			// 
			this.lblCosto.AutoSize = true;
			this.lblCosto.BackColor = System.Drawing.Color.Transparent;
			this.lblCosto.Location = new System.Drawing.Point(31, 281);
			this.lblCosto.Name = "lblCosto";
			this.lblCosto.Size = new System.Drawing.Size(34, 13);
			this.lblCosto.TabIndex = 123;
			this.lblCosto.Text = "Costo";
			// 
			// lblMillas
			// 
			this.lblMillas.AutoSize = true;
			this.lblMillas.BackColor = System.Drawing.Color.Transparent;
			this.lblMillas.Location = new System.Drawing.Point(31, 338);
			this.lblMillas.Name = "lblMillas";
			this.lblMillas.Size = new System.Drawing.Size(33, 13);
			this.lblMillas.TabIndex = 11;
			this.lblMillas.Text = "Millas";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(307, 300);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(129, 51);
			this.btnGuardar.TabIndex = 120;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// numericNumPasajeros
			// 
			this.numericNumPasajeros.Location = new System.Drawing.Point(114, 231);
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
			// frmAltaVuelo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ProyectoVuelos.Properties.Resources.Hexagon_3;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(505, 387);
			this.Controls.Add(this.numericNumPasajeros);
			this.Controls.Add(this.btnGuardar);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAltaVuelo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ALTA DE VUELOS";
			this.Load += new System.EventHandler(this.frmAltaVuelo_Load);
			this.grpDias.ResumeLayout(false);
			this.grpDias.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericNumPasajeros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorPCosto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorPMillas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbOrigen;
		private System.Windows.Forms.ComboBox cmbDestino;
		private System.Windows.Forms.GroupBox grpDias;
		private System.Windows.Forms.RadioButton rdDias;
		private System.Windows.Forms.RadioButton rdDiario;
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
		private System.Windows.Forms.CheckedListBox chkDias;
	}
}