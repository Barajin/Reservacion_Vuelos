namespace ProyectoVuelos {
    partial class frmReporteBoletos {
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new ProyectoVuelos.DataSet1();
            this.boletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boletoTableAdapter = new ProyectoVuelos.DataSet1TableAdapters.boletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.boletoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoVuelos.ReporteBoletos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(577, 286);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boletoBindingSource
            // 
            this.boletoBindingSource.DataMember = "boleto";
            this.boletoBindingSource.DataSource = this.DataSet1;
            // 
            // boletoTableAdapter
            // 
            this.boletoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 356);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteBoletos";
            this.Text = "BOLETOS";
            this.Load += new System.EventHandler(this.frmReporteBoletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource boletoBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.boletoTableAdapter boletoTableAdapter;
    }
}