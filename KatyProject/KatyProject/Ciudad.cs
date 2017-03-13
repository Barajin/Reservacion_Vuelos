using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservación_Vuelos {
    class Ciudad {
        string Clave;
        string Nombre;
        string Estado;

        public Ciudad(string clave, string nombre, string estado) {
            Clave = clave;
            Nombre = nombre;
            Estado = estado;
        }

        public string pClave {
            get {
                return Clave;
            }

            set {
                Clave = value;
            }
        }

        public string pNombre {
            get {
                return Nombre;
            }

            set {
                Nombre = value;
            }
        }

        public string pEstado {
            get {
                return Estado;
            }

            set {
                Estado = value;
            }
        }
    }
}
