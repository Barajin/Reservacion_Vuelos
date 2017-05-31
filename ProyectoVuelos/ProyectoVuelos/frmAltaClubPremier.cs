using System;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace ProyectoVuelos {
	public partial class frmAltaClubPremier : Form {

		const string strCon = "Data Source=KARENGGV\\SQLEXPRESS;Initial Catalog=reservación_vuelos;Integrated Security=True";

		public frmAltaClubPremier() {
			InitializeComponent();

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

				int claveCliente = contarRegistros("cliente") + 1;

				SqlConnection conn = UsoDB.ConectaBD(strCon);

				if (conn == null)
					return;

				string strComando = "SET IDENTITY_INSERT cliente ON \n" +
					"INSERT INTO cliente(cveCliente, nombre, edad)";
				strComando += " VALUES (@clave, @nombre, @edad); \n" +
					"SET IDENTITY_INSERT cliente OFF";

				SqlCommand cmd = new SqlCommand(strComando,conn);
				cmd.Parameters.AddWithValue("@clave",claveCliente);
				cmd.Parameters.AddWithValue("@nombre",nombre);
				cmd.Parameters.AddWithValue("@edad",edad);

				try {
					cmd.ExecuteNonQuery();
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
					return;
				}

				conn.Close();
				conn.Open();
				strComando = "SET IDENTITY_INSERT club_premier ON \n" + 
					"INSERT INTO club_premier(cveClubPremier, cveCliente, domicilio, millasAcumuladas)";
				strComando += " VALUES (@cP, @cC, @d, @m); \n"
						+ "SET IDENTITY_INSERT club_premier OFF"; ;

				int clavePremier = contarRegistros("club_premier") + 1;

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

				conn.Close();


				MessageBox.Show("CLIENTE REGISTRADO.","ALTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Limpiar();
			}
		}

		public bool ValidarNombre(string n) {
			SqlConnection conn = UsoDB.ConectaBD(strCon);

			if (conn == null)
				return false;

			string strComando = "SELECT * FROM club_premier cp" +
			" INNER JOIN cliente c ON c.cveCliente = cp.cveCliente WHERE " +
			"nombre = '" + n + "';";
			SqlDataReader lector = UsoDB.Consulta(strComando,conn);

			if (lector.HasRows)
				return true;

			return false;

		}

		private void frmAltaClubPremier_Load(object sender,EventArgs e) {
			int c = contarRegistros("club_premier"); // se modificará con Identity
			txtClave.Text = Convert.ToString(c + 1);
		}

		private int contarRegistros (string tabla) {
			int r = 0;
			SqlConnection conn = UsoDB.ConectaBD(strCon);

			if (conn == null)
				return -1;

			string strComando = "SELECT COUNT(*) FROM " + tabla + ";";

			SqlDataReader lector = UsoDB.Consulta(strComando,conn);

			if (lector.HasRows)
				while (lector.Read())
					r = Convert.ToInt16(lector.GetValue(0));

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
