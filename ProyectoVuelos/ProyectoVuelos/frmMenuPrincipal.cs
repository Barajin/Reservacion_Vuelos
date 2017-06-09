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

            this.Size = new Size(671,438);
            
            if (conn == null)
                return;
        }

        private void btnSalir_Click(object sender,EventArgs e) {
            DialogResult d = MessageBox.Show("¿Está seguro de salir?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (DialogResult.Yes == d)
                Application.Exit();
        }

        private void btnCiudades_Click(object sender,EventArgs e) {
            apagarPaneles();
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
           
        }

        private void btnAlta_Click(object sender,EventArgs e) {
            frmAltaCiudad f = new frmAltaCiudad();
            f.ShowDialog();
        }

  

        private void apagarPaneles () {
            panelCiudad.Visible = false;
            panelVuelos.Visible = false;
            panelBoletos.Visible = false;
            panelClientes.Visible = false;
            panelClubPremier.Visible = false;
            panelReportes.Visible = false;
          
        }
        private void btnVuelos_Click(object sender,EventArgs e) {
            apagarPaneles();
            panelVuelos.Visible = true;
            panelVuelos.Location = new Point(191,70);

        }

        private void btnBoletos_Click(object sender,EventArgs e) {
            apagarPaneles();
            panelBoletos.Visible = true;
            panelBoletos.Location = new Point(191,70);
        }

        private void btnclientes_Click(object sender,EventArgs e) {
            apagarPaneles();
            panelClientes.Visible = true;
            panelClientes.Location = new Point(191,70);
        }

        private void btnClubpremier_Click(object sender,EventArgs e) {
            apagarPaneles();
            panelClubPremier.Visible = true;
            panelClubPremier.Location = new Point(191,70);
        }

        private void btnAnalisis_Click(object sender,EventArgs e) {
            apagarPaneles();
            panelReportes.Visible = true;
            panelReportes.Location = new Point(191,70);
        }

        private void frmMenuPrincipal_Load(object sender,EventArgs e) {
            apagarPaneles();
        }

        private int contar(string tabla) {
            int c = 0;
            SqlDataReader lector = null;
            string strComando = "SELECT COUNT(*) FROM " + tabla +";";
            lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows)
                while (lector.Read())
                    c = Convert.ToInt32(lector.GetValue(0));


            lector.Close();
            return c;

        }

        private void btnIndividual_Click(object sender,EventArgs e) {
            frmConsultaCiudad2 f = new frmConsultaCiudad2();
            f.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender,EventArgs e) {
            frmAltaVuelo f = new frmAltaVuelo();
            f.ShowDialog();
        }

        private void General_Click(object sender,EventArgs e) {
            frmConsultaVuelo c = new frmConsultaVuelo();
            c.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender,EventArgs e) {
            frmCalendar c = new frmCalendar();
            c.ShowDialog();
        }

        private void btnGeneral_Click(object sender,EventArgs e) {
            frmConsultaCiudad f = new frmConsultaCiudad();
            f.ShowDialog();
        }

        private void bunifuThinButton26_Click(object sender,EventArgs e) {
            frmCalendar c = new frmCalendar();
            c.ShowDialog();
        }

        private void bunifuThinButton25_Click(object sender,EventArgs e) {
            frmConsultaVuelo c = new frmConsultaVuelo();
            c.ShowDialog();
        }

        private void bunifuThinButton24_Click(object sender,EventArgs e) {
            frmConsultaCiudad2 f = new frmConsultaCiudad2();
            f.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender,EventArgs e) {
            frmConsultaCiudad f = new frmConsultaCiudad();
            f.ShowDialog();
        }

        private void bunifuThinButton210_Click(object sender,EventArgs e) {

        }

        private void bunifuThinButton29_Click(object sender,EventArgs e) {
            frmConsultaClientes f = new frmConsultaClientes();
            f.ShowDialog();
        }

        private void bunifuTileButton3_Click(object sender,EventArgs e) {
            frmAltaClubPremier c = new frmAltaClubPremier();
            c.ShowDialog();
        }

        private void bunifuThinButton212_Click(object sender,EventArgs e) {
            frmConsultaClubPremier f = new frmConsultaClubPremier();
            f.ShowDialog();
        }

        private void bunifuThinButton211_Click(object sender,EventArgs e) {
            frmConsultaGeneralClubPremier g = new frmConsultaGeneralClubPremier();
            g.ShowDialog();
        }

        private void bunifuThinButton22_Click_1(object sender,EventArgs e) {
            frmCalendar c = new frmCalendar();
            c.ShowDialog();
        }

        private void bunifuThinButton28_Click(object sender,EventArgs e) {

        }

        private void bunifuThinButton21_Click(object sender,EventArgs e) {
            frmConsultaVuelo f = new frmConsultaVuelo();
            f.ShowDialog();
        }

        private void bunifuTileButton2_Click_1(object sender,EventArgs e) {
            frmAltaVuelo f = new frmAltaVuelo();
            f.ShowDialog();
        }

        private void bunifuTileButton7_Click(object sender,EventArgs e) {
            frmCompraBoleto f = new frmCompraBoleto();
            f.ShowDialog();
        }

        private void bunifuThinButton27_Click(object sender,EventArgs e) {
            frmConsultaBoleto f = new frmConsultaBoleto();
            f.ShowDialog();
        }

        private void bunifuTileButton6_Click(object sender,EventArgs e) {
            frmAltaCiudad c = new frmAltaCiudad();
            c.ShowDialog();
        }
    }
}
