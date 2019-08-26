using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBesibol
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }
        public string Jugadores { get; set; }

        public List<Jugador> Jugadores1 { get; set; }

        public Equipo()
        {
            Nombre = "Sin nombre";
            Ciudad = "Sin ciudad";
            Entrenador = "Sin entrenador";
           Jugadores = "9";
        }

        public Equipo(string
            nombre)
        {
            Nombre = nombre;
            Ciudad = "Sin ciudad";
            Entrenador = "Sin entrenador";
            Jugadores = "9";
            Jugadores1 = new List<Jugador>();
            
        }

    }
}
