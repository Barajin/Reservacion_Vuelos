using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatyProject {
    class AltaCiudades {
        
        //FIXED CITIES ARRAY.
        private Ciudad[] Arreglo = new Ciudad[100];
        private ReadHelper RH = new ReadHelper();
        private int Contador = 0;

        //METHOD TO SAVE CITIES.
        public void Alta() {
            Console.Write("Introduzca clave de la ciudad: ");
            string clave = RH.ReadString();
            Console.Write("Introduzca nombre de la ciudad: ");
            string nombre = RH.ReadString();
            Console.Write("Introduzca estado de la ciudad: ");
            string estado = RH.ReadString();
            Console.WriteLine("Ciudad guardada.");
            Ciudad City = new Ciudad(clave, nombre, estado);
            Arreglo[Contador] = City;
            Contador++;
        }

        //METHOD TO PRINT CITIES.
        public void Ciudades() {
            if (Contador == 0) {
                Console.WriteLine("No se han ingresado ciudades.");
            } else {
                for(int i = 0; i < Contador; i++) {
                    Console.WriteLine("Ciudad: {0} | Estado: {1} | Clave: {2}", Arreglo[i].pNombre, Arreglo[i].pEstado, Arreglo[i].pClave);
                }
            }
        }

        //METHOD TO GET CITY OBJECT
        public Ciudad CityObject() {
            Ciudad ciudad = null;
            if (Contador == 0) {
                Console.WriteLine("No se han agregado ciudades.");
            } else {
                Console.Write("Introduzca nombre de la ciudad: ");
                string Nombre = RH.ReadString();
                for(int i = 0; i < Contador; i++) {
                    if (Arreglo[i].pNombre.CompareTo(Nombre) == 0) {
                        ciudad = Arreglo[i];
                        break;
                    }
                }
            }
            return ciudad;
        }

        //METHOD TO GET CITY POSITION IN ARRAY
        public int CityPosition() {
            int Position = -1;
            if (Contador == 0) {
                Console.WriteLine("No se han agregado ciudades.");
            } else {
                Console.WriteLine("Introduzca nombre de la ciudad: ");
                string Nombre = RH.ReadString();
                for(int i = 0; i < Contador; i++) {
                    if (Arreglo[i].pNombre.CompareTo(Nombre) == 0) {
                        Position = i;
                        break;
                    }
                }
            }
            return Position;
        }

    }
}
