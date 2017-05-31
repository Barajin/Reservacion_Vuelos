using System;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;

namespace ProyectoVuelos {
	public partial class frmConsultaCiudad : Form {
		const string strCon = "Data Source=KARENGGV\\SQLEXPRESS;Initial Catalog=reservación_vuelos;Integrated Security=True";

		public frmConsultaCiudad() {
			InitializeComponent();
		}

		private void frmConsultaCiudad_Load(object sender,EventArgs e) {
			SqlConnection conn = UsoDB.ConectaBD(strCon);

			if (conn == null)
				return;

			string strComando = "SELECT cveCiudad, nombreCiudad, estado FROM ciudad;";

			SqlDataReader lector = UsoDB.Consulta(strComando,conn);

			if (lector.HasRows) {
				dgvCiudades.Rows.Clear();
				while (lector.Read()) {
					string clave = lector.GetValue(0).ToString();
					string nombre = lector.GetValue(1).ToString();
					string estado = lector.GetValue(2).ToString();

					dgvCiudades.Rows.Add(clave,nombre,estado);
				}
			}

			conn.Close();

			
				
		}
	}
}
