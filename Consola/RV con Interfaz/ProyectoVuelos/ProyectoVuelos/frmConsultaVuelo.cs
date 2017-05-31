using System;
using System.Collections;
using System.Windows.Forms;

namespace ProyectoVuelos {
	public partial class frmConsultaVuelo : Form {
		ArrayList arrayVuelos;
		public frmConsultaVuelo(ArrayList arrayVuelos) {
			InitializeComponent();
			this.arrayVuelos = arrayVuelos;
		}

		private void dgvVuelos_CellContentClick(object sender,DataGridViewCellEventArgs e) {

		}

		private void frmConsultaVuelo_Load(object sender,EventArgs e) {
			foreach (Vuelo v in arrayVuelos)
				dgvVuelos.Rows.Add(v.pClaveVuelo,v.pOrigen,v.pDestino,v.pBoletosVendidos,v.pNumPasajeros,v.pDias,
					v.pCosto,v.pMillas);
		}
	}
}
