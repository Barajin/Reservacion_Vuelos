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
            this.lblInfo = new System.Windows.Forms.Label();
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.frmInf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmInf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Advantage", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(-4, 360);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(705, 23);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Proyecto realizado por Bajo Preciado, González Velázquez y Vidriales Trujillo par" +
    "a la materia de Programación II.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgSalir
            // 
            this.imgSalir.BackColor = System.Drawing.Color.Black;
            this.imgSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgSalir.Image = global::ProyectoVuelos.Properties.Resources.fic;
            this.imgSalir.Location = new System.Drawing.Point(-1, 0);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(60, 61);
            this.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSalir.TabIndex = 2;
            this.imgSalir.TabStop = false;
            this.imgSalir.Click += new System.EventHandler(this.imgSalir_Click);
            // 
            // frmInf
            // 
            this.frmInf.BackColor = System.Drawing.SystemColors.Window;
            this.frmInf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmInf.Image = global::ProyectoVuelos.Properties.Resources.TEAM;
            this.frmInf.Location = new System.Drawing.Point(-1, 0);
            this.frmInf.Name = "frmInf";
            this.frmInf.Size = new System.Drawing.Size(702, 383);
            this.frmInf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frmInf.TabIndex = 0;
            this.frmInf.TabStop = false;
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(699, 383);
            this.Controls.Add(this.imgSalir);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.frmInf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTEGRANTES";
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmInf)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox frmInf;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox imgSalir;
    }
}