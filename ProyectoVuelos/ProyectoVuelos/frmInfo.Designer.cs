namespace ProyectoVuelos {
	partial class frmInfo {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
			this.frmInf = new System.Windows.Forms.PictureBox();
			this.lblInfo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.frmInf)).BeginInit();
			this.SuspendLayout();
			// 
			// frmInf
			// 
			this.frmInf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.frmInf.Image = global::ProyectoVuelos.Properties.Resources.TEAM;
			this.frmInf.Location = new System.Drawing.Point(0, 0);
			this.frmInf.Name = "frmInf";
			this.frmInf.Size = new System.Drawing.Size(937, 509);
			this.frmInf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.frmInf.TabIndex = 0;
			this.frmInf.TabStop = false;
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo.Location = new System.Drawing.Point(12, 515);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(910, 20);
			this.lblInfo.TabIndex = 1;
			this.lblInfo.Text = "Proyecto realizado por Bajo Preciado, González Velázquez y Vidriales Trujillo par" +
    "a la materia de Programación II.";
			// 
			// frmInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(925, 544);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.frmInf);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "INTEGRANTES";
			((System.ComponentModel.ISupportInitialize)(this.frmInf)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox frmInf;
		private System.Windows.Forms.Label lblInfo;
	}
}