namespace ProyectoVuelos {
	partial class frmConsultaCiudad {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCiudad));
			this.dgvCiudades = new System.Windows.Forms.DataGridView();
			this.cve = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCiudades
			// 
			this.dgvCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCiudades.BackgroundColor = System.Drawing.SystemColors.HighlightText;
			this.dgvCiudades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cve,
            this.ciudad,
            this.estado});
			this.dgvCiudades.GridColor = System.Drawing.SystemColors.HotTrack;
			this.dgvCiudades.Location = new System.Drawing.Point(49, 31);
			this.dgvCiudades.Name = "dgvCiudades";
			this.dgvCiudades.Size = new System.Drawing.Size(512, 328);
			this.dgvCiudades.TabIndex = 0;
			// 
			// cve
			// 
			this.cve.HeaderText = "CLAVE";
			this.cve.Name = "cve";
			this.cve.ReadOnly = true;
			// 
			// ciudad
			// 
			this.ciudad.HeaderText = "CIUDAD";
			this.ciudad.Name = "ciudad";
			this.ciudad.ReadOnly = true;
			// 
			// estado
			// 
			this.estado.HeaderText = "ESTADO";
			this.estado.Name = "estado";
			this.estado.ReadOnly = true;
			// 
			// frmConsultaCiudad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ProyectoVuelos.Properties.Resources.bgMenu;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(617, 398);
			this.Controls.Add(this.dgvCiudades);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsultaCiudad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CIUDADES REGISTRADAS";
			this.Load += new System.EventHandler(this.frmConsultaCiudad_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCiudades;
		private System.Windows.Forms.DataGridViewTextBoxColumn cve;
		private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
		private System.Windows.Forms.DataGridViewTextBoxColumn estado;
	}
}