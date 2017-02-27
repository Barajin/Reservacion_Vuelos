using System;
using System.Collections;

namespace KatyProject {
	class MainClass {

		private ReadHelper read = new ReadHelper();
		private Hashtable hashClub = new Hashtable();
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

					case 0: /* No es necesario poner nada aqui solo se usa para el soporte de la salida */break;

					case 1:
					break;

					case 2:
					break;

					case 3:
					AltaClubPremier();
					break;

					case 4:
					break;

					case 5:
					break;

					case 6:
					opc = Salir();
					break;

					default:
					Console.WriteLine("================================");
					Console.WriteLine("Esa no fue una opción valida. :C");
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

			Console.Write("Clave del usuario:");
			claveClub = read.ReadString();
			if (hashClub.ContainsKey(claveClub.ToUpper().Trim())) {
				Console.WriteLine("Esa clave ya existe.");
			} else { 
				Console.Write("Nombre del cliente:");
				nombre = read.ReadString();
				Console.Write("Domicilio:");
				domicilio = read.ReadString();
				newCliente = new ClubPremier(NString(claveClub), NString(nombre), NString(domicilio), millas);
				hashClub.Add(NString(claveClub), newCliente);
				Console.WriteLine("Cliente añadido al club exitosamente.");
			}
		}

		//String chido para guardarse :) y leer de manera correcta.
		private string NString(string str) {
			return str.ToUpper().Trim();
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
	}
}