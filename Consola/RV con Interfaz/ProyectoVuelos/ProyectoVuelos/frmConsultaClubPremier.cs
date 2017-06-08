using System;
using System.Collections;
using System.Windows.Forms;

namespace ProyectoVuelos {
	public partial class frmConsultaClubPremier : Form {
		Hashtable hashClub;
		public frmConsultaClubPremier(Hashtable hashClub) {
			InitializeComponent();
			this.hashClub = hashClub;
		}

		private void frmConsultaClubPremier_Load(object sender,EventArgs e) {
			ICollection i = hashClub.Keys;
			foreach (int clave in i)
				cmbCve.Items.Add(clave);
		}

		private void cmbCve_SelectedIndexChanged(object sender,EventArgs e) {
			int cve = Convert.ToInt16(cmbCve.SelectedItem);
			ClubPremier c = (ClubPremier)hashClub[cve];
			txtNombre.Text = c.Nombre;
			txtDomicilio.Text = c.Domicilio;
			txtMillas.Text = c.Millas.ToString();
		}
	}
}
