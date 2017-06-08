using System;
using System.Collections;
using System.Windows.Forms;

namespace ProyectoVuelos {
	public partial class frmAltaVuelo : Form {
		Ciudad[] arrayCiudades;
		ArrayList arrayVuelos;
		private Vuelo newVuelo;
		int contador;
		string dias = "DIARIO";

		public frmAltaVuelo(Ciudad[] arrayCiudades,ArrayList arrayVuelos,int contador) {
			InitializeComponent();
			this.arrayCiudades = arrayCiudades;
			this.arrayVuelos = arrayVuelos;
			this.contador = contador;
		}

		private void btnGuardar_Click(object sender,EventArgs e) {
			int numPasajeros;
			string origen, destino;
			double costo, millas;

			int posicion;

			if (cmbOrigen.SelectedItem == null || cmbDestino.SelectedItem == null) {
				MessageBox.Show("DEBE SELECCIONAR ORIGEN Y DESTINO.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			if (rdDiario.Checked)
				dias = "DIARIO";

			if (rdDias.Checked) {
				dias = "";
				for (int i = 0; i <= (chkDias.Items.Count - 1); i++)
					if (chkDias.GetItemChecked(i))
						dias += (chkDias.Items[i].ToString().ToUpper() + " ");
			}

			origen = cmbOrigen.SelectedItem.ToString();
			posicion = CityPosition(origen);


			destino = cmbDestino.SelectedItem.ToString();
			posicion = CityPosition(destino);

			if (destino == origen) {
				MessageBox.Show("EL DESTINO NO PUEDE SER IGUAL AL ORIGEN.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			if (rdDias.Checked && chkDias.SelectedItems.Count == 0) {
				MessageBox.Show("DEBE SELECCIONAR AL MENOS 1 DÍA.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			numPasajeros = Convert.ToInt16(numericNumPasajeros.Value);

			try {
				costo = Convert.ToDouble(txtCosto.Text);
			} catch (FormatException ne) {
				MessageBox.Show("EL COSTO DEBE SER NUMÉRICO","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			if (costo <= 0) {
				MessageBox.Show("EL COSTO DEBE SER MAYOR A 0.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			try {
				millas = Convert.ToDouble(txtMillas.Text);
			} catch (FormatException ne) {
				MessageBox.Show("LAS MILLAS DEBEN SER NUMÉRICAS.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			if (millas <= 0) {
				MessageBox.Show("LAS MILLAS DEBEN SER MAYOR QUE 0.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			newVuelo = new Vuelo(arrayVuelos.Count + 1,numPasajeros,origen,destino,dias,0,costo,millas);
			arrayVuelos.Add(newVuelo);
			MessageBox.Show("VUELO AÑADIDO CON ÉXITO.","ALTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
			Limpiar();
		}

		private int CityPosition(string Nombre) {
			int Position = -1;

			for (int i = 0; i < contador; i++)
				if (arrayCiudades[i].pClave.CompareTo(Nombre) == 0) {
					Position = i;
					break;
				}

			return Position;
		}

		private void Limpiar() {
			txtCosto.Text = "";
			txtCveVuelo.Text = "";
			txtMillas.Text = "";
			cmbDestino.SelectedItem = null;
			cmbOrigen.SelectedItem = null;
			numericNumPasajeros.Value = 1;
			dias = "DIARIO";
			txtCveVuelo.Text = Convert.ToString(arrayVuelos.Count + 1);
			rdDiario.Checked = true;

			for (int i = 0; i <= (chkDias.Items.Count - 1); i++)
				chkDias.SetItemCheckState(i,CheckState.Unchecked);


		}

		private void frmAltaVuelo_Load(object sender,EventArgs e) {
			txtCveVuelo.Text = Convert.ToString(arrayVuelos.Count + 1);

			for (int i = 0; i < arrayCiudades.Length; i++) {
				Ciudad c = (Ciudad)arrayCiudades[i];
				if (c == null)
					break;

				cmbOrigen.Items.Add(c.pNombre);
				cmbDestino.Items.Add(c.pNombre);
			}


		}

		private void txtCosto_KeyPress(object sender,KeyPressEventArgs e) {

			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
				errorPCosto.SetError(txtCosto,"Sólo se permiten números.");
			else
				errorPCosto.SetError(txtCosto,"");
		}

		private void txtMillas_KeyPress(object sender,KeyPressEventArgs e) {

			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
				errorPMillas.SetError(txtMillas,"Sólo se permiten números.");
			else
				errorPMillas.SetError(txtMillas,"");
		}

		private void rdDias_CheckedChanged(object sender,EventArgs e) {
			if (rdDias.Checked) {
				chkDias.Enabled = true;
				dias = "";
			}
		}

		private void rdDiario_CheckedChanged(object sender,EventArgs e) {
			if (rdDiario.Checked) {
				chkDias.Enabled = false;
				dias = "DIARIO";
			}
		}

		private void chkDias_SelectedIndexChanged(object sender,EventArgs e) {
			dias = "";
			for (int i = 0; i <= (chkDias.Items.Count - 1); i++)
				if (chkDias.GetItemChecked(i))
					dias += (chkDias.Items[i].ToString().ToUpper() + " ");

		}
	}
}
