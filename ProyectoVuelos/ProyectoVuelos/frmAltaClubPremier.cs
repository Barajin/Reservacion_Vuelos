using System;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace ProyectoVuelos {
	public partial class frmAltaClubPremier : Form {

        SqlConnection conn;

        public frmAltaClubPremier() {
			InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;

        }

		private void btnGuardar_Click(object sender,EventArgs e) {
			string nombre, domicilio;
			double millas = 0.0;
			int edad = 0;

			nombre = txtNombre.Text;

			if(nombre == "" || txtDomicilio.Text == "") { 
				MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			if (ValidarNombre(nombre))
				MessageBox.Show("ESE CLIENTE YA ESTÁ REGISTRADO.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			else {
				domicilio = txtDomicilio.Text;
				edad = Convert.ToInt16(txtEdad.Text);
			
				if (edad < 1 ) {
					MessageBox.Show("INGRESE UNA EDAD VÁLIDA.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}

				string strComando = 
					"INSERT INTO cliente(nombre, edad)";
                strComando += " VALUES ( @nombre, @edad);";

				SqlCommand cmd = new SqlCommand(strComando,conn);
				cmd.Parameters.AddWithValue("@nombre",nombre);
				cmd.Parameters.AddWithValue("@edad",edad);

				try {
					cmd.ExecuteNonQuery();
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
					return;
				}

                generarClavePremier();
				strComando = 
					"INSERT INTO club_premier(claveClubPremier, cveCliente, domicilio, millasAcumuladas)";
                strComando += " VALUES (@cP, @cC, @d, @m);";

				int clavePremier = contarRegistros("club_premier") + 1;
                int claveCliente = contarRegistros("cliente");
				cmd = new SqlCommand(strComando,conn);
				cmd.Parameters.AddWithValue("@cP",clavePremier);
				cmd.Parameters.AddWithValue("@cC",claveCliente);
				cmd.Parameters.AddWithValue("@d",domicilio);
				cmd.Parameters.AddWithValue("@m",millas);

				try {
					cmd.ExecuteNonQuery();
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
					return;
				}


				MessageBox.Show("CLIENTE REGISTRADO.","ALTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Limpiar();
			}
		}

        private string generarClavePremier () {
            return "";
        }

		public bool ValidarNombre(string n) {

			string strComando = "SELECT * FROM club_premier cp" +
			" INNER JOIN cliente c ON c.cveCliente = cp.cveCliente WHERE " +
			"nombre = '" + n + "';";
			SqlDataReader lector = UsoDB.Consulta(strComando,conn);

			if (lector.HasRows)
				return true;

            lector.Close();
			return false;

		}

		private void frmAltaClubPremier_Load(object sender,EventArgs e) {
			int c = contarRegistros("club_premier"); // se modificará con Identity
			txtClave.Text = Convert.ToString(c + 1);
		}

		private int contarRegistros (string tabla) {
			int r = 0;

			string strComando = "SELECT COUNT(*) FROM " + tabla + ";";

			SqlDataReader lector = UsoDB.Consulta(strComando,conn);

			if (lector.HasRows)
				while (lector.Read())
					r = Convert.ToInt16(lector.GetValue(0));

            lector.Close();
			return r;

		}

		private void Limpiar() {
			txtDomicilio.Text = "";
			txtNombre.Text = "";
			int c = contarRegistros("club_premier"); // se modificará con Identity
			txtClave.Text = Convert.ToString(c + 1);
			txtEdad.Text = "";
		}

		private void txtNombre_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPNombre.SetError(txtNombre,"Sólo se permiten letras.");
			else
				errorPNombre.SetError(txtNombre,"");
		}

		private void txtEdad_KeyPress(object sender,KeyPressEventArgs e) {
			try {
				if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)) {
					e.Handled = false;
				} else {
					e.Handled = true;
				}
			} catch (FormatException) {
			}
		}
	}
}
