﻿using System;
using System.Collections;



namespace KatyProject {
	class MainClass {

		private ReadHelper read = new ReadHelper();
		private Hashtable hashClub = new Hashtable();
		private ArrayList arrayVuelos = new ArrayList();
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
					break;

					case 2:
						AltaVuelo();
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

			int numPasajeros, capacidad, boletosVendidos;
			string origen, destino, dias;
			double costo, millas; 

			Console.WriteLine("==========================");
			Console.WriteLine("$$ ALTA DE VUELOS $$");
			Console.WriteLine("==========================");

			Console.Write("Número de pasajeros: ");
			numPasajeros = read.ReadInt();

			// Validar que existan en el arreglo de objetos
			Console.Write("Origen: ");
			origen = read.ReadString().Trim().ToUpper();
			Console.Write("Destino: ");
			destino = read.ReadString().Trim().ToUpper();

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

			Vuelo vuelo = new Vuelo(origen, destino, dias, numPasajeros, capacidad, boletosVendidos, costo, millas);
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

	}
}