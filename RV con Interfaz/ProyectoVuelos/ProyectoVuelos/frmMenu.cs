using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoVuelos {
	public partial class frmMenu : Form {

		string[] pictures = { "b1.png", "b2.png","b3.png" };
		int i = 0;
		int contador = 0;

		private Ciudad[] arrayCiudades = new Ciudad[100];
		private Hashtable hashClub = new Hashtable();
		private ArrayList arrayVuelos = new ArrayList();
		private ArrayList arrayBoletos = new ArrayList();

		public frmMenu() {
			InitializeComponent();
		}

		private void salirToolStripMenuItem_Click(object sender,EventArgs e) {
			DialogResult d = MessageBox.Show("¿Está seguro de salir?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

			if(DialogResult.Yes == d)
				Application.Exit();

		}

		private void altaDeCiudadToolStripMenuItem_Click(object sender,EventArgs e) {
			Contar();

			if (contador == 100) {
				MessageBox.Show("YA NO HAY ESPACIO PARA MÁS CIUDADES.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			frmAltaCiudad fA = new frmAltaCiudad(arrayCiudades);
			fA.ShowDialog();
		}

		private void consultaDeCiudadesToolStripMenuItem_Click(object sender,EventArgs e) {
			Contar();
			if(contador == 0) {
				MessageBox.Show("NO SE HAN DADO DE ALTA CIUDADES.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			frmConsultaCiudad fC = new frmConsultaCiudad(arrayCiudades);
			fC.ShowDialog();
		}

		private void altaDeVuelosToolStripMenuItem_Click(object sender,EventArgs e) {
			if (contador <= 1) {
				MessageBox.Show("NO SE HAN DADO DE ALTA SUFICIENTES CIUDADES.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			int cont = 0;

			foreach (Vuelo v in arrayVuelos)
				if (v.pBoletosVendidos < v.pNumPasajeros)
					cont++;

			if (cont == 0) {
				MessageBox.Show("YA NO HAY VUELOS CON CAPACIDAD.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			frmAltaVuelo fV = new frmAltaVuelo(arrayCiudades, arrayVuelos, contador);
			fV.ShowDialog();
		}

		private void consultaDeVuelosToolStripMenuItem_Click(object sender,EventArgs e) {

			if (arrayVuelos.Count == 0) {
				MessageBox.Show("NO SE HAN DADO DE ALTA VUELOS.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}


			frmConsultaVuelo fV = new frmConsultaVuelo(arrayVuelos);
			fV.ShowDialog();
		}

		private void comprarBoletosToolStripMenuItem_Click(object sender,EventArgs e) {
			if (arrayVuelos.Count ==0) {
				MessageBox.Show("NO SE HAN DADO DE ALTA VUELOS.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			frmCompraBoleto fB = new frmCompraBoleto(arrayVuelos, arrayBoletos, hashClub);
			fB.ShowDialog();
		}

		private void Contar () {
			contador = 0;
			for (int i = 0; i < arrayCiudades.Length; i++) {
				Ciudad c = (Ciudad)arrayCiudades[i];
				if (c == null)
					break;

				contador++;
			}
		}

		private void consultarBoletosVendidosToolStripMenuItem_Click(object sender,EventArgs e) {
			if (arrayBoletos.Count == 0) {
				MessageBox.Show("NO SE HAN VENDIDO BOLETOS.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			frmConsultaBoleto fB = new frmConsultaBoleto(arrayBoletos);
			fB.ShowDialog();
		}

		private void altaDeClubPremierToolStripMenuItem_Click(object sender,EventArgs e) {
			frmAltaClubPremier fCP = new frmAltaClubPremier(hashClub);
			fCP.ShowDialog();
		}

		private void consultaClubPToolStripMenuItem_Click(object sender,EventArgs e) {
			if (hashClub.Count == 0) {
				MessageBox.Show("NO SE HAN DADO DE ALTA CLIENTES CLUB PREMIER.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			frmConsultaClubPremier fCP = new frmConsultaClubPremier(hashClub);
			fCP.ShowDialog();
		}

		private void btnSalir_Click(object sender,EventArgs e) {
			DialogResult d = MessageBox.Show("¿Está seguro de salir?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

			if (DialogResult.Yes == d)
				Application.Exit();
		}

		private void frmMenu_Load(object sender,EventArgs e) {
			pictureBoxMenu.Image = Image.FromFile("images/" + pictures[0]);
		}

		private void toolStripButton1_Click(object sender,EventArgs e) {
			timerMenu.Enabled = false;
			i++;
			if (pictures.Length == i)
				i = 0;
			pictureBoxMenu.Image = Image.FromFile("images/" + pictures[i]);
			timerMenu.Enabled = true;

		}

		private void toolStripButton2_Click(object sender,EventArgs e) {
			timerMenu.Enabled = false;
			if (i == 0)
				i = pictures.Length; 
			i--;
			pictureBoxMenu.Image = Image.FromFile("images/" + pictures[i]);
			timerMenu.Enabled = true;
		}

		private void timerMenu_Tick(object sender,EventArgs e) {
			i++;
			if (pictures.Length == i)
				i = 0;

			pictureBoxMenu.Image = Image.FromFile("images/" + pictures[i]);
		}

		private void salirToolStripMenuItem_Click_1(object sender,EventArgs e) {
			DialogResult d = MessageBox.Show("¿Está seguro de salir?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

			if (DialogResult.Yes == d)
				Application.Exit();
		}

		private void xToolStripMenuItem_Click(object sender,EventArgs e) {
			frmInfo fI = new frmInfo();
			fI.ShowDialog();
		}

		private void consultaToolStripMenuItem_Click(object sender,EventArgs e) {
			if (arrayBoletos.Count == 0) {
				MessageBox.Show("AÚN SE HAN VENDIDO BOLETOS.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			frmConsultaBoleto fB = new frmConsultaBoleto(arrayBoletos);
			fB.ShowDialog();
		}

		private void toolStripMenuItem1_Click(object sender,EventArgs e) {
			frmLogo fL = new frmLogo();
			fL.ShowDialog();
		}
	}
}
