namespace ProyectoVuelos {
	partial class frmLogo {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogo));
			this.pictureLogo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rtxtNimbus = new System.Windows.Forms.RichTextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureLogo
			// 
			this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
			this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureLogo.Image = global::ProyectoVuelos.Properties.Resources.logoR__1_;
			this.pictureLogo.Location = new System.Drawing.Point(22, 55);
			this.pictureLogo.Name = "pictureLogo";
			this.pictureLogo.Size = new System.Drawing.Size(278, 290);
			this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureLogo.TabIndex = 0;
			this.pictureLogo.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(338, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 1;
			// 
			// rtxtNimbus
			// 
			this.rtxtNimbus.BackColor = System.Drawing.SystemColors.Menu;
			this.rtxtNimbus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtxtNimbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtxtNimbus.Location = new System.Drawing.Point(316, 113);
			this.rtxtNimbus.Name = "rtxtNimbus";
			this.rtxtNimbus.Size = new System.Drawing.Size(228, 232);
			this.rtxtNimbus.TabIndex = 2;
			this.rtxtNimbus.Text = resources.GetString("rtxtNimbus.Text");
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(355, 75);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(145, 24);
			this.lblNombre.TabIndex = 3;
			this.lblNombre.Text = "AERONIMBUS";
			// 
			// frmLogo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(556, 385);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.rtxtNimbus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureLogo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmLogo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "A E R O N I M B U S";
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rtxtNimbus;
		private System.Windows.Forms.Label lblNombre;
	}
}