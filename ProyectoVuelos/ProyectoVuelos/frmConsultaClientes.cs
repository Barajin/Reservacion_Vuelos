using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;
using System.Data;

namespace ProyectoVuelos {
    public partial class frmConsultaClientes : Form {
        SqlConnection conn;
        public frmConsultaClientes() {
            InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;
        }

        private void frmConsultaClientes_Load(object sender,EventArgs e) {
            string strComando = "SELECT cl.cveCliente, cl.nombre, edad FROM cliente cl INNER JOIN clienteGenérico cg ON cl.cveCliente = cg.cveCliente;";

            SqlDataReader lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows) {
                dgvClub.Rows.Clear();
                while (lector.Read()) {
                    int clave = Convert.ToInt16(lector.GetValue(0).ToString());
                    string nombre = lector.GetValue(1).ToString();
                    int edad = Convert.ToInt16(lector.GetValue(2).ToString());

                    dgvClub.Rows.Add(clave,nombre, edad);
                }
            }

            lector.Close();
        }
    }
}
