using System;
using System.Collections.Generic;
using System.Text;

namespace Beta_1._3._1_Selección_de_Decks
{
    public class Deck
    {
        public string Jugador { get; set; }
        public string Equipo { get; set; }
        public string Carta { get; set; }
        public string TipoCarta { get; set; }
        public int Elixir { get; set; }
        public int PuntosVida { get; set; }
        public int Daño { get; set; }
        public int TotalPuntosVida { get; set; }
        public int TotalPuntosDaño { get; set; }

        public Deck(string jugador, string equipo)
        {
            Jugador = jugador;
            Equipo = equipo;
            Elixir = 0;
            PuntosVida = 0;
            Daño = 0;
        }

        public void AddCard(int puntosVida, int elixir, int daño)
        {
            PuntosVida = puntosVida;
            Elixir = elixir;
            Daño = daño;
            TotalPuntosVida += puntosVida;
            TotalPuntosDaño += daño;
        }

        public void ImprimirPuntosVida()
        {
            Console.WriteLine("Promedio de puntos de vida: " + TotalPuntosVida / 8);
        }

        public void ImprimirPuntosDaño()
        {
            Console.WriteLine("Promedio de puntos de daño: " + TotalPuntosDaño / 8);
        }

        public override string ToString()
        {
            return "El jugador: " + Jugador + " jugara en la CRL con un deck que contiene un total de " + TotalPuntosDaño + " puntos de daño.";
        }
    }
}
