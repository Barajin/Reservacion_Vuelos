using System;
using System.Collections;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;

namespace ProyectoVuelos {
	public partial class frmConsultaVuelo : Form {
		ArrayList arrayVuelos;
        SqlConnection conn;
		public frmConsultaVuelo() {
			InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;
        }



		private void frmConsultaVuelo_Load(object sender,EventArgs e) {

            string strComando = "SELECT v.cveVuelo, cO.nombreCiudad, cD.nombreCiudad, capacidad, costo, millas FROM vuelo v " +
                   "INNER JOIN ciudad cD ON cD.cveCiudad = v.origen INNER JOIN ciudad cO ON cO.cveCiudad = v.destino;";

            SqlDataReader lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows) {
                dgvVuelos.Rows.Clear();
                while (lector.Read()) {
                    int clave = Convert.ToInt16(lector.GetValue(0));
                    string origen = lector.GetValue(1).ToString();
                    string destino = lector.GetValue(2).ToString();
                    int capacidad = Convert.ToInt32(lector.GetValue(3));
                    double costo = Convert.ToDouble(lector.GetValue(4));
                    double millas = Convert.ToDouble(lector.GetValue(5));

                    dgvVuelos.Rows.Add(clave, origen, destino, capacidad, "", 0, costo, millas);
                }
            }

				
		}
	}
}
