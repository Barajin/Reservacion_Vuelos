namespace KatyProject {
	public class Vuelo {
		
		private string Origen, Destino, Dias;
		private int NumPasajeros, Capacidad, BoletosVendidos;
		private double Costo, Millas;

		public Vuelo (string Origen, string Destino, string Dias, int NumPasajeros, int Capacidad, 
		              int BoletosVendidos, double Costo, double Millas) {
			this.Origen = Origen;
			this.Destino = Destino;
			this.Dias = Dias;
			this.NumPasajeros = NumPasajeros;
			this.Capacidad = Capacidad;
			this.BoletosVendidos = BoletosVendidos;
			this.Costo = Costo;
			this.Millas = Millas;
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

		public int pNumPasajeros {
			get { return NumPasajeros ; }
			set { NumPasajeros = value; }
		}

		public int pCapacidad {
			get { return Capacidad; }
			set { Capacidad = value; }
		}

		public int pBoletosVendidos {
			get { return BoletosVendidos; }
			set { BoletosVendidos = value; }
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