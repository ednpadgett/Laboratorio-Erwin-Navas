using Beta_1._4;
using System;
using System.Collections.Generic;
using System.Linq;

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

            Deck deck1 = new Deck();
            Deck deck2 = new Deck();
            Deck deck3 = new Deck();
            Deck deck4 = new Deck();

            // Agregar las cartas a los decks
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine($"DECK #{i}");
                Console.Write("Ingrese el nombre de la carta: ");
                string name = Console.ReadLine();
                Console.Write("Ingrese el elixir de la carta: ");
                int elixir = int.Parse(Console.ReadLine());
                Console.Write("Ingrese los puntos de vida de la carta: ");
                int lifePoints = int.Parse(Console.ReadLine());
                Console.Write("Ingrese los puntos de ataque de la carta: ");
                int attackPoints = int.Parse(Console.ReadLine());

                Card card = new Card(name, elixir, lifePoints, attackPoints);
                deck1.AddCard(card);
                deck2.AddCard(card);
                deck3.AddCard(card);
                deck4.AddCard(card);
            }
            // Jugador 1 escoge el deck con mayor vida
            Deck deckJugador1 = deck1.TotalLifePoints() > deck2.TotalLifePoints() ? deck1 : deck2;
        }
    }
    
    
}