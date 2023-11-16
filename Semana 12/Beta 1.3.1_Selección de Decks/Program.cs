using System;

namespace Beta_1._3._1_Selección_de_Decks
{
    public class Program
    {
        public static void Main()
        {
            Deck jugador1 = new Deck("iAmJP", "Team Queso");
            Deck jugador2 = new Deck("Mohamed Light", "Golden Wing");

            // Agregar las cartas al deck del jugador 1
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("DECK #" + i);
                for (int j = 1; j <= 8; j++)
                {
                    Console.WriteLine("Carta #" + j);
                    // Aquí debes agregar el código para ingresar los puntos de vida, elixir y daño de cada carta
                    jugador1.AddCard(0, 0, 0);  // Reemplaza los ceros con los valores ingresados
                }
                jugador1.ImprimirPuntosVida();
                jugador1.ImprimirPuntosDaño();
            }

            // Haz lo mismo para el jugador 2

            Console.WriteLine(jugador1);
            Console.WriteLine(jugador2);
        }
    }
}
