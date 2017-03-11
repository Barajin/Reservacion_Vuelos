using System;
using System.Collections;
using System.Linq;
using ConsoleTables;

namespace KatyProject {
	class MainClass {

		private Ciudad[] Arreglo = new Ciudad[100];
		private int Contador = 0;
		private ReadHelper read = new ReadHelper();
		private Hashtable hashClub = new Hashtable();
		private ArrayList arrayVuelos = new ArrayList();
		private ArrayList boletosVendidos = new ArrayList();
		private Vuelo newVuelo;
		private Boleto newBoleto;
		private ClubPremier newCliente; //Tengo declarado el objeto a la altura de la clase para 
		                                // hacer pool de objetos y no estar creando nuevas instancias
		                               
		public static void Main (string[] args) {
			MainClass here = new MainClass();
			here.Menu();
		}


		private void Menu(){

			int opc;
			do {
				Console.WriteLine("1.- Alta de ciudades.");
				Console.WriteLine("2.- Alta de vuelos.");
				Console.WriteLine("3.- Alta club premier.");
				Console.WriteLine("4.- Compra de boletos.");
				Console.WriteLine("5.- Consulta de vuelos disponibles.");
				Console.WriteLine("6.- Salir.");

				Console.Write("=> ");
				opc = read.ReadInt();

				Console.Clear();
				switch (opc) {

					case 1:
						AltaCiudades();
						break;

					case 2:
						AltaVuelo();
						break;

					case 3:
						AltaClubPremier();
						break;

					case 4:
					    CompraBoletos();
						break;

					case 5:
					ImprimeVuelos();
						break;

					case 6:
						opc = Salir();
						break;

					default:
					Console.WriteLine("================================");
					Console.WriteLine("Esa no fue una opción válida. :c");
					Console.WriteLine("================================");
					break;

				}
			} while(opc != 6);
		}

		private void AltaClubPremier() {

			string claveClub, nombre, domicilio;
			double millas=0.0;

			Console.WriteLine("==========================");
			Console.WriteLine("$$ ALTA DE CLUB PREMIER $$");
			Console.WriteLine("==========================");

			Console.Write("Clave del usuario: ");
			claveClub = read.ReadString();
			if (hashClub.ContainsKey(claveClub.ToUpper().Trim())) {
				Console.WriteLine("Esa clave ya existe.");
			} else { 
				Console.Write("Nombre del cliente: ");
				nombre = read.ReadString();
				Console.Write("Domicilio: ");
				domicilio = read.ReadString();
				newCliente = new ClubPremier(NString(claveClub), NString(nombre), NString(domicilio), millas);
				hashClub.Add(NString(claveClub), newCliente);
				Console.WriteLine("\n>> Cliente añadido al club exitosamente <<\n");
			}
		}

		//String chido para guardarse :) y leer de manera correcta.
		private string NString(string str) {
			return str.ToUpper().Trim();
		}

		private void AltaVuelo () {
			// Primero validar si hay ciudades disponibles
			if (Contador == 0) {
				Console.WriteLine("\n>> Aún no se han agregado ciudades <<\n");
				return;
			}

			int numPasajeros, capacidad, boletosVendidos;
			string origen, destino, dias, claveVuelo;
			double costo, millas; 

			Console.WriteLine("==========================");
			Console.WriteLine("$$ ALTA DE VUELOS $$");
			Console.WriteLine("==========================");

			Console.Write("Clave del vuelo: ");
			claveVuelo = read.ReadString();

			Console.Write("Número de pasajeros: ");
			numPasajeros = read.ReadInt();

			// Validar que existan en el arreglo de objetos
			int posicion;
			do {
				Console.Write("Origen: ");
				origen = read.ReadString().Trim().ToUpper();
				posicion = CityPosition(origen);

				if (posicion == -1) 
					Console.WriteLine("\nNo existe esa ciudad. Ingrese otra. \n");
				
			} while (posicion == -1);

			do {
				Console.Write("Destino: ");
				destino = read.ReadString().Trim().ToUpper();
				posicion = CityPosition(destino);

				if (posicion == -1)
					Console.WriteLine("\nNo existe esa ciudad. Ingrese otra. \n");

			} while (posicion == -1);


			Console.Write("Capacidad: ");
			capacidad = read.ReadInt();
			Console.Write("Boletos vendidos: ");
			boletosVendidos = read.ReadInt();
			Console.Write("Costo: ");
			costo = read.ReadDouble();
			Console.Write("Millas: ");
			millas = read.ReadDouble();

			do {
				Console.WriteLine("Días en que se realiza el vuelo: ");
				Console.WriteLine("1.- Diaria\n2.- Lunes\n3.- Martes\n4.- Miércoles\n5.- Jueves\n6.- Viernes\n7.- Sábado" +
							  "\n8.- Domingo");
				Console.Write("\nOpción: ");
				int opc = read.ReadInt();
				dias = DiaVuelo(opc);
			} while (dias == "");

			Vuelo vuelo = new Vuelo(claveVuelo,origen, destino, dias, numPasajeros, capacidad, boletosVendidos, costo, millas);
			arrayVuelos.Add(vuelo);
			Console.WriteLine("\n>> Vuelo añadido exitosamente, enter para volver al menú <<\n");
			Console.ReadLine();
			Console.Clear();

		}

