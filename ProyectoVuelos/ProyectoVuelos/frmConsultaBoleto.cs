using System;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace ProyectoVuelos {
    public partial class frmConsultaBoleto : Form {

        SqlConnection conn;
        public frmConsultaBoleto() {
            InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;
        }

        private void frmConsultaBoleto_Load(object sender,EventArgs e) {
            // agregar fecha vuelo 
            string strComando = "SELECT claveBoleto, c1.nombreCiudad, c2.nombreCiudad, cl.nombre, cp.claveClubPremier FROM boleto b ";
            strComando += " INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo INNER JOIN ciudad c1 ON v.origen = c1.cveCiudad ";
            strComando += " INNER JOIN ciudad c2 ON v.destino = c2.cveCiudad INNER JOIN cliente cl ON b.cveCliente = cl.cveCliente ";
            strComando += " LEFT JOIN club_premier cp ON cl.cveCliente = cp.cveCliente";

            SqlDataReader lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows) {
                dgvBoletos.Rows.Clear();
                while (lector.Read()) {
                    string clave = lector.GetValue(0).ToString();
                    string origen = lector.GetValue(1).ToString();
                    string destino = lector.GetValue(2).ToString();
                    string cliente = lector.GetValue(3).ToString();
                    string premier = lector.GetValue(4).ToString();

                    dgvBoletos.Rows.Add(clave,origen,destino,cliente, premier);

                }


            }
        }
    }
}