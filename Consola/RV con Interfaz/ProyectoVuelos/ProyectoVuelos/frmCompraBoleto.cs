using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoVuelos {
	public partial class frmCompraBoleto : Form {
		ArrayList arrayVuelos;
		ArrayList arrayBoletos;
		private Boleto newBoleto;
		Hashtable hashClub;
		private Random random = new Random();
		string claveBoleto;

		public frmCompraBoleto(ArrayList arrayVuelos, ArrayList arrayBoletos, Hashtable hashClub) {
			InitializeComponent();
			this.arrayBoletos = arrayBoletos;
			this.arrayVuelos = arrayVuelos;
			this.hashClub = hashClub;
		}

		private void btnComprar_Click(object sender,EventArgs e) {
			int claveVuelo, claveClub;
			string nomPasajero;
			int edad;

			if(cmbCveVuelo.SelectedItem == null) {
				MessageBox.Show("DEBE SELECCIONAR UN VUELO.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			claveVuelo = Convert.ToInt16(cmbCveVuelo.SelectedItem);

				if (chkClubPremier.Checked) {


				try {
					claveClub = Convert.ToInt16(txtClavePremier.Text);
				} catch (FormatException ne) {
					MessageBox.Show("LA CLAVE DEBE SER NUMÉRICA.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}

				if (!hashClub.ContainsKey(claveClub)) {
					MessageBox.Show("NO EXISTE ESA CLAVE DE CLUB PREMIER.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}

				nomPasajero = ((ClubPremier)hashClub[claveClub]).Nombre;

				try {
					edad = Convert.ToInt16(txtEdad.Text);
				} catch (FormatException ne) {
					MessageBox.Show("LA EDAD DEBE SER NUMÉRICA.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}

				if(edad<1) {
					MessageBox.Show("INGRESE UNA EDAD VÁLIDA.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}

				if(nomPasajero == "") {
					MessageBox.Show("DEBE INGRESAR EL NOMBRE DEL PASAJERO.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}
			

					newBoleto = new Boleto(claveBoleto,nomPasajero,edad,claveVuelo);
					newBoleto.ClaveClubPremier = claveClub;

					existePremier(claveClub).Millas = existeVuelo(claveVuelo).pMillas;
					existeVuelo(claveVuelo).pBoletosVendidos = 1;

					arrayBoletos.Add(newBoleto);
				MessageBox.Show("BOLETO VENDIDO.","VENTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
			} else {
					nomPasajero = txtNombrePasajero.Text;
				if (nomPasajero == "") {
					MessageBox.Show("DEBE INGRESAR EL NOMBRE DEL PASAJERO.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}
				try {
					edad = Convert.ToInt16(txtEdad.Text);
				} catch (FormatException ne) {
					MessageBox.Show("LA EDAD DEBE SER NUMÉRICA.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}
				newBoleto = new Boleto(claveBoleto,nomPasajero,edad,claveVuelo);
					arrayBoletos.Add(newBoleto);
					existeVuelo(claveVuelo).pBoletosVendidos = 1;
					MessageBox.Show("BOLETO VENDIDO.","VENTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}

			Limpiar();
		}


		private bool existeBoleto(string claveBoleto) {
			foreach (Boleto val in arrayBoletos)
				if (val.ClaveBoleto.Equals(claveBoleto))
					return true;

			return false;
		}


		private string RandomKey(int length) {
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars,length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}

		private Vuelo existeVuelo(int clave) {
			foreach (Vuelo val in arrayVuelos)
				if ((val.pClaveVuelo == clave) && (val.pBoletosVendidos < val.pNumPasajeros))
					return val;

			return null;
		}

		private ClubPremier existePremier(int key) {
			foreach (DictionaryEntry entry in hashClub)
				if (entry.Key.Equals(key))
					return (ClubPremier)entry.Value;

			return null;
		}

		private void Limpiar() {
			txtCosto.Text = "";
			txtDestino.Text = "";
			txtEdad.Text = "";
			txtNombrePasajero.Text = "";
			txtOrigen.Text = "";
			lblCvePremier.Enabled = false;
			lblCvePremier.Visible = false;
			txtClavePremier.Enabled = false;
			txtClavePremier.Visible = false;
			txtNombrePasajero.Enabled = true;
			txtNombrePasajero.Text = "";
			txtClavePremier.Text = "";
			chkClubPremier.Checked = false;
			cmbCveVuelo.SelectedItem = null;

			int cont = 0;

			foreach (Vuelo v in arrayVuelos)
				if (v.pBoletosVendidos < v.pNumPasajeros)
					cont++;

			if(cont == 0) {
				MessageBox.Show("YA NO HAY VUELOS CON CAPACIDAD.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				this.Close();
			}

			
			cmbCveVuelo.Items.Clear();

			foreach (Vuelo v in arrayVuelos)
				if (v.pBoletosVendidos < v.pNumPasajeros)
					cmbCveVuelo.Items.Add(v.pClaveVuelo);

			CrearClave();


		}

		private void frmCompraBoleto_Load(object sender,EventArgs e) {
			CrearClave();
			foreach (Vuelo v in arrayVuelos) 
				if (v.pBoletosVendidos < v.pNumPasajeros)
					cmbCveVuelo.Items.Add(v.pClaveVuelo);
			
		}

		private void CrearClave () {
			do {
				claveBoleto = RandomKey(15).Trim().ToUpper();
			} while (existeBoleto(claveBoleto));

			txtClaveBoleto.Text = claveBoleto;
		}

		private void txtClavePremier_Leave(object sender,EventArgs e) {

			int claveClub; 

			try {
				claveClub = Convert.ToInt16(txtClavePremier.Text);
			} catch (FormatException ne) {
				MessageBox.Show("LA CLAVE DEBE SER NUMÉRICA.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			if (!hashClub.ContainsKey(claveClub)) {
				MessageBox.Show("NO EXISTE ESA CLAVE DE CLUB PREMIER.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			txtNombrePasajero.Text = ((ClubPremier)hashClub[claveClub]).Nombre;

		}

		private void chkClubPremier_CheckedChanged(object sender,EventArgs e) {
			if (chkClubPremier.Checked) {
				lblCvePremier.Enabled = true;
				lblCvePremier.Visible = true;
				txtClavePremier.Enabled = true;
				txtClavePremier.Visible = true;
				txtNombrePasajero.Enabled = false;
			} else {
				txtClavePremier.Text = "";
				lblCvePremier.Enabled = false;
				lblCvePremier.Visible = false;
				txtClavePremier.Enabled = false;
				txtClavePremier.Visible = false;
				txtNombrePasajero.Enabled = false;
				txtNombrePasajero.Text = "";
			}
			}

		private void cmbCveVuelo_SelectedIndexChanged(object sender,EventArgs e) {
			int claveVuelo = Convert.ToInt16(cmbCveVuelo.SelectedItem);

			foreach (Vuelo val in arrayVuelos)
				if (val.pClaveVuelo == claveVuelo) {
					txtOrigen.Text = val.pOrigen;
					txtDestino.Text = val.pDestino;
					txtCosto.Text = val.pCosto.ToString();
					break;
				}
		}

		private void txtClavePremier_KeyPress(object sender,KeyPressEventArgs e) {
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPCvePremier.SetError(txtClavePremier,"Sólo se permiten números.");
			else
				errorPCvePremier.SetError(txtClavePremier,"");
		}

		private void txtEdad_KeyPress(object sender,KeyPressEventArgs e) {
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPEdad.SetError(txtEdad,"Sólo se permiten números.");
			else
				errorPEdad.SetError(txtEdad,"");

		}


		private void txtNombrePasajero_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPNombre.SetError(txtNombrePasajero,"Sólo se permiten letras.");
			else
				errorPNombre.SetError(txtNombrePasajero ,"");
		}
	}
}
