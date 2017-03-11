using System;
using System.Collections;

namespace Scripts {
	class MainClass {

		ArrayList nameArray = new ArrayList();
		ArrayList ciudadArray = new ArrayList();
		ArrayList premierArray = new ArrayList();
		ArrayList domicilioArray = new ArrayList();
		ArrayList vueloArray = new ArrayList();
		ArrayList clienteArray = new ArrayList();
		ArrayList boletoArray = new ArrayList();
		string[] clave = new string[32];
		string script= "USE reservación_vuelos;\nGO\n";

		public static void Main (string[] args) {

			MainClass clase = new MainClass();
			clase.GenerarCiudadEstado();
			clase.GenerarClientes();	
			clase.GenerarDomicilio();
			clase.GenerarScriptClubpremier();
			clase.GenerarClienteGenerico();
			clase.GenerarVuelo();
			clase.GenerarBoleto();
			clase.GenerarScript();
		
		}

		public void GenerarClienteGenerico() {
			int cliente;
			for (int i = 0; i < nameArray.Count-premierArray.Count; i++) {
				Random r1 = new Random();
				do {
					cliente = r1.Next(0, 120);
				} while (ValidarRepetido(cliente, premierArray) || ValidarRepetido(cliente, clienteArray) );
				clienteArray.Add(cliente);
				script += string.Format("\nINSERT INTO clienteGenérico(cveCliente)\n   VALUES({0})\n",
										cliente);
				
			}

		}

		public void GenerarBoleto () {
			int ra1, ra2;
			for (int i = 0; i < 90; i++) {
				Random r1 = new Random();
				do {
					ra1 = r1.Next(1, 99);
					ra2 = r1.Next(1, 119);
				} while (ValidarRepetido(ra1, boletoArray));
				boletoArray.Add(ra1);
				script += string.Format("\nINSERT INTO boleto(cveVuelo, cveCliente)\n   VALUES({0},{1})\n", 
				                       ra1, ra2);
			}

		}


		public void GenerarVuelo () {

			int ra1, ra2;
	
			string vuelo="";
			for (int i = 0; i < 100; i++) {
				do {
					Random r1 = new Random();
					ra1 = r1.Next(0, 31);
					ra2 = r1.Next(0, 31);
			
					string cadena1 = r1.Next(200, 4500).ToString() + "." + r1.Next(40, 100).ToString();
					string cadena2 = r1.Next(10, 4500).ToString() + "." + r1.Next(0, 100).ToString();
					vuelo = string.Format("{0},'{1}','{2}',{3},{4},{5}", r1.Next(10, 50), clave[ra1], clave[ra2],
					                      r1.Next(10,50), Convert.ToDouble(cadena1),Convert.ToDouble(cadena2));
				} while (ValidarRepetido(vuelo, vueloArray) || ra1==ra2);
				vueloArray.Add(vuelo);
				Console.WriteLine(vuelo);
			}

			GenerarScriptVuelo();
		}

		public void GenerarScriptVuelo () {

			foreach (string v in vueloArray)
				script += string.Format("\nINSERT INTO vuelo(numPasajeros, origen, destino, capacidad, costo, millas)\n   VALUES({0})\n", v);

			//Console.WriteLine(script);
		}

		public void GenerarClientes () {
			string[] firstName =  { "Karen", "Daniel", "Jesús", "Pedro", "Roberto", "Fernando", "Eduardo",
			"Diego", "René", "Melisse", "Emma", "Luis", "Víctor" };

			string[] lastName = {"Medina", "Herondale", "Ortíz", "González", "Pulido", "Bajo", "Vidriales", "Gálvez", "Apodaca",
			"Preciado", "Gallardo"};


			int ra1, ra2;
			string name;
			for (int i = 0; i < 120; i++) {
				do {
					Random r1 = new Random();
					ra1 = r1.Next(0, 11);
					ra2 = r1.Next(0, 11);
					name = string.Format("{0} {1}",firstName[ra1], lastName[ra2]);
				} while (ValidarRepetido(name, nameArray));
				nameArray.Add(name);
				Console.WriteLine(name);
			}

			GeneraScriptClientes();
		}

		public void GenerarDomicilio () {
			string[] calle =  { "Río Aguanaval", "Tierra", "Av. Guadalupe Victoria", "Río Lerma", "Río Acaponeta",
				"Juan de Dios Bátiz", "Río Suchiate"};

			string[] colonia = {"Los Pinos", "Guadalupe","Infonavit Humaya", "Las Quintas", "Popular", "Industrial Bravo",
				"Nuevo Culiacán"};


			int ra1, ra2, ra3;
			string domicilio = "";
			for (int i = 0; i < 50; i++) {
				do {
					Random r1 = new Random();
					ra1 = r1.Next(0, 7);
					ra2 = r1.Next(0, 7);
					ra3 = r1.Next(100, 5000);
					domicilio = string.Format("{0}, {1} #{2}", calle[ra1], colonia[ra2], ra3);
				} while (ValidarRepetido(domicilio, domicilioArray));
				domicilioArray.Add(domicilio);
				Console.WriteLine(domicilio);
			}

			Console.WriteLine(domicilio);
		}


		public void GenerarCiudadEstado () {
			string[] ciudad =  {"Aguascalientes","Mexicali","La Paz",
				"Campeche","Saltillo","Colima","Tuxtla Gutiérrez","Chihuahua",
				"Ciudad de México","Durango","Guanajuato","Chilpancingo",
				"Pachuca","Guadalajara","Toluca","Morelia","Cuernavaca",
				"Tepic","Monterrey","Oaxaca","Puebla","Querétaro",
				"Chetumal","San Luis Potosí","Culiacán","Hermosillo",
				"Villahermosa","Ciudad Victoria","Tlaxcala","Xalapa" ,
				"Mérida","Zacatecas"};

			string[] estado = {"Aguascalientes","Baja California", "Baja California Sur", "Campeche", "Coahuila", "Colima", "Chiapas",
				"Chihuahua", "Distrito Federal", "Durango", "Guanajuato","Guerrero","Hidalgo","Jalisco","México","Michoacán", "Morelos",
				"Narayit","Nuevo León","Oaxaca", "Puebla","Querétaro","Quintana Roo","San Luis Potosí","Sinaloa","Sonora",
				"Tabasco","Tamaulipas","Tlaxcala","Veracruz","Yucatán","Zacatecas"};


			string text;
			for (int i = 0; i < ciudad.Length; i++) {
				clave[i] = string.Format("{0}{1}{2}", ciudad[i][0], ciudad[i].ToUpper()[1], ciudad[i].ToUpper()[4]);
				text = string.Format("'{0}','{1}','{2}'", clave[i],ciudad[i], estado[i]);
				ciudadArray.Add(text);
				Console.WriteLine(text);
			}

			GeneraScriptCiudades();
		}

		public void GeneraScriptCiudades () {
	
			foreach (string c in ciudadArray)
				script += string.Format("\nINSERT INTO ciudad(cveCiudad, nombreCiudad, estado)\n   VALUES({0})\n", c);

			//Console.WriteLine(text);

			//System.IO.File.WriteAllText(@"POBLACIÓN2.sql", text);
		}


		public void GeneraScriptClientes () {
			Random r1 = new Random();
			foreach (string n in nameArray)
				script += string.Format("\nINSERT INTO cliente(nombre, edad)\n   VALUES('{0}', {1})\n", n, r1.Next(5, 90));

			//Console.WriteLine(script);

			//System.IO.File.WriteAllText(@"POBLACIÓN.sql", text);

		}

		public void GenerarScriptClubpremier () {

			Random r1 = new Random();
			int r;
			for (int i = 0; i < 50; i++) {
				do {
					r = r1.Next(0, 110);
				} while (ValidarRepetido(r, premierArray));
				premierArray.Add(r);
				script += string.Format("\nINSERT INTO club_premier(cveCliente, domicilio)\n   VALUES({0}, '{1}')\n", r, domicilioArray[i]);
			}

			//Console.WriteLine(script);

		}

		public bool ValidarRepetido (string text, ArrayList array) {
			foreach (string n in array)
				if (n.CompareTo(text) == 0)
					return true;

			return false;
		}

		public bool ValidarRepetido (int number, ArrayList array) {
			foreach (int n in array)
				if (n == number)
					return true;

			return false;
		}

		public void GenerarScript () { 

			Console.WriteLine("\n{0}", script);
			System.IO.File.WriteAllText(@"POBLACIÓN.sql", script);
			Console.WriteLine("\n>> SCRIPT GENERADO CON ÉXITO <<");
		}
	}
}
