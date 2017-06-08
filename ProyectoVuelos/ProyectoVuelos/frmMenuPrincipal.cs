using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace ProyectoVuelos {
    public partial class frmMenuPrincipal : Form {

        const string strCon = "Data Source=KARENGGV-PC\\KARENGGV;Initial Catalog = reservación_vuelos; Integrated Security = True";
        public SqlConnection conn = UsoDB.ConectaBD(strCon);

        public frmMenuPrincipal() {
            InitializeComponent();

        
            if (conn == null)
                return;
        }

        private void btnSalir_Click(object sender,EventArgs e) {
            DialogResult d = MessageBox.Show("¿Está seguro de salir?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (DialogResult.Yes == d)
                Application.Exit();
        }

        private void btnCiudades_Click(object sender,EventArgs e) {
            panelCiudad.Visible = true;
        }

        private void imgAbout_Click(object sender,EventArgs e) {
            frmInfo fI = new frmInfo();
            fI.Size = new Size(702,383);
            fI.SetDesktopLocation(171,57);
            fI.Location = new Point(171,57);
            fI.StartPosition = FormStartPosition.CenterParent;
            fI.ShowDialog();
        }

        private void imgInicio_Click(object sender,EventArgs e) {
            panelCiudad.Visible = false;
        }

        private void btnAlta_Click(object sender,EventArgs e) {
            frmAltaCiudad f = new frmAltaCiudad();
            f.ShowDialog();
        }

        private void btnCiudades_BackColorChanged(object sender,EventArgs e) {
            panelCiudad.Visible = true;
        }
    }
}
