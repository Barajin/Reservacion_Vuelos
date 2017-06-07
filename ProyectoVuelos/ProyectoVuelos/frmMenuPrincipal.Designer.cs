namespace ProyectoVuelos {
    partial class frmMenuPrincipal {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgAbout = new System.Windows.Forms.PictureBox();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnalisis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClubpremier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnclientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBoletos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVuelos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCiudades = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgInicio = new System.Windows.Forms.PictureBox();
            this.btnAlta = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.imgAbout);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Location = new System.Drawing.Point(167, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 54);
            this.panel2.TabIndex = 1;
            // 
            // imgAbout
            // 
            this.imgAbout.Image = global::ProyectoVuelos.Properties.Resources.about;
            this.imgAbout.Location = new System.Drawing.Point(447, 6);
            this.imgAbout.Name = "imgAbout";
            this.imgAbout.Size = new System.Drawing.Size(53, 48);
            this.imgAbout.TabIndex = 3;
            this.imgAbout.TabStop = false;
            this.imgAbout.Click += new System.EventHandler(this.imgAbout_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Advantage", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(498, 54);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "AERONIMBUS";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAnalisis);
            this.panel1.Controls.Add(this.btnClubpremier);
            this.panel1.Controls.Add(this.btnclientes);
            this.panel1.Controls.Add(this.btnBoletos);
            this.panel1.Controls.Add(this.btnVuelos);
            this.panel1.Controls.Add(this.btnCiudades);
            this.panel1.Controls.Add(this.imgInicio);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 441);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Activecolor = System.Drawing.Color.White;
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.ButtonText = "   Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Advantage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalir.Iconimage = global::ProyectoVuelos.Properties.Resources.icons8_chevron_left_round;
            this.btnSalir.Iconimage_right = null;
            this.btnSalir.Iconimage_right_Selected = null;
            this.btnSalir.Iconimage_Selected = null;
            this.btnSalir.IconMarginLeft = 0;
            this.btnSalir.IconMarginRight = 0;
            this.btnSalir.IconRightVisible = true;
            this.btnSalir.IconRightZoom = 0D;
            this.btnSalir.IconVisible = true;
            this.btnSalir.IconZoom = 50D;
            this.btnSalir.IsTab = false;
            this.btnSalir.Location = new System.Drawing.Point(0, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.OnHovercolor = System.Drawing.Color.White;
            this.btnSalir.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSalir.selected = false;
            this.btnSalir.Size = new System.Drawing.Size(172, 44);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "   Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSalir.TextFont = new System.Drawing.Font("Coco Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Activecolor = System.Drawing.Color.White;
            this.btnAnalisis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnalisis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnalisis.BorderRadius = 0;
            this.btnAnalisis.ButtonText = "   Reportes";
            this.btnAnalisis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalisis.DisabledColor = System.Drawing.Color.Gray;
            this.btnAnalisis.Font = new System.Drawing.Font("Advantage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnalisis.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnalisis.Iconimage = global::ProyectoVuelos.Properties.Resources.icons8_rebalance_portfolio;
            this.btnAnalisis.Iconimage_right = null;
            this.btnAnalisis.Iconimage_right_Selected = null;
            this.btnAnalisis.Iconimage_Selected = null;
            this.btnAnalisis.IconMarginLeft = 0;
            this.btnAnalisis.IconMarginRight = 0;
            this.btnAnalisis.IconRightVisible = true;
            this.btnAnalisis.IconRightZoom = 0D;
            this.btnAnalisis.IconVisible = true;
            this.btnAnalisis.IconZoom = 50D;
            this.btnAnalisis.IsTab = false;
            this.btnAnalisis.Location = new System.Drawing.Point(0, 345);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAnalisis.OnHovercolor = System.Drawing.Color.White;
            this.btnAnalisis.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAnalisis.selected = false;
            this.btnAnalisis.Size = new System.Drawing.Size(172, 44);
            this.btnAnalisis.TabIndex = 8;
            this.btnAnalisis.Text = "   Reportes";
            this.btnAnalisis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalisis.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAnalisis.TextFont = new System.Drawing.Font("Coco Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnClubpremier
            // 
            this.btnClubpremier.Activecolor = System.Drawing.Color.White;
            this.btnClubpremier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClubpremier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClubpremier.BorderRadius = 0;
            this.btnClubpremier.ButtonText = "   Club Premier";
            this.btnClubpremier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClubpremier.DisabledColor = System.Drawing.Color.Gray;
            this.btnClubpremier.Font = new System.Drawing.Font("Advantage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClubpremier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClubpremier.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClubpremier.Iconimage = global::ProyectoVuelos.Properties.Resources.icons8_christmas_star_filled;
            this.btnClubpremier.Iconimage_right = null;
            this.btnClubpremier.Iconimage_right_Selected = null;
            this.btnClubpremier.Iconimage_Selected = null;
            this.btnClubpremier.IconMarginLeft = 0;
            this.btnClubpremier.IconMarginRight = 0;
            this.btnClubpremier.IconRightVisible = true;
            this.btnClubpremier.IconRightZoom = 0D;
            this.btnClubpremier.IconVisible = true;
            this.btnClubpremier.IconZoom = 50D;
            this.btnClubpremier.IsTab = false;
            this.btnClubpremier.Location = new System.Drawing.Point(0, 306);
            this.btnClubpremier.Name = "btnClubpremier";
            this.btnClubpremier.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnClubpremier.OnHovercolor = System.Drawing.Color.White;
            this.btnClubpremier.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnClubpremier.selected = false;
            this.btnClubpremier.Size = new System.Drawing.Size(172, 44);
            this.btnClubpremier.TabIndex = 7;
            this.btnClubpremier.Text = "   Club Premier";
            this.btnClubpremier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClubpremier.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnClubpremier.TextFont = new System.Drawing.Font("Coco Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnclientes
            // 
            this.btnclientes.Activecolor = System.Drawing.Color.White;
            this.btnclientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclientes.BorderRadius = 0;
            this.btnclientes.ButtonText = "   Clientes";
            this.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnclientes.Font = new System.Drawing.Font("Advantage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnclientes.Iconimage = global::ProyectoVuelos.Properties.Resources.icons8_group_foreground_selected_filled;
            this.btnclientes.Iconimage_right = null;
            this.btnclientes.Iconimage_right_Selected = null;
            this.btnclientes.Iconimage_Selected = null;
            this.btnclientes.IconMarginLeft = 0;
            this.btnclientes.IconMarginRight = 0;
            this.btnclientes.IconRightVisible = true;
            this.btnclientes.IconRightZoom = 0D;
            this.btnclientes.IconVisible = true;
            this.btnclientes.IconZoom = 50D;
            this.btnclientes.IsTab = false;
            this.btnclientes.Location = new System.Drawing.Point(0, 267);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnclientes.OnHovercolor = System.Drawing.Color.White;
            this.btnclientes.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnclientes.selected = false;
            this.btnclientes.Size = new System.Drawing.Size(172, 44);
            this.btnclientes.TabIndex = 6;
            this.btnclientes.Text = "   Clientes";
            this.btnclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnclientes.TextFont = new System.Drawing.Font("Coco Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBoletos
            // 
            this.btnBoletos.Activecolor = System.Drawing.Color.White;
            this.btnBoletos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBoletos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoletos.BorderRadius = 0;
            this.btnBoletos.ButtonText = "   Boletos";
            this.btnBoletos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoletos.DisabledColor = System.Drawing.Color.Gray;
            this.btnBoletos.Font = new System.Drawing.Font("Advantage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBoletos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBoletos.Iconimage = global::ProyectoVuelos.Properties.Resources.icons8_ticket;
            this.btnBoletos.Iconimage_right = null;
            this.btnBoletos.Iconimage_right_Selected = null;
            this.btnBoletos.Iconimage_Selected = null;
            this.btnBoletos.IconMarginLeft = 0;
            this.btnBoletos.IconMarginRight = 0;
            this.btnBoletos.IconRightVisible = true;
            this.btnBoletos.IconRightZoom = 0D;
            this.btnBoletos.IconVisible = true;
            this.btnBoletos.IconZoom = 50D;
            this.btnBoletos.IsTab = false;
            this.btnBoletos.Location = new System.Drawing.Point(0, 226);
            this.btnBoletos.Name = "btnBoletos";
            this.btnBoletos.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnBoletos.OnHovercolor = System.Drawing.Color.White;
            this.btnBoletos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBoletos.selected = false;
            this.btnBoletos.Size = new System.Drawing.Size(172, 44);
            this.btnBoletos.TabIndex = 5;
            this.btnBoletos.Text = "   Boletos";
            this.btnBoletos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoletos.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnBoletos.TextFont = new System.Drawing.Font("Coco Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnVuelos
            // 
            this.btnVuelos.Activecolor = System.Drawing.Color.White;
            this.btnVuelos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVuelos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVuelos.BorderRadius = 0;
            this.btnVuelos.ButtonText = "   Vuelos";
            this.btnVuelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVuelos.DisabledColor = System.Drawing.Color.Gray;
            this.btnVuelos.Font = new System.Drawing.Font("Advantage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVuelos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVuelos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVuelos.Iconimage = global::ProyectoVuelos.Properties.Resources.icons8_airport;
            this.btnVuelos.Iconimage_right = null;
            this.btnVuelos.Iconimage_right_Selected = null;
            this.btnVuelos.Iconimage_Selected = null;
            this.btnVuelos.IconMarginLeft = 0;
            this.btnVuelos.IconMarginRight = 0;
            this.btnVuelos.IconRightVisible = true;
            this.btnVuelos.IconRightZoom = 0D;
            this.btnVuelos.IconVisible = true;
            this.btnVuelos.IconZoom = 50D;
            this.btnVuelos.IsTab = false;
            this.btnVuelos.Location = new System.Drawing.Point(0, 185);
            this.btnVuelos.Name = "btnVuelos";
            this.btnVuelos.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnVuelos.OnHovercolor = System.Drawing.Color.White;
            this.btnVuelos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVuelos.selected = false;
            this.btnVuelos.Size = new System.Drawing.Size(172, 44);
            this.btnVuelos.TabIndex = 4;
            this.btnVuelos.Text = "   Vuelos";
            this.btnVuelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVuelos.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnVuelos.TextFont = new System.Drawing.Font("Coco Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCiudades
            // 
            this.btnCiudades.Activecolor = System.Drawing.Color.White;
            this.btnCiudades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCiudades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCiudades.BorderRadius = 0;
            this.btnCiudades.ButtonText = "   Ciudades";
            this.btnCiudades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCiudades.DisabledColor = System.Drawing.Color.Gray;
            this.btnCiudades.Font = new System.Drawing.Font("Advantage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiudades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCiudades.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCiudades.Iconimage = global::ProyectoVuelos.Properties.Resources.icons8_west_direction;
            this.btnCiudades.Iconimage_right = null;
            this.btnCiudades.Iconimage_right_Selected = null;
            this.btnCiudades.Iconimage_Selected = null;
            this.btnCiudades.IconMarginLeft = 0;
            this.btnCiudades.IconMarginRight = 0;
            this.btnCiudades.IconRightVisible = true;
            this.btnCiudades.IconRightZoom = 0D;
            this.btnCiudades.IconVisible = true;
            this.btnCiudades.IconZoom = 50D;
            this.btnCiudades.IsTab = false;
            this.btnCiudades.Location = new System.Drawing.Point(0, 145);
            this.btnCiudades.Name = "btnCiudades";
            this.btnCiudades.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnCiudades.OnHovercolor = System.Drawing.Color.White;
            this.btnCiudades.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCiudades.selected = false;
            this.btnCiudades.Size = new System.Drawing.Size(172, 44);
            this.btnCiudades.TabIndex = 2;
            this.btnCiudades.Text = "   Ciudades";
            this.btnCiudades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCiudades.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnCiudades.TextFont = new System.Drawing.Font("Coco Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiudades.BackColorChanged += new System.EventHandler(this.btnCiudades_BackColorChanged);
            this.btnCiudades.Click += new System.EventHandler(this.btnCiudades_Click);
            // 
            // imgInicio
            // 
            this.imgInicio.BackColor = System.Drawing.Color.Transparent;
            this.imgInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgInicio.Image = global::ProyectoVuelos.Properties.Resources.logo;
            this.imgInicio.Location = new System.Drawing.Point(0, -20);
            this.imgInicio.Name = "imgInicio";
            this.imgInicio.Size = new System.Drawing.Size(177, 183);
            this.imgInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgInicio.TabIndex = 3;
            this.imgInicio.TabStop = false;
            this.imgInicio.Click += new System.EventHandler(this.imgInicio_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAlta.color = System.Drawing.Color.DarkSeaGreen;
            this.btnAlta.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlta.Font = new System.Drawing.Font("Advantage", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Image = global::ProyectoVuelos.Properties.Resources.icons8_up_arrow;
            this.btnAlta.ImagePosition = 20;
            this.btnAlta.ImageZoom = 50;
            this.btnAlta.LabelPosition = 41;
            this.btnAlta.LabelText = "Alta";
            this.btnAlta.Location = new System.Drawing.Point(201, 72);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(6);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(128, 129);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(338, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 280);
            this.panel3.TabIndex = 2;
            // 
            // frmMenuPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 438);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCiudades;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgInicio;
        private Bunifu.Framework.UI.BunifuFlatButton btnVuelos;
        private Bunifu.Framework.UI.BunifuFlatButton btnBoletos;
        private Bunifu.Framework.UI.BunifuFlatButton btnclientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnClubpremier;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnalisis;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalir;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private System.Windows.Forms.PictureBox imgAbout;
        private Bunifu.Framework.UI.BunifuTileButton btnAlta;
        private System.Windows.Forms.Panel panel3;
    }
}