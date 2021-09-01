using System;
using Jugadores;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
           Jugador jug1 = new Jugador("Pepe", 30, true); 
           Jugador jug2 = new Jugador("Juan", 20);
           Jugador jug3 = new Jugador("Dante", 15, true);

           Console.WriteLine(jug2.IsActivo());
        }
    }
}
