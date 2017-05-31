namespace Reservación_Vuelos {
	public class Vuelo {

		private string Origen, Destino, Dias;
		private int BoletosVendidos, claveVuelo, numPasajeros;
		private double Costo, Millas, Capacidad;

		public Vuelo (int claveVuelo, int numPasajeros, string Origen, string Destino, string Dias, double Capacidad, 
		              int BoletosVendidos, double Costo, double Millas) {
			this.claveVuelo = claveVuelo;
			this.numPasajeros = numPasajeros;
			this.Origen = Origen;
			this.Destino = Destino;
			this.Dias = Dias;
			this.Capacidad = Capacidad;
			this.BoletosVendidos = BoletosVendidos;
			this.Costo = Costo;
			this.Millas = Millas;
		}

		public int pClaveVuelo { 
			get { return claveVuelo; }
			set { claveVuelo = value; }
		}

		public int pNumPasajeros {
			get { return numPasajeros; }
			set { numPasajeros = value; }
		}

		public string pOrigen {
			get { return Origen; }
			set { Origen = value; }
		}

		public string pDestino {
			get { return Destino; }
			set { Destino = value; }
		}

		public string pDias {
			get { return Dias; }
			set { Dias = value; }
		}

		public double pCapacidad {
			get { return Capacidad; }
			set { Capacidad = value; }
		}

		public int pBoletosVendidos {
			get { return BoletosVendidos; }
			set {
				if (BoletosVendidos < numPasajeros)
					BoletosVendidos += value;
				else
					System.Console.WriteLine("\n>> YA NO HAY ESPACIO EN ESE VUELO <<\n");
			}
		}

		public double pCosto {
			get { return Costo; }
			set { Costo = value; }
		}

		public double pMillas {
			get { return Millas; }
			set { Millas = value; }
		}
	}
}