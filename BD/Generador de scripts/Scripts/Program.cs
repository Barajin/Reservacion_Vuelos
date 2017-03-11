using System;
using System.Collections;

namespace Scripts {
	class MainClass {

		ArrayList nameArray = new ArrayList();
		ArrayList ciudadArray = new ArrayList();
		ArrayList premierArray = new ArrayList();
		ArrayList domicilioArray = new ArrayList();
		string script= "USE reservación_vuelos;\nGO\n";

		public static void Main (string[] args) {

			MainClass clase = new MainClass();
			clase.GenerarCiudadEstado();
			clase.GenerarClientes();	
			clase.GenerarDomicilio();
			clase.GenerarScriptClubpremier();
		
		
		}

		public void GenerarClientes () {
			string[] firstName =  { "Karen", "Daniel", "Jesús", "Pedro", "Roberto", "Fernando", "Eduardo",
			"Diego", "René", "Melisse", "Emma", "Luis", "Víctor" };

			string[] lastName = {"Medina", "Herondale", "Ortíz", "González", "Pulido", "Bajo", "Vidriales", "Gálvez", "Apodaca",
			"Preciado", "Gallardo"};


			int ra1, ra2;
			string name;
			for (int i = 0; i < 10; i++) {
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
			string[] ciudad =  {"'Aguascalientes','Aguascalientes'","'Mexicali','Baja California'","'La Paz','Baja California Sur'",
				"'Campeche', 'Campeche'","'Saltillo','Coahuila'","'Colima', 'Colima'","'Tuxtla Gutiérrez','Chiapas'","'Chihuahua', 'Chihuahua'",
				"'Ciudad de México','Distrito Federal'","'Durango', 'Durango'","'Guanajuato', 'Guanajuato'","'Chilpancingo','Guerrero'",
				"'Pachuca','Hidalgo'","'Guadalajara','Jalisco'","'Toluca','México '","'Morelia','Michoacán'","'Cuernavaca','Morelos'",
				"'Tepic','Nayarit'","'Monterrey','Nuevo León'","'Oaxaca', 'Oaxaca'","'Puebla', 'Puebla'","'Querétaro', 'Querétaro'",
				"'Chetumal','Quintana Roo'","'San Luis Potosí', 'San Luis Potosí'","'Culiacán','Sinaloa'","'Hermosillo','Sonora '",
				"'Villahermosa','Tabasco'","'Ciudad Victoria','Tamaulipas'","'Tlaxcala', 'Tlaxcala'","'Xalapa','Veracruz'" ,
				"'Mérida','Yucatán'" ,"'Zacatecas', 'Zacatecas'" };


			string text;
			string clave;
			for (int i = 0; i < ciudad.Length; i++) {
				clave = string.Format("{0}{1}{2}", ciudad[i][1], ciudad[i].ToUpper()[2], ciudad[i].ToUpper()[5]);
				text = string.Format("'{0}',{1}", clave,ciudad[i]);
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

			Console.WriteLine(script);

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
	}
}
