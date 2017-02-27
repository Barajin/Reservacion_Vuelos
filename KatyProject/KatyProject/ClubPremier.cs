using System;
namespace KatyProject {
	public class ClubPremier {
		//clave del club premier, Nombre, Domicilio, Millas acomuladas.
		private string claveClub;
		private string nombre;
		private string domicilio;
		private double millas;

		public ClubPremier(string claveClub,string nombre, string domicilio, double millas) {
			this.claveClub = claveClub;
			this.nombre = nombre;
			this.domicilio = domicilio;
			this.millas = millas;
		}

		public string ClaveClup { 
			get { return claveClub; }
			set { claveClub = value; }
		}

		public string Nombre { 
			get { return nombre; }
			set { nombre = value; }
		}

		public string Domicilio {
			get { return domicilio; }
			set { domicilio = value; }
		}

		public double Millas { 
			get { return millas; }
			set { millas = value; }
		}
	}
}
