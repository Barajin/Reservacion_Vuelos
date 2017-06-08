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
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtBoletosVendidos = new System.Windows.Forms.TextBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblBoletos = new System.Windows.Forms.Label();
            this.lblVuelos = new System.Windows.Forms.Label();
            this.grpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar1
            // 
            this.calendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calendar1.Location = new System.Drawing.Point(18, 18);
            this.calendar1.MaxDate = new System.DateTime(2017, 12, 25, 23, 59, 59, 0);
            this.calendar1.MaxSelectionCount = 1;
            this.calendar1.Name = "calendar1";
            this.calendar1.TabIndex = 1;
            this.calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar1_DateChanged);
            this.calendar1.MouseCaptureChanged += new System.EventHandler(this.frmCalendar_Load);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(504, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(118, 277);
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
            this.grpInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacion.Location = new System.Drawing.Point(644, 18);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(170, 303);
            this.grpInformacion.TabIndex = 3;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Información";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(22, 68);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(129, 20);
            this.txtOrigen.TabIndex = 0;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(22, 177);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(129, 20);
            this.txtHora.TabIndex = 1;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(22, 123);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(129, 20);
            this.txtDestino.TabIndex = 2;
            // 
            // txtBoletosVendidos
            // 
            this.txtBoletosVendidos.Location = new System.Drawing.Point(22, 235);
            this.txtBoletosVendidos.Name = "txtBoletosVendidos";
            this.txtBoletosVendidos.Size = new System.Drawing.Size(129, 20);
            this.txtBoletosVendidos.TabIndex = 3;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(60, 52);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(44, 13);
            this.lblOrigen.TabIndex = 5;
            this.lblOrigen.Text = "Origen";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(60, 107);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(50, 13);
            this.lblDestino.TabIndex = 6;
            this.lblDestino.Text = "Destino";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(62, 161);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(48, 13);
            this.lblHorario.TabIndex = 7;
            this.lblHorario.Text = "Horario";
            // 
            // lblBoletos
            // 
            this.lblBoletos.AutoSize = true;
            this.lblBoletos.Location = new System.Drawing.Point(32, 219);
            this.lblBoletos.Name = "lblBoletos";
            this.lblBoletos.Size = new System.Drawing.Size(105, 13);
            this.lblBoletos.TabIndex = 8;
            this.lblBoletos.Text = "Boletos Vendidos";
            // 
            // lblVuelos
            // 
            this.lblVuelos.AutoSize = true;
            this.lblVuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelos.Location = new System.Drawing.Point(536, 18);
            this.lblVuelos.Name = "lblVuelos";
            this.lblVuelos.Size = new System.Drawing.Size(56, 13);
            this.lblVuelos.TabIndex = 4;
            this.lblVuelos.Text = "VUELOS";
            // 
            // frmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 345);
            this.Controls.Add(this.lblVuelos);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.calendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALENDARIO DE VUELOS";
            this.Load += new System.EventHandler(this.frmCalendar_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
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
    }
}