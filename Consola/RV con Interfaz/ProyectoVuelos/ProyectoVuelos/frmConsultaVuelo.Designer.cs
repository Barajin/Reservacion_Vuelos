namespace ProyectoVuelos {
	partial class frmConsultaVuelo {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVuelo));
			this.dgvVuelos = new System.Windows.Forms.DataGridView();
			this.cveVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.boletosVendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Millas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvVuelos
			// 
			this.dgvVuelos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cveVuelo,
            this.Origen,
            this.Destino,
            this.boletosVendidos,
            this.numPasajeros,
            this.dias,
            this.Costo,
            this.Millas});
			this.dgvVuelos.Location = new System.Drawing.Point(53, 26);
			this.dgvVuelos.Name = "dgvVuelos";
			this.dgvVuelos.Size = new System.Drawing.Size(843, 312);
			this.dgvVuelos.TabIndex = 0;
			this.dgvVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVuelos_CellContentClick);
			// 
			// cveVuelo
			// 
			this.cveVuelo.HeaderText = "Clave";
			this.cveVuelo.Name = "cveVuelo";
			this.cveVuelo.ReadOnly = true;
			// 
			// Origen
			// 
			this.Origen.HeaderText = "Origen";
			this.Origen.Name = "Origen";
			this.Origen.ReadOnly = true;
			// 
			// Destino
			// 
			this.Destino.HeaderText = "Destino";
			this.Destino.Name = "Destino";
			this.Destino.ReadOnly = true;
			// 
			// boletosVendidos
			// 
			this.boletosVendidos.HeaderText = "Boletos Vendidos";
			this.boletosVendidos.Name = "boletosVendidos";
			this.boletosVendidos.ReadOnly = true;
			// 
			// numPasajeros
			// 
			this.numPasajeros.HeaderText = "# Pasajeros";
			this.numPasajeros.Name = "numPasajeros";
			this.numPasajeros.ReadOnly = true;
			// 
			// dias
			// 
			this.dias.HeaderText = "Días";
			this.dias.Name = "dias";
			this.dias.ReadOnly = true;
			// 
			// Costo
			// 
			this.Costo.HeaderText = "Costo";
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			// 
			// Millas
			// 
			this.Millas.HeaderText = "Millas";
			this.Millas.Name = "Millas";
			this.Millas.ReadOnly = true;
			// 
			// frmConsultaVuelo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ProyectoVuelos.Properties.Resources.asdf;
			this.ClientSize = new System.Drawing.Size(941, 395);
			this.Controls.Add(this.dgvVuelos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsultaVuelo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VUELOS DISPONIBLES";
			this.Load += new System.EventHandler(this.frmConsultaVuelo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvVuelos;
		private System.Windows.Forms.DataGridViewTextBoxColumn cveVuelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
		private System.Windows.Forms.DataGridViewTextBoxColumn boletosVendidos;
		private System.Windows.Forms.DataGridViewTextBoxColumn numPasajeros;
		private System.Windows.Forms.DataGridViewTextBoxColumn dias;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Millas;
	}
}