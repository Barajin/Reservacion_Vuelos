using System;
using System.Collections;
using System.Linq; // Linq sólo se usó para el método random key
using ConsoleTables;
using ReadHelperLibrary;

namespace Reservación_Vuelos {
	class MainClass {

		private int Contador = 0;
		private Ciudad[] Arreglo = new Ciudad[100];
		private Hashtable hashClub = new Hashtable();
		private ArrayList arrayVuelos = new ArrayList();
		private ArrayList boletosVendidos = new ArrayList();
		private Vuelo newVuelo;
		private Boleto newBoleto;
		private Random random = new Random();
		private ClubPremier newCliente; //Tengo declarado el objeto a la altura de la clase para 
		                                // hacer pool de objetos y no estar creando nuevas instancias
		                               
		public static void Main (string[] args) {
			MainClass here = new MainClass();
			here.Menu();
		}

		private void Menu(){

			int opc;
			do {
				Console.Clear();
				Console.WriteLine("1.- Alta de ciudades.");
				Console.WriteLine("2.- Alta de vuelos.");
				Console.WriteLine("3.- Alta club premier.");
				Console.WriteLine("4.- Compra de boletos.");
				Console.WriteLine("5.- Consulta de vuelos disponibles.");
				Console.WriteLine("6.- Club Premier.");
				Console.WriteLine("7.- Boletos vendidos.");
				Console.WriteLine("8 - Salir.");
				opc = ReadHelperLibrary.Class1.ReadInt("=> ");
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
					    Vuelos();
						break;
					case 6:
				    	ClubPremier();
						break;
					case 7:
						BoletosVendidos();
						break;
					case 8:
						opc = Salir();
						break;
					default:
						Console.WriteLine("Esa no fue una opción válida. :c");
						ConfirmarSalida();
						Console.Clear();
						break;
				}
			} while(opc != 8);
		}

		// ALTAS 
		private void AltaClubPremier() {
			string nombre, domicilio;
			double millas=0.0;

			Console.WriteLine("==========================");
			Console.WriteLine("$$ ALTA DE CLUB PREMIER $$");
			Console.WriteLine("==========================");

			nombre = ReadHelperLibrary.Class1.ReadString("Nombre del cliente: ");

			if (ValidarNombre(nombre))
				Console.WriteLine("\n>> Ese cliente ya está registrado en Club Premier <<\n");
			else {
				domicilio = ReadHelperLibrary.Class1.ReadString("Domicilio: ");
				newCliente = new ClubPremier(nombre, domicilio, millas);
				hashClub.Add(hashClub.Count + 1, newCliente);
				Console.WriteLine("\n>> Cliente añadido al club exitosamente <<\n");
			}
	
			ConfirmarSalida();
		}

		private void AltaVuelo () {
			// Primero validar si hay ciudades disponibles
			if (Contador <2 ) {
				Console.WriteLine("\n>> Aún no se han agregado suficientes ciudades <<\n");
				ConfirmarSalida();
				return;
			}

			int numPasajeros;
			string origen, destino, dias;
			double costo, millas, capacidad; 

			Console.WriteLine("==========================");
			Console.WriteLine("$$ ALTA DE VUELOS $$");
			Console.WriteLine("==========================");

			Ciudades();
			// Validar que existan en el arreglo de objetos
			int posicion;

			do {
				origen = ReadHelperLibrary.Class1.ReadString("Origen: ");
				posicion = CityPosition(origen);

				if (posicion == -1) 
					Console.WriteLine("\nNo existe esa ciudad. Ingrese otra. \n");
				
			} while (posicion == -1);

			do {
				destino = ReadHelperLibrary.Class1.ReadString("Destino: ");
				posicion = CityPosition(destino);

				if (posicion == -1)
					Console.WriteLine("\nNo existe esa ciudad. Ingrese otra. \n");

				if (destino == origen) {
					Console.WriteLine("\nLa ciudad de destino no puede ser igual a la de origen. Ingrese otra. \n");
					posicion = -1;
				}

			} while (posicion == -1);

			numPasajeros = ReadHelperLibrary.Class1.ReadInt("Número de pasajeros disponibles en ese vuelo: ");
			capacidad = ReadHelperLibrary.Class1.ReadDouble("Capacidad del avión: ");
			costo = ReadHelperLibrary.Class1.ReadDouble("Costo: ");
			millas = ReadHelperLibrary.Class1.ReadDouble("Millas: ");

			do {
				Console.WriteLine("\nDías en que se realiza el vuelo: ");
				Console.WriteLine("1.- Diaria\n2.- Lunes\n3.- Martes\n4.- Miércoles\n5.- Jueves\n6.- Viernes\n7.- Sábado" +
							  "\n8.- Domingo");
				int opc = ReadHelperLibrary.Class1.ReadInt("\nOpción: ");
				dias = DiaVuelo(opc);
			} while (dias == "");

			newVuelo = new Vuelo(arrayVuelos.Count+1,numPasajeros,origen, destino, dias, capacidad, 0, costo, millas);
			arrayVuelos.Add(newVuelo);
			Console.WriteLine("\n>> VUELO AÑADIDO CON ÉXITO <<\n");
			ConfirmarSalida();
		}

		private void AltaCiudades () {
			if (Contador == 10) {
				Console.WriteLine("\n>> YA SE HAN REGISTRADO LAS 100 CIUDADES <<\n");
				ConfirmarSalida();
				return;
			}

			string clave = ReadHelperLibrary.Class1.ReadString("Introduzca clave de la ciudad: ");

			if (ValidarClave(clave)) {
				Console.WriteLine("\n>> YA EXISTE ESA UNA CIUDAD CON ESA CLAVE <<\n");
				ConfirmarSalida();
				return;
			}

			string nombre = ReadHelperLibrary.Class1.ReadString("Introduzca nombre de la ciudad: ");
			string estado = ReadHelperLibrary.Class1.ReadString("Introduzca estado de la ciudad: ");
			Ciudad City = new Ciudad(clave, nombre, estado);
			Console.WriteLine("\n>> CIUDAD GUARDADA <<\n");
			Arreglo[Contador] = City;
			Contador++;
			ConfirmarSalida();
		}	

		private void CompraBoletos() {

			if (arrayVuelos.Count == 0 || !vuelosDisponibles()) {
				Console.WriteLine("\n>> NO HAY VUELOS DISPONIBLES <<\n");
				ConfirmarSalida();
				return;
			}

			int claveVuelo, claveClub;
			string claveBoleto, nomPasajero;
			int edad, opc;

			do {
				claveBoleto = RandomKey(15).Trim().ToUpper();
			} while (existeBoleto(claveBoleto));
							
			Vuelos();
			
			claveVuelo = ReadHelperLibrary.Class1.ReadInt("Clave del vuelo: ");

			if (existeVuelo(claveVuelo) == null) {
				Console.WriteLine("Ese vuelo no está disponible.");
			} else {
				
				opc = ReadHelperLibrary.Class1.ReadIntRango("¿Club premier? 1.- Si , 2.- No : ", 1,2);
		
				if (opc == 1) {

					if (hashClub.Count == 0) {
						Console.WriteLine("\n>> Primero debe registrarse en club premier <<\n");
						ConfirmarSalida();
						return;
					}

			
					do {
						ClubPremier();
						claveClub = ReadHelperLibrary.Class1.ReadInt("Clave del club premier: ");
					} while (!hashClub.ContainsKey(claveClub));
					nomPasajero = ((ClubPremier)hashClub[claveClub]).Nombre;
					edad = ReadHelperLibrary.Class1.ReadInt("Edad del pasajero: ");

					newBoleto = new Boleto(claveBoleto, nomPasajero, edad, claveVuelo);
					newBoleto.ClaveClubPremier = claveClub;

					existePremier(claveClub).Millas = existeVuelo(claveVuelo).pMillas;
					existeVuelo(claveVuelo).pBoletosVendidos = 1;

					boletosVendidos.Add(newBoleto);
					Console.WriteLine("Boleto vendido.");
				} else {
					nomPasajero = ReadHelperLibrary.Class1.ReadString("Nombre Pasajero: ");
					edad = ReadHelperLibrary.Class1.ReadIntRango("Edad del pasajero: ",1,105);
					newBoleto = new Boleto(claveBoleto, nomPasajero, edad, claveVuelo);
					boletosVendidos.Add(newBoleto);
					existeVuelo(claveVuelo).pBoletosVendidos = 1;
					Console.WriteLine("\n>> BOLETO VENDIDO <<\n");
				}
			}
			ConfirmarSalida();
		}

		// MÉTODOS DE IMPRESIONES
		private void Ciudades () {
			if (Contador == 0) 
				Console.WriteLine("No se han ingresado ciudades.");
			else {
				var table = new ConsoleTable("Ciudad", "Estado", "Clave");
				for (int i = 0; i < Contador; i++) {
					table.AddRow(Arreglo[i].pNombre, Arreglo[i].pEstado, Arreglo[i].pClave);
				}
				table.Write(Format.Alternative);
				Console.WriteLine();
			}

			ConfirmarSalida();
		}

		private void ClubPremier () {
			if (hashClub.Count == 0)
				Console.WriteLine("\n>> AÚN NO HAY CLIENTES PERTENECIENTES A CLUB PREMIER << \n");
			else {
				var table = new ConsoleTable("ID", "NOMBRE", "DOMICILIO", "MILLAS");
				foreach (DictionaryEntry val in hashClub) {
					newCliente = (ClubPremier)val.Value;
					table.AddRow(val.Key, newCliente.Nombre, newCliente.Domicilio, newCliente.Millas);
				}
				table.Write(Format.Alternative);
				Console.WriteLine();
			}

			ConfirmarSalida();
		}

