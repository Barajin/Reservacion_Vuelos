using System;
using System.Collections;
using System.Windows.Forms;

namespace ProyectoVuelos {
	public partial class frmConsultaBoleto : Form {

		ArrayList arrayBoletos;
		public frmConsultaBoleto(ArrayList arrayBoletos) {
			InitializeComponent();
			this.arrayBoletos = arrayBoletos;
		}

		private void frmConsultaBoleto_Load(object sender,EventArgs e) {
			foreach(Boleto b in arrayBoletos) 
				dgvBoletos.Rows.Add(b.ClaveBoleto,b.ClaveVuelo,b.Nompasajero,b.EdadPasajero, b.ClaveClubPremier);
			
		}
	}
}
