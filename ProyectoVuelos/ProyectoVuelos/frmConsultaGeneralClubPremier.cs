using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;
using System.Data;

namespace ProyectoVuelos {
    public partial class frmConsultaGeneralClubPremier : Form {
        SqlConnection conn;
        public frmConsultaGeneralClubPremier() {
            InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;
        }

        private void frmConsultaGeneralClubPremier_Load(object sender,EventArgs e) {
            string strComando = "SELECT claveClubPremier, cl.nombre, fecha_nacimiento, millasAcumuladas FROM club_premier cp INNER JOIN cliente cl ON cl.cveCliente = cp.cveCliente;";

            SqlDataReader lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows) {
                dgvClub.Rows.Clear();
                while (lector.Read()) {
                    string clave = lector.GetValue(0).ToString();
                    string nombre = lector.GetValue(1).ToString();
                    DateTime fecha = Convert.ToDateTime(lector.GetValue(2));
                    double millas = Convert.ToDouble(lector.GetValue(3));
                    dgvClub.Rows.Add(clave,nombre, fecha, millas);
                }
            }

            lector.Close();
        }
    }
}
