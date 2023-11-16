using System;

namespace Beta_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Info de jugador 1
            string jugador1 = "iAmJP";
            string Equipo1 = "TeamQueso";

            //ingo de jugadro 2
            string jugador2 = "MohamedLight";
            string Equipo2 = "GoldenWing";

            //Iniciales
            string inicial1 = Equipo1.Substring(0, 2);
            string inicial2 = Equipo2.Substring(0, 2);

            //Nickname
            string nick1 = inicial1 + "-" + jugador1 + (jugador1.Length - 1).ToString() + jugador1.IndexOf(jugador1[0]).ToString();
            string nick2 = inicial2 + "-" + jugador2 + (jugador2.Length - 1).ToString() + jugador2.IndexOf(jugador2[0]).ToString();

            //Nombre
            Console.WriteLine("Jugador 1: " + nick1);
            Console.WriteLine("Jugador 2: " + nick2);
        }
    }
}
