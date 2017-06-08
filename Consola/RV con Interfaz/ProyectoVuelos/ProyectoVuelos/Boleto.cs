using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVuelos {
	class Boleto {
		private string claveBoleto;
		private string nomPasajero;
		private int edadPasajero;
		private int claveVuelo;
		private int claveClubPremier;

		public Boleto(string claveBoleto,string nomPasajero,int edadPasajero,int claveVuelo) {
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

		public int ClaveVuelo {
			get { return claveVuelo; }
			set { claveVuelo = value; }
		}

		public int ClaveClubPremier {
			get { return claveClubPremier; }
			set { claveClubPremier = value; }
		}
	}
}
