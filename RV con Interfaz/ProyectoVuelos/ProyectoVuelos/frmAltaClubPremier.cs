using System;
using System.Collections;
using System.Windows.Forms;

namespace ProyectoVuelos {
	public partial class frmAltaClubPremier : Form {

		Hashtable hashClub;
		private ClubPremier newCliente;

		public frmAltaClubPremier(Hashtable hashClub) {
			InitializeComponent();
			this.hashClub = hashClub;
		}

		private void btnGuardar_Click(object sender,EventArgs e) {
			string nombre, domicilio;
			double millas = 0.0;

			nombre = txtNombre.Text;

			if(nombre == "" || txtDomicilio.Text == "") { 
				MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			if (ValidarNombre(nombre))
				MessageBox.Show("ESE CLIENTE YA ESTÁ REGISTRADO.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			else {
				domicilio = txtDomicilio.Text;
				newCliente = new ClubPremier(nombre,domicilio,millas);
				hashClub.Add(hashClub.Count + 1,newCliente);
				MessageBox.Show("CLIENTE REGISTRADO.","ALTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Limpiar();
			}
		}

		public bool ValidarNombre(string n) {
			foreach (DictionaryEntry entry in hashClub) {
				ClubPremier c = (ClubPremier)entry.Value;
				if (c.Nombre.CompareTo(n) == 0)
					return true;
			}

			return false;
		}

		private void frmAltaClubPremier_Load(object sender,EventArgs e) {
			txtClave.Text = Convert.ToString(hashClub.Count + 1);
		}

		private void Limpiar() {
			txtDomicilio.Text = "";
			txtNombre.Text = "";
			txtClave.Text = Convert.ToString(hashClub.Count + 1);
		}

		private void txtNombre_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPNombre.SetError(txtNombre,"Sólo se permiten letras.");
			else
				errorPNombre.SetError(txtNombre,"");
		}
	}
}
