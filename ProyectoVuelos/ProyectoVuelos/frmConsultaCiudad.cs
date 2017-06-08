using System;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;

namespace ProyectoVuelos {
	public partial class frmConsultaCiudad : Form {

        SqlConnection conn;
		public frmConsultaCiudad() {
			InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;
        }

		private void frmConsultaCiudad_Load(object sender,EventArgs e) {

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

          

         

			
				
		}
	}
}