		private string DiaVuelo (int dia) {
			switch(dia) {
				case 1: return "DIARIA";
				case 2: return "LUNES";
				case 3: return "MARTES";
				case 4: return "MIÉRCOLES";
				case 5: return "JUEVES";
				case 6: return "VIERNES";
				case 7: return "SÁBADO";
				case 8: return "DOMINGO";
				default: 
					Console.WriteLine("\n>> OPCIÓN INVÁLIDA << \n");
					return "";
			}
		}

		private int Salir() {
			int opc;
			Console.WriteLine("==========================");
			Console.WriteLine("Estás saliendo del sistema");
			Console.WriteLine("==========================");
			Console.WriteLine("  ¡Los datos se perderan!");
			Console.WriteLine("1.- Para salir.");
			Console.WriteLine("2.- Para volver.");
			Console.Write("=> ");
			opc = read.ReadInt();
			switch (opc) { 
				case 1:
				return 6;

				case 2:
				return 0;

			}
			return 0;
		}

		//METHOD TO SAVE CITIES.
		private void AltaCiudades () {
			// Validar que haya espacio
			Console.Write("Introduzca clave de la ciudad: ");
			string clave = read.ReadString().Trim().ToUpper();
			Console.Write("Introduzca nombre de la ciudad: ");
			string nombre = read.ReadString().Trim().ToUpper();
			Console.Write("Introduzca estado de la ciudad: ");
			string estado = read.ReadString().Trim().ToUpper();
			Console.WriteLine("\nCiudad guardada.\n");
			Ciudad City = new Ciudad(clave, nombre, estado);
			Arreglo[Contador] = City;
			Contador++;
		}

		//METHOD TO PRINT CITIES.
		private void Ciudades () {
			if (Contador == 0) {
				Console.WriteLine("No se han ingresado ciudades.");
			} else {
				for (int i = 0; i < Contador; i++) {
					Console.WriteLine("Ciudad: {0} | Estado: {1} | Clave: {2}", Arreglo[i].pNombre, Arreglo[i].pEstado, Arreglo[i].pClave);
				}
			}
		}

		//METHOD TO GET CITY OBJECT
		private Ciudad CityObject () {
			Ciudad ciudad = null;
			if (Contador == 0) {
				Console.WriteLine("\nNo se han agregado ciudades.\n");
			} else {
				Console.Write("Introduzca nombre de la ciudad: ");
				string Nombre = read.ReadString().Trim().ToUpper();
				for (int i = 0; i < Contador; i++) {
					if (Arreglo[i].pNombre.CompareTo(Nombre) == 0) {
						ciudad = Arreglo[i];
						break;
					}
				}
			}
			return ciudad;
		}

		//METHOD TO GET CITY POSITION IN ARRAY
		private int CityPosition (string Nombre) {
			int Position = -1;

				for (int i = 0; i < Contador; i++) {
					if (Arreglo[i].pNombre.CompareTo(Nombre) == 0) {
						Position = i;
						break;
					}
				}

			return Position;
		}

		private void CompraBoletos() {
			string claveBoleto, nomPasajero, claveVuelo, claveClub;
			int edad, opc;

			do  
				claveBoleto = RandomString(34);
			while (ExisteBoleto(NString(claveBoleto)));

			Console.Write("Nombre Pasajero:");
			nomPasajero = NString(read.ReadString());
			Console.Write("Edad del pasajero:");
			edad = read.ReadInt();
			Console.WriteLine("Claves de vuelo disponibles");

			Console.Write("Clave del vuelo:");
			claveVuelo = NString(read.ReadString());


			if (existeVuelo(claveVuelo) == null) {
				Console.WriteLine("No existe ese vuelo.");
			} else {
				
				Console.Write("¿Club premier? 1.- Si , 2.- No");
				opc = read.ReadInt(1, 2);
				if (opc == 1) {
					do {
						Console.Write("Clave del club premier:");
						claveClub = NString(read.ReadString());
					} while (hashClub.ContainsKey(NString(claveClub)));

					newBoleto = new Boleto(claveBoleto, nomPasajero, edad, claveVuelo);
					newBoleto.ClaveClubPremier = claveClub;

					existePremier(claveClub).Millas = existeVuelo(claveVuelo).pMillas;
					existeVuelo(claveVuelo).pBoletosVendidos = 1;

					boletosVendidos.Add(newBoleto);
					Console.WriteLine("Boleto comprado vendido.");
				} else {
					newBoleto = new Boleto(claveBoleto, nomPasajero, edad, claveVuelo);
					boletosVendidos.Add(newBoleto);
					Console.WriteLine("Boleto comprado vendido.");
				}
			}


			
		}

		private static Random random = new Random();
		public static string RandomString(int length) {
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}

		private Vuelo existeVuelo(string clave) {

			foreach (Vuelo val in arrayVuelos) 
				if (val != null)
					if (val.pClaveVuelo.Equals(clave))
						return val;

			return null;
		}

		private bool ExisteBoleto(string claveBoleto) {

			foreach (Boleto val in boletosVendidos)
				if (val.ClaveBoleto.Equals(claveBoleto))
					return true;
			
			return false;
		}

		private void ImprimeVuelos() {
			var table = new ConsoleTable("Clave de vuelo","num Pasajeros","capacidad","destino");

			foreach (Vuelo val in arrayVuelos)
				table.AddRow(val.pClaveVuelo, val.pNumPasajeros, val.pCapacidad, val.pDestino);
			
			table.Write();
			Console.WriteLine();

		}

		private ClubPremier existePremier(string key) {

			foreach (DictionaryEntry entry in hashClub) {
				if (entry.Key.Equals(key))
					return (ClubPremier) entry.Value;
			}


			return null;
		}

	}
}