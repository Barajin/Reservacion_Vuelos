namespace ProyectoVuelos {
	partial class frmConsultaBoleto {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaBoleto));
            this.dgvBoletos = new System.Windows.Forms.DataGridView();
            this.cve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubpremier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoletos
            // 
            this.dgvBoletos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cve,
            this.vuelo,
            this.nombre,
            this.edad,
            this.clubpremier});
            this.dgvBoletos.Location = new System.Drawing.Point(12, 24);
            this.dgvBoletos.Name = "dgvBoletos";
            this.dgvBoletos.Size = new System.Drawing.Size(543, 292);
            this.dgvBoletos.TabIndex = 0;
            // 
            // cve
            // 
            this.cve.HeaderText = "CLAVE";
            this.cve.Name = "cve";
            this.cve.ReadOnly = true;
            // 
            // vuelo
            // 
            this.vuelo.HeaderText = "VUELO";
            this.vuelo.Name = "vuelo";
            this.vuelo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.HeaderText = "EDAD";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // clubpremier
            // 
            this.clubpremier.HeaderText = "CLUB PREMIER";
            this.clubpremier.Name = "clubpremier";
            this.clubpremier.ReadOnly = true;
            // 
            // frmConsultaBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVuelos.Properties.Resources.how_to_ovvercome_fear_of_flying_asaptickets_5;
            this.ClientSize = new System.Drawing.Size(579, 365);
            this.Controls.Add(this.dgvBoletos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaBoleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOLETOS VENDIDOS";
            this.Load += new System.EventHandler(this.frmConsultaBoleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletos)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBoletos;
		private System.Windows.Forms.DataGridViewTextBoxColumn cve;
		private System.Windows.Forms.DataGridViewTextBoxColumn vuelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn edad;
		private System.Windows.Forms.DataGridViewTextBoxColumn clubpremier;
	}
}