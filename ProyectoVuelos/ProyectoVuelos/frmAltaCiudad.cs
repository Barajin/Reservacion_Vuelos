using System;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;

namespace ProyectoVuelos {
	public partial class frmAltaCiudad : Form {

		const string strCon = "Data Source=KARENGGV\\SQLEXPRESS;Initial Catalog=reservación_vuelos;Integrated Security=True";


		public frmAltaCiudad() {
			InitializeComponent();
		}


		private void btnGuardar_Click(object sender,EventArgs e) {

			string clave = txtClave.Text;
			string ciudad = txtCiudad.Text;
			string estado = txtEstado.Text;

			if (clave == "" || ciudad == "" || estado == "") {
				MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			if (ValidarClave(clave)) {
				MessageBox.Show("YA EXISTE UNA CIUDAD CON ESA CLAVE.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			SqlConnection conn = UsoDB.ConectaBD(strCon);

			if (conn == null)
				return;

			string strComando = "INSERT INTO ciudad(cveCiudad, nombreCiudad, estado)";
			strComando += " VALUES (@clave, @nombre, @estado)";

			SqlCommand cmd = new SqlCommand(strComando,conn);
			cmd.Parameters.AddWithValue("@clave",clave);
			cmd.Parameters.AddWithValue("@nombre",ciudad);
			cmd.Parameters.AddWithValue("@estado",estado);


			try {
				cmd.ExecuteNonQuery();
			} catch (Exception ex) {

				MessageBox.Show(ex.Message);
				return;
			}

			conn.Close();
			MessageBox.Show("CIUDAD GUARDADA.","ALTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
			Limpiar();

		}

		private bool ValidarClave(string cve) {
			SqlConnection conn = UsoDB.ConectaBD(strCon);

			if (conn == null)
				return false;

			string strComando = "SELECT * FROM ciudad WHERE cveCiudad = '" + cve + "';";

			SqlDataReader lector = UsoDB.Consulta(strComando,conn);

			if (lector.HasRows)
				return true;

			return false;
		}

		private void Limpiar () {
			txtEstado.Text = "";
			txtClave.Text = "";
			txtCiudad.Text = "";
		}

		private void txtCiudad_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPCiudad.SetError(txtCiudad,"Sólo se permiten letras.");
			else
				errorPCiudad.SetError(txtCiudad,"");
		}

		private void txtEstado_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPEstado.SetError(txtEstado,"Sólo se permiten letras.");
			else
				errorPEstado.SetError(txtEstado,"");
		}

		private void txtClave_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPClave.SetError(txtClave,"Sólo se permiten letras.");
			else
				errorPClave.SetError(txtClave,"");
		}
	}
}
