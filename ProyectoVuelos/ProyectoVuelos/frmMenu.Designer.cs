namespace ProyectoVuelos {
	partial class frmMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeCiudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarBoletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clubPremierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeClubPremierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSPrincipal = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.menuSPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Controls.Add(this.pictureBoxMenu);
            this.panelMenu.ForeColor = System.Drawing.Color.Transparent;
            this.panelMenu.Name = "panelMenu";
            // 
            // pictureBoxMenu
            // 
            resources.ApplyResources(this.pictureBoxMenu, "pictureBoxMenu");
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.TabStop = false;
            // 
            // toolStripMenu
            // 
            resources.ApplyResources(this.toolStripMenu, "toolStripMenu");
            this.toolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripMenu.Name = "toolStripMenu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // timerMenu
            // 
            this.timerMenu.Enabled = true;
            this.timerMenu.Interval = 2000;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeCiudadToolStripMenuItem,
            this.consultaDeCiudadesToolStripMenuItem,
            this.toolStripMenuItem2});
            this.ciudadesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.ciudadesToolStripMenuItem, "ciudadesToolStripMenuItem");
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            // 
            // altaDeCiudadToolStripMenuItem
            // 
            this.altaDeCiudadToolStripMenuItem.Name = "altaDeCiudadToolStripMenuItem";
            resources.ApplyResources(this.altaDeCiudadToolStripMenuItem, "altaDeCiudadToolStripMenuItem");
            this.altaDeCiudadToolStripMenuItem.Click += new System.EventHandler(this.altaDeCiudadToolStripMenuItem_Click);
            // 
            // consultaDeCiudadesToolStripMenuItem
            // 
            this.consultaDeCiudadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem,
            this.generalToolStripMenuItem});
            this.consultaDeCiudadesToolStripMenuItem.Name = "consultaDeCiudadesToolStripMenuItem";
            resources.ApplyResources(this.consultaDeCiudadesToolStripMenuItem, "consultaDeCiudadesToolStripMenuItem");
            this.consultaDeCiudadesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeCiudadesToolStripMenuItem_Click);
            // 
            // individualToolStripMenuItem
            // 
            this.individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            resources.ApplyResources(this.individualToolStripMenuItem, "individualToolStripMenuItem");
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            resources.ApplyResources(this.generalToolStripMenuItem, "generalToolStripMenuItem");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // vuelosToolStripMenuItem
            // 
            this.vuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeVuelosToolStripMenuItem,
            this.consultaDeVuelosToolStripMenuItem});
            this.vuelosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            resources.ApplyResources(this.vuelosToolStripMenuItem, "vuelosToolStripMenuItem");
            // 
            // altaDeVuelosToolStripMenuItem
            // 
            this.altaDeVuelosToolStripMenuItem.Name = "altaDeVuelosToolStripMenuItem";
            resources.ApplyResources(this.altaDeVuelosToolStripMenuItem, "altaDeVuelosToolStripMenuItem");
            this.altaDeVuelosToolStripMenuItem.Click += new System.EventHandler(this.altaDeVuelosToolStripMenuItem_Click);
            // 
            // consultaDeVuelosToolStripMenuItem
            // 
            this.consultaDeVuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem1,
            this.generalToolStripMenuItem1});
            this.consultaDeVuelosToolStripMenuItem.Name = "consultaDeVuelosToolStripMenuItem";
            resources.ApplyResources(this.consultaDeVuelosToolStripMenuItem, "consultaDeVuelosToolStripMenuItem");
            this.consultaDeVuelosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeVuelosToolStripMenuItem_Click);
            // 
            // individualToolStripMenuItem1
            // 
            this.individualToolStripMenuItem1.Name = "individualToolStripMenuItem1";
            resources.ApplyResources(this.individualToolStripMenuItem1, "individualToolStripMenuItem1");
            // 
            // generalToolStripMenuItem1
            // 
            this.generalToolStripMenuItem1.Name = "generalToolStripMenuItem1";
            resources.ApplyResources(this.generalToolStripMenuItem1, "generalToolStripMenuItem1");
            // 
            // boletosToolStripMenuItem
            // 
            this.boletosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarBoletosToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.boletosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.boletosToolStripMenuItem.Name = "boletosToolStripMenuItem";
            resources.ApplyResources(this.boletosToolStripMenuItem, "boletosToolStripMenuItem");
            // 
            // comprarBoletosToolStripMenuItem
            // 
            this.comprarBoletosToolStripMenuItem.Name = "comprarBoletosToolStripMenuItem";
            resources.ApplyResources(this.comprarBoletosToolStripMenuItem, "comprarBoletosToolStripMenuItem");
            this.comprarBoletosToolStripMenuItem.Click += new System.EventHandler(this.comprarBoletosToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem2,
            this.generalToolStripMenuItem2});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            resources.ApplyResources(this.consultaToolStripMenuItem, "consultaToolStripMenuItem");
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // individualToolStripMenuItem2
            // 
            this.individualToolStripMenuItem2.Name = "individualToolStripMenuItem2";
            resources.ApplyResources(this.individualToolStripMenuItem2, "individualToolStripMenuItem2");
            // 
            // generalToolStripMenuItem2
            // 
            this.generalToolStripMenuItem2.Name = "generalToolStripMenuItem2";
            resources.ApplyResources(this.generalToolStripMenuItem2, "generalToolStripMenuItem2");
            // 
            // clubPremierToolStripMenuItem
            // 
            this.clubPremierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeClubPremierToolStripMenuItem,
            this.consultaCPToolStripMenuItem});
            this.clubPremierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.clubPremierToolStripMenuItem.Name = "clubPremierToolStripMenuItem";
            resources.ApplyResources(this.clubPremierToolStripMenuItem, "clubPremierToolStripMenuItem");
            // 
            // altaDeClubPremierToolStripMenuItem
            // 
            this.altaDeClubPremierToolStripMenuItem.Name = "altaDeClubPremierToolStripMenuItem";
            resources.ApplyResources(this.altaDeClubPremierToolStripMenuItem, "altaDeClubPremierToolStripMenuItem");
            this.altaDeClubPremierToolStripMenuItem.Click += new System.EventHandler(this.altaDeClubPremierToolStripMenuItem_Click);
            // 
            // consultaCPToolStripMenuItem
            // 
            this.consultaCPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem3,
            this.generalToolStripMenuItem3});
            this.consultaCPToolStripMenuItem.Name = "consultaCPToolStripMenuItem";
            resources.ApplyResources(this.consultaCPToolStripMenuItem, "consultaCPToolStripMenuItem");
            this.consultaCPToolStripMenuItem.Click += new System.EventHandler(this.consultaClubPToolStripMenuItem_Click);
            // 
            // individualToolStripMenuItem3
            // 
            this.individualToolStripMenuItem3.Name = "individualToolStripMenuItem3";
            resources.ApplyResources(this.individualToolStripMenuItem3, "individualToolStripMenuItem3");
            // 
            // generalToolStripMenuItem3
            // 
            this.generalToolStripMenuItem3.Name = "generalToolStripMenuItem3";
            resources.ApplyResources(this.generalToolStripMenuItem3, "generalToolStripMenuItem3");
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.xToolStripMenuItem, "xToolStripMenuItem");
            this.xToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xToolStripMenuItem.Image = global::ProyectoVuelos.Properties.Resources.about;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.Image = global::ProyectoVuelos.Properties.Resources.LOGOMINI;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartsToolStripMenuItem,
            this.opToolStripMenuItem});
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            resources.ApplyResources(this.consultasToolStripMenuItem, "consultasToolStripMenuItem");
            // 
            // chartsToolStripMenuItem
            // 
            this.chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            resources.ApplyResources(this.chartsToolStripMenuItem, "chartsToolStripMenuItem");
            this.chartsToolStripMenuItem.Click += new System.EventHandler(this.chartsToolStripMenuItem_Click);
            // 
            // opToolStripMenuItem
            // 
            this.opToolStripMenuItem.Name = "opToolStripMenuItem";
            resources.ApplyResources(this.opToolStripMenuItem, "opToolStripMenuItem");
            this.opToolStripMenuItem.Click += new System.EventHandler(this.opToolStripMenuItem_Click);
            // 
            // menuSPrincipal
            // 
            resources.ApplyResources(this.menuSPrincipal, "menuSPrincipal");
            this.menuSPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuSPrincipal.GripMargin = new System.Windows.Forms.Padding(4);
            this.menuSPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciudadesToolStripMenuItem,
            this.vuelosToolStripMenuItem,
            this.boletosToolStripMenuItem,
            this.clubPremierToolStripMenuItem,
            this.xToolStripMenuItem,
            this.toolStripMenuItem1,
            this.consultasToolStripMenuItem});
            this.menuSPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuSPrincipal.Name = "menuSPrincipal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ProyectoVuelos.Properties.Resources.imgSalir1;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::ProyectoVuelos.Properties.Resources.bgMenu;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuSPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuSPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.menuSPrincipal.ResumeLayout(false);
            this.menuSPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.ToolStrip toolStripMenu;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.PictureBox pictureBoxMenu;
		private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeCiudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeCiudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarBoletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clubPremierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeClubPremierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuSPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}