using System;

namespace Beta_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Info de jugador 1
            string jugador1 = "iAmJP";
            string Equipo1 = "Team Queso";

            //ingo de jugadro 2
            string jugador2 = "MohamedLight";
            string Equipo2 = "Golden Wing";

            //Iniciales
            string inicial1 = Equipo1.Substring(0, 1);
            string inicial2 = Equipo1.Substring(Equipo1.IndexOf(' ') + 1, 1);
            string inicial12 = Equipo2.Substring(0, 1);
            string inicial22 = Equipo2.Substring(Equipo2.IndexOf(' ') + 1, 1);

            //Nickname
            string nick1 = inicial1 + inicial2 + "-" + jugador1 + (jugador1.Length - 1).ToString() + jugador1.IndexOf(jugador1[0]).ToString();
            string nick2 = inicial12 + inicial22 + "-" + jugador2 + (jugador2.Length - 1).ToString() + jugador2.IndexOf(jugador2[0]).ToString();

            //Nombre
            Console.WriteLine("Jugador 1: " + nick1);
            Console.WriteLine("Jugador 2: " + nick2);
        }
    }
}
