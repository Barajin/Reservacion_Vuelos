using System;
namespace KatyProject {
	public class Boleto {

		private string claveBoleto;
		private string nomPasajero;
		private int edadPasajero;
		private string claveVuelo;
		private string claveClubPremier;

		public Boleto(string claveBoleto,string nomPasajero,int edadPasajero,string claveVuelo) {
			this.claveBoleto = claveBoleto;
			this.nomPasajero = nomPasajero;
			this.edadPasajero = edadPasajero;
			this.claveVuelo = claveVuelo;
		}

		public string ClaveBoleto {
			get { return claveBoleto; }
			set { claveBoleto = value; }
		}

		public string Nompasajero { 
			get { return nomPasajero; }
			set { nomPasajero = value; }
		}

		public int EdadPasajero { 
			get { return edadPasajero; }
			set { edadPasajero = value; }
		}

		public string ClaveVuelo { 
			get { return claveVuelo; }
			set { claveVuelo = value; }
		}

		public string ClaveClubPremier { 
			get { return claveClubPremier; }
			set { claveClubPremier = value; }
		}

	}
}
