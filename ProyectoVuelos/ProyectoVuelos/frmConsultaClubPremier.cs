using System;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;

namespace ProyectoVuelos {
	public partial class frmConsultaClubPremier : Form {

		const string strCon = "Data Source=KARENGGV\\SQLEXPRESS;Initial Catalog=reservación_vuelos;Integrated Security=True";

		public frmConsultaClubPremier() {
			InitializeComponent();
		}

		private void frmConsultaClubPremier_Load(object sender,EventArgs e) {
			SqlConnection conn = UsoDB.ConectaBD(strCon);

			if (conn == null)
				return;

			string strComando = "SELECT cveClubPremier FROM club_premier;";

			SqlDataReader lector = UsoDB.Consulta(strComando,conn);

			if (lector.HasRows) {
				this.cmbCve.Items.Clear();
				while (lector.Read())
					cmbCve.Items.Add(lector.GetValue(0).ToString());
			}

			conn.Close();

		}

		private void cmbCve_SelectedIndexChanged(object sender,EventArgs e) {
			int cve = Convert.ToInt16(cmbCve.SelectedItem);


			SqlConnection conn = UsoDB.ConectaBD(strCon);

			if (conn == null)
				return;

			string strComando = "SELECT nombre, domicilio, millasAcumuladas FROM club_premier cp" +
				" INNER JOIN cliente c ON c.cveCliente = cp.cveCliente WHERE " +
				"cveClubPremier = '" + cve + "';";

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

			conn.Close();


		}
	}
}
