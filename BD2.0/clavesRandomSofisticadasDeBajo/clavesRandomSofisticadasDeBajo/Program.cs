using System;
using System.Collections;
using System.Linq;


namespace clavesRandomSofisticadasDeBajo {
	class Program {

		 ArrayList arrayBoletos = new ArrayList();
		 Random random = new Random();
		 string claveBoleto;
		 string script = "USE reservación_vuelos;\nGO\n";

		static void Main(string[] args) {

			Program p = new Program();
			for (byte i = 1; i < 91; i++) {
				do {
					p.claveBoleto = p.RandomKey(15).Trim().ToUpper();
				} while (p.existeBoleto(p.claveBoleto));

				p.arrayBoletos.Add(p.claveBoleto);
				p.script += string.Format("\nUPDATE boleto SET claveBoleto = '{0}' \n  WHERE claveBoleto = '{1}'\n",
										p.claveBoleto,i);
			}

			Console.WriteLine(p.script);
			Console.WriteLine("\n{0}",p.script);
			System.IO.File.WriteAllText(@"UPDATECVEBOLETOS.sql",p.script);
			Console.WriteLine("\n>> SCRIPT GENERADO CON ÉXITO <<");
			Console.ReadLine();

		}

		private bool existeBoleto(string claveBoleto) {
			foreach (string val in arrayBoletos)
				if (val.Equals(claveBoleto))
					return true;

			return false;
		}

		private string RandomKey(int length) {
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars,length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}

	}
}
