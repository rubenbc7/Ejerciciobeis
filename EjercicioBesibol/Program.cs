using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBesibol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo Dodgers = new Equipo("Dodgers");
            Equipo Rangers = new Equipo("Rangers");
            equipos.Add(Dodgers);
            equipos.Add(Rangers);

            Jugador adrian = new Jugador("adrian");
            Jugador coby = new Jugador("coby");
            Jugador jesus = new Jugador("jesus");
            Jugador jose = new Jugador("jose");
            Jugador pedro = new Jugador("pedro");
            Jugador garcia = new Jugador("garcia");
            Jugador alex = new Jugador("alex");
            Jugador ruben = new Jugador("ruben");
            Jugador mora = new Jugador("mora");



            Jugador ana = new Jugador("ana");
            Jugador fede = new Jugador("fede");
            Jugador gabo = new Jugador("gabo");
            Jugador luis = new Jugador("luis");
            Jugador zeus = new Jugador("zeus");
            Jugador negro = new Jugador("negro");
            Jugador blanca = new Jugador("blanca");
            Jugador paula = new Jugador("paula");
            Jugador naruto = new Jugador("naruto");

            Dodgers.Jugadores1.Add(adrian);
            Dodgers.Jugadores1.Add(coby);
            Dodgers.Jugadores1.Add(jesus);
            Dodgers.Jugadores1.Add(jose);
            Dodgers.Jugadores1.Add(pedro);
            Dodgers.Jugadores1.Add(garcia);
            Dodgers.Jugadores1.Add(alex);
            Dodgers.Jugadores1.Add(ruben);
            Dodgers.Jugadores1.Add(mora);

            Rangers.Jugadores1.Add(ana);
            Rangers.Jugadores1.Add(fede);
            Rangers.Jugadores1.Add(gabo);
            Rangers.Jugadores1.Add(luis);
            Rangers.Jugadores1.Add(zeus);
            Rangers.Jugadores1.Add(negro);
            Rangers.Jugadores1.Add(blanca
                );
            Rangers.Jugadores1.Add(paula);
            Rangers.Jugadores1.Add(naruto);





            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("Nombre: " + equipo.Nombre);
                Console.WriteLine("Ciudad: " + equipo.Ciudad);
                Console.WriteLine("Entrenador: " + equipo.Entrenador);
                Console.WriteLine("Jugadores: " + equipo.Jugadores);
                Console.WriteLine(" ");
                Console.WriteLine("Lista de jugadores: ");
                foreach (Jugador jugador in equipo.Jugadores1)
                {
                    Console.WriteLine("° " + jugador.Nombre);
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();

        }
    }
}
