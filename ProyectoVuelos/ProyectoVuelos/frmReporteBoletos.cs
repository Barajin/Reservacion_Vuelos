using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVuelos {
    public partial class frmReporteBoletos : Form {
        public frmReporteBoletos() {
            InitializeComponent();
        }

        private void frmReporteBoletos_Load(object sender,EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.boleto' Puede moverla o quitarla según sea necesario.
            this.boletoTableAdapter.Fill(this.DataSet1.boleto);

            this.reportViewer1.RefreshReport();
        }
    }
}
