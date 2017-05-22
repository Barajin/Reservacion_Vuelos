using System;
using System.Windows.Forms;

namespace ProyectoVuelos {
	public partial class frmConsultaCiudad : Form {
		Ciudad[] arrayCiudades;
		public frmConsultaCiudad(Ciudad[] arrayCiudades) {
			InitializeComponent();
			this.arrayCiudades = arrayCiudades;
		}

		private void frmConsultaCiudad_Load(object sender,EventArgs e) {
			for (int i = 0; i < arrayCiudades.Length; i++) {
				Ciudad c = (Ciudad)arrayCiudades[i];
				if (c == null)
					break;

				dgvCiudades.Rows.Add(c.pClave,c.pNombre,c.pEstado);
			}
				
		}
	}
}
