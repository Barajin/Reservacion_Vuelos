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
            this.btnRegresar = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitutlo = new System.Windows.Forms.Label();
            this.cveVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Millas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVuelos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvVuelos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cveVuelo,
            this.Origen,
            this.Destino,
            this.numPasajeros,
            this.dias,
            this.Costo,
            this.Millas});
            this.dgvVuelos.Location = new System.Drawing.Point(26, 67);
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.Size = new System.Drawing.Size(651, 344);
            this.dgvVuelos.TabIndex = 0;
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
            this.btnRegresar.Location = new System.Drawing.Point(0, 3);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(76, 38);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblTitutlo);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 44);
            this.panel2.TabIndex = 7;
            // 
            // lblTitutlo
            // 
            this.lblTitutlo.Font = new System.Drawing.Font("Advantage", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutlo.ForeColor = System.Drawing.Color.White;
            this.lblTitutlo.Location = new System.Drawing.Point(244, 9);
            this.lblTitutlo.Name = "lblTitutlo";
            this.lblTitutlo.Size = new System.Drawing.Size(100, 23);
            this.lblTitutlo.TabIndex = 1;
            this.lblTitutlo.Text = "VUELOS";
            this.lblTitutlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cveVuelo
            // 
            this.cveVuelo.HeaderText = "Clave";
            this.cveVuelo.Name = "cveVuelo";
            this.cveVuelo.ReadOnly = true;
            this.cveVuelo.Width = 59;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Width = 63;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 68;
            // 
            // numPasajeros
            // 
            this.numPasajeros.HeaderText = "Capacidad";
            this.numPasajeros.Name = "numPasajeros";
            this.numPasajeros.ReadOnly = true;
            this.numPasajeros.Width = 83;
            // 
            // dias
            // 
            this.dias.HeaderText = "Fecha";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            this.dias.Width = 62;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 59;
            // 
            // Millas
            // 
            this.Millas.HeaderText = "Millas";
            this.Millas.Name = "Millas";
            this.Millas.ReadOnly = true;
            this.Millas.Width = 58;
            // 
            // frmConsultaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoVuelos.Properties.Resources.asdf;
            this.ClientSize = new System.Drawing.Size(706, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VUELOS DISPONIBLES";
            this.Load += new System.EventHandler(this.frmConsultaVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvVuelos;
        private Bunifu.Framework.UI.BunifuTileButton btnRegresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitutlo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Millas;
    }
}