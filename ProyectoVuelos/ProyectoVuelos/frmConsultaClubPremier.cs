using System;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;

namespace ProyectoVuelos {
	public partial class frmConsultaClubPremier : Form {

        SqlConnection conn;

        public frmConsultaClubPremier() {
			InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;

        }

        private void frmConsultaClubPremier_Load(object sender,EventArgs e) {
            SqlDataReader lector = null;

            string strComando = "SELECT ClaveClubPremier FROM club_premier;";
                  
            SqlCommand cmd = new SqlCommand(strComando,conn);

            try {
                lector = cmd.ExecuteReader();
            } catch (SqlException ex) {
                MessageBox.Show("Error en la consulta.");
                foreach (SqlError err in ex.Errors)
                    MessageBox.Show(err.Message);

       
            
            }

          
            if (lector.HasRows) {
				this.cmbCve.Items.Clear();
				while (lector.Read())
					cmbCve.Items.Add(lector.GetValue(0).ToString());
			}


            lector.Close();
		}

		private void cmbCve_SelectedIndexChanged(object sender,EventArgs e) {
            string cve = cmbCve.SelectedItem.ToString();


			string strComando = "SELECT nombre, domicilio, millasAcumuladas FROM club_premier cp" +
				" INNER JOIN cliente c ON c.cveCliente = cp.cveCliente WHERE " +
				"claveClubPremier = '" + cve + "';";

			SqlDataReader lector = UsoDB.Consulta(strComando,conn);

			if (lector.HasRows) {
				while (lector.Read()) {
					string nombre = lector.GetValue(0).ToString();
					string domicilio = lector.GetValue(1).ToString();
					double millas = Convert.ToDouble(lector.GetValue(2));


					txtNombre.Text = nombre;
					txtDomicilio.Text = domicilio;
					txtMillas.Text = millas.ToString();
				}
			}

            lector.Close();

			


		}
	}
}
