using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBesibol
{
    class Jugador
    {
       public string Nombre {get;set;}
        public string Numero { get; set; }

        public Jugador()
        {
            Nombre = "Sin nombre";
            Numero = "Sin numero";
        }

        public Jugador(string
            nombre)
        {
            Nombre = nombre;
            Numero = "sin numero";
        }


    }
}
