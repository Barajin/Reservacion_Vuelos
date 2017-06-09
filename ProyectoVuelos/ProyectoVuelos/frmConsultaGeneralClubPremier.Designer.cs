namespace ProyectoVuelos {
    partial class frmConsultaGeneralClubPremier {
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
            this.dgvClub = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClub)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClub
            // 
            this.dgvClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre,
            this.fecha,
            this.millas});
            this.dgvClub.Location = new System.Drawing.Point(12, 12);
            this.dgvClub.Name = "dgvClub";
            this.dgvClub.Size = new System.Drawing.Size(445, 382);
            this.dgvClub.TabIndex = 0;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de Nacimiento";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // millas
            // 
            this.millas.HeaderText = "Millas";
            this.millas.Name = "millas";
            this.millas.ReadOnly = true;
            // 
            // frmConsultaGeneralClubPremier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 406);
            this.Controls.Add(this.dgvClub);
            this.Name = "frmConsultaGeneralClubPremier";
            this.RightToLeftLayout = true;
            this.Text = "CLUB PREMIER";
            this.Load += new System.EventHandler(this.frmConsultaGeneralClubPremier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn millas;
    }
}