namespace ProyectoVuelos {
    partial class frmCalendar {
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
            this.calendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.lblBoletos = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtBoletosVendidos = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lblVuelos = new System.Windows.Forms.Label();
            this.btnRegresar = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpInformacion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar1
            // 
            this.calendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calendar1.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar1.Location = new System.Drawing.Point(18, 73);
            this.calendar1.MaxDate = new System.DateTime(2017, 12, 25, 23, 59, 59, 0);
            this.calendar1.MaxSelectionCount = 1;
            this.calendar1.Name = "calendar1";
            this.calendar1.TabIndex = 1;
            this.calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar1_DateChanged);
            this.calendar1.MouseCaptureChanged += new System.EventHandler(this.frmCalendar_Load);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(504, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(118, 274);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.lblBoletos);
            this.grpInformacion.Controls.Add(this.lblHorario);
            this.grpInformacion.Controls.Add(this.lblDestino);
            this.grpInformacion.Controls.Add(this.lblOrigen);
            this.grpInformacion.Controls.Add(this.txtBoletosVendidos);
            this.grpInformacion.Controls.Add(this.txtDestino);
            this.grpInformacion.Controls.Add(this.txtHora);
            this.grpInformacion.Controls.Add(this.txtOrigen);
            this.grpInformacion.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacion.Location = new System.Drawing.Point(644, 73);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(170, 303);
            this.grpInformacion.TabIndex = 3;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Información";
            // 
            // lblBoletos
            // 
            this.lblBoletos.AutoSize = true;
            this.lblBoletos.Location = new System.Drawing.Point(30, 219);
            this.lblBoletos.Name = "lblBoletos";
            this.lblBoletos.Size = new System.Drawing.Size(121, 18);
            this.lblBoletos.TabIndex = 8;
            this.lblBoletos.Text = "Boletos Vendidos";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(62, 156);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(55, 18);
            this.lblHorario.TabIndex = 7;
            this.lblHorario.Text = "Horario";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(60, 102);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(57, 18);
            this.lblDestino.TabIndex = 6;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(60, 37);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(53, 18);
            this.lblOrigen.TabIndex = 5;
            this.lblOrigen.Text = "Origen";
            // 
            // txtBoletosVendidos
            // 
            this.txtBoletosVendidos.Location = new System.Drawing.Point(22, 250);
            this.txtBoletosVendidos.Name = "txtBoletosVendidos";
            this.txtBoletosVendidos.ReadOnly = true;
            this.txtBoletosVendidos.Size = new System.Drawing.Size(129, 25);
            this.txtBoletosVendidos.TabIndex = 3;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(22, 123);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(129, 25);
            this.txtDestino.TabIndex = 2;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(22, 177);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(129, 25);
            this.txtHora.TabIndex = 1;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(22, 68);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(129, 25);
            this.txtOrigen.TabIndex = 0;
            // 
            // lblVuelos
            // 
            this.lblVuelos.AutoSize = true;
            this.lblVuelos.Font = new System.Drawing.Font("Advantage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelos.Location = new System.Drawing.Point(536, 73);
            this.lblVuelos.Name = "lblVuelos";
            this.lblVuelos.Size = new System.Drawing.Size(57, 18);
            this.lblVuelos.TabIndex = 4;
            this.lblVuelos.Text = "VUELOS";
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
            this.btnRegresar.Location = new System.Drawing.Point(-11, 6);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(88, 65);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 52);
            this.panel2.TabIndex = 7;
            // 
            // frmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblVuelos);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.calendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALENDARIO DE VUELOS";
            this.Load += new System.EventHandler(this.frmCalendar_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calendar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.TextBox txtBoletosVendidos;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblBoletos;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblVuelos;
        private Bunifu.Framework.UI.BunifuTileButton btnRegresar;
        private System.Windows.Forms.Panel panel2;
    }
}