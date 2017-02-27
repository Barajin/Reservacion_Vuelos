using System;
namespace KatyProject {
	public class ReadHelper {
		public int ReadInt () {
			int num = 0;
			bool helper;
			do {
				try {
					num = int.Parse(Console.ReadLine());
					if (num <= 0) {
						Console.Write("El dato no puede ser menor o igual cero, teclea de nuevo: ");
					}
					helper = true;
				} catch (FormatException) {
					helper = false;
					Console.Write("Error al castear números, teclea de nuevo: ");
				} catch (OverflowException) {
					helper = false;
					Console.Write("El número es demasiado grande, teclea de nuevo: ");
				}

			}
			while (num <= 0 || !helper);

			return num;
		}

		public double ReadDouble () {
			double num = 0;
			bool helper;
			do {
				try {
					num = double.Parse(Console.ReadLine());
					if (num <= 0) {
						Console.Write("El dato no puede ser menor o igual a cero , teclea de nuevo: ");
					}
					helper = true;
				} catch (FormatException) {
					helper = false;
					Console.Write("Error al castear números, teclea de nuevo: ");
				} catch (OverflowException) {
					helper = false;
					Console.Write("El número es demasiado grande, teclea de nuevo: ");
				}

			}
			while (num <= 0 || !helper);

			return num;
		}

		public string ReadString () {

			string dato;
			do {
				dato = Console.ReadLine();
				if (dato.Trim().Equals("")) {
					Console.Write("\nNo se permiten cadenas vacías, teclee de nuevo: ");
				}
			} while (dato.Trim().Equals(""));

			return dato.Trim();
		}
	}
}
