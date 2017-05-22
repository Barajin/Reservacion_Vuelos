using System;
using System.Collections;
using System.Windows.Forms;

namespace ProyectoVuelos {
	public partial class frmAltaCiudad : Form {
		Ciudad[] arrayCiudades;
		int contador = 0;
		public frmAltaCiudad(Ciudad[] arrayCiudades) {
			InitializeComponent();
			this.arrayCiudades = arrayCiudades;
			Contar();
		}

		private void Contar() {
			contador = 0;
			for (int i = 0; i < arrayCiudades.Length; i++) {
				Ciudad c = (Ciudad)arrayCiudades[i];
				if (c == null)
					break;

				contador++;
			}
		}

		private void btnGuardar_Click(object sender,EventArgs e) {

			if (contador == 100) {
				MessageBox.Show("YA SE HAN REGISTRADO LAS 100 CIUDADES","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}


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

			Ciudad City = new Ciudad(clave,ciudad,estado);
			arrayCiudades[contador] = City;
			MessageBox.Show("CIUDAD GUARDADA.","ALTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
			Limpiar();
			Contar();


		}

		private bool ValidarClave(string cve) {
			for (int i = 0; i < contador; i++) {
				Ciudad c = arrayCiudades[i];
				if (c.pClave.CompareTo(cve) == 0)
					return true;
			}

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
