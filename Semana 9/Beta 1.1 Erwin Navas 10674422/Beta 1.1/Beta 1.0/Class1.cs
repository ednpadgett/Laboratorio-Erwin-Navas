using System;
using System.Collections.Generic;
using System.Text;

namespace Beta_1._0
{
    public class Card
    {
        public string Name { get; set; }
        public int Elixir { get; set; }
        public int LifePoints { get; set; }
        public int Damage { get; set; }

        public Card(string name, int elixir, int lifePoints, int damage)
        {
            Name = name;
            Elixir = elixir;
            LifePoints = lifePoints;
            Damage = damage;
        }
    }

    public class Deck
    {
        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        public List<Card> Cards { get; set; }

        public Deck(string playerName, string teamName)
        {
            PlayerName = playerName;
            TeamName = teamName;
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public int TotalLifePoints()
        {
            int total = 0;
            foreach (var card in Cards)
            {
                total += card.LifePoints;
            }
            return total;
        }

        public int TotalDamage()
        {
            int total = 0;
            foreach (var card in Cards)
            {
                total += card.Damage;
            }
            return total;
        }

        public override string ToString()
        {
            return $"El jugador: {PlayerName} jugara en la CRL con un deck que contiene un total de {TotalDamage()} puntos de daño y {TotalLifePoints()} puntos de vida.";
        }
    }
}
