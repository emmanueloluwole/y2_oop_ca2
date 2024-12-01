//Emmanuel Oluwole
// S00248432
//Ca2
//BlackJack project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2BlackJack
{
    internal class ClubCard
    {
        //create list needed f0r the game
        public List<int> values = new List<int>() { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        public List<string> faces = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        public List<string> suits = new List<string>() { "Hearts", "Spades", "Clubs", "Diamonds" };

        //public properties 
        public string Suit { get; set; }

        public string Face { get; set; }

        public int Value { get; set; }

        //public constructor 
        public ClubCard(Random rng)
        {
            
            //random number between 0-12
            int num1=rng.Next(0,13);

            //random number between 0-3
            int num2=rng.Next(0,4);

            //linking the private prop list and public propertist
            Face=faces[num1];
            Suit=suits[num2];
            Value=values[num1];
        }

    }
}