		private void Vuelos () {
			if (arrayVuelos.Count == 0)
				Console.WriteLine("\n>> No hay vuelos registrados << \n");
			else {
				var table = new ConsoleTable("CVE", "ORIGEN", "DESTINO", "# PASAJEROS", "BOLETOS VENDIDOS", "CAPACIDAD", "MILLAS", "DÍAS", "$");
				int contVuelos = 0;
				foreach (Vuelo val in arrayVuelos)
					if (val.pBoletosVendidos < val.pNumPasajeros) {
						table.AddRow(val.pClaveVuelo, val.pOrigen, val.pDestino, val.pNumPasajeros, val.pBoletosVendidos, val.pCapacidad, val.pMillas, val.pDias, val.pCosto);
						contVuelos++;
					}

				if (contVuelos == 0)
					Console.WriteLine("\n>> No hay vuelos disponibles << \n");
				else
					table.Write(Format.Alternative);
				
				Console.WriteLine();
			}

			ConfirmarSalida();
		}

		private void BoletosVendidos () {
			if (boletosVendidos.Count == 0)
				Console.WriteLine("\n>> No hay boletos vendidos << \n");
			else {
				var table = new ConsoleTable("CLAVE", "NOMBRE", "EDAD", "CLAVE VUELO", "CLUBPREMIER");
				string cve="--";
				foreach (Boleto val in boletosVendidos) {
					if (val.ClaveClubPremier != 0)
						cve = Convert.ToString(val.ClaveClubPremier);
					table.AddRow(val.ClaveBoleto, val.Nompasajero, val.EdadPasajero, val.ClaveVuelo, cve);
				}
				table.Write(Format.Alternative);
				Console.WriteLine();
			}
			ConfirmarSalida();
		}

		// VALIDACIONES - EXISTENCIAS
		private Vuelo existeVuelo (int clave) {
			foreach (Vuelo val in arrayVuelos)
				if ((val.pClaveVuelo == clave) && (val.pBoletosVendidos < val.pNumPasajeros))
					return val;

			return null;
		}

		private ClubPremier existePremier (int key) {
			foreach (DictionaryEntry entry in hashClub) 
				if (entry.Key.Equals(key))
					return (ClubPremier)entry.Value;
			
			return null;
		}

		private bool ValidarClave (string cve) {
			for (int i = 0; i < Contador; i++) {
				Ciudad c = Arreglo[i];
				if (c.pClave.CompareTo(cve) == 0)
					return true;
			}

			return false;
		}

		public bool ValidarNombre (string n) {
			foreach (DictionaryEntry entry in hashClub) {
				ClubPremier c = (ClubPremier)entry.Value;
				if (c.Nombre.CompareTo(n) == 0)
					return true;
			}

			return false;
		}

		private Ciudad CityObject () {
			Ciudad ciudad = null;
			if (Contador == 0)
				Console.WriteLine("\nNo se han agregado ciudades.\n");
			else {
				string Nombre = ReadHelperLibrary.Class1.ReadString("Introduzca nombre de la ciudad: ");
				for (int i = 0; i < Contador; i++) 
					if (Arreglo[i].pNombre.CompareTo(Nombre) == 0) {
						ciudad = Arreglo[i];
						break;
					}
			}
			return ciudad;
		}

		private int CityPosition (string Nombre) {
			int Position = -1;

			for (int i = 0; i < Contador; i++) 
				if (Arreglo[i].pNombre.CompareTo(Nombre) == 0) {
					Position = i;
					break;
				}
			
			return Position;
		}

		private bool existeBoleto (string claveBoleto) {
			foreach (Boleto val in boletosVendidos)
				if (val.ClaveBoleto.Equals(claveBoleto))
					return true;

			return false;
		}

		private bool vuelosDisponibles () {
			foreach (Vuelo val in arrayVuelos)
				if ((val.pBoletosVendidos < val.pNumPasajeros))
					return true;

			return false;
		}

		// MÉTODOS AUXILIARES
		private string DiaVuelo (int dia) {
			switch (dia) {
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


		public string RandomKey (int length) {
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}

		private int Salir () {
			int opc;
			Console.WriteLine("==========================");
			Console.WriteLine("Estás saliendo del sistema");
			Console.WriteLine("==========================");
			Console.WriteLine("  ¡Los datos se perderan!");
			Console.WriteLine("1.- Para salir.");
			Console.WriteLine("2.- Para volver.");
			opc = ReadHelperLibrary.Class1.ReadInt("=> ");
			switch (opc) {
				case 1:
					Console.Clear();
					return 8;

				case 2:
					return 0;

			}
			Console.Clear();
			return 0;
		}

		private void ConfirmarSalida () {
			Console.WriteLine("\n\t\t\t─────────────────────────────");
			Console.WriteLine("\t\t\tPresiona enter para continuar");
			Console.WriteLine("\t\t\t─────────────────────────────");
			Console.ReadLine();
		}

	}
}