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
    internal class Program
    {
        static void Main(string[] args)
        {

            //generate ransdom
            Random rnd = new Random();

            //display game 
            Console.WriteLine($"WELCOME TO BLACKJACK!\n");

            string PlayAgain = "";

            //loop to keep the running 
            while (PlayAgain != "n")
            {
                bool playBurst = false;

                //create a list for all player cards
                List<ClubCard> allPlayerCards = new List<ClubCard>();

                //create  random objects for c1 
                ClubCard c1 = new ClubCard(rnd);
                //add objects to the list created for all player cards, and to the same for every random card created 
                allPlayerCards.Add(c1);
                //create  random objects for c1
                ClubCard c2 = new ClubCard(rnd);
                allPlayerCards.Add(c2);

                //add card value for first two cards objects created
                int totalPlayerCardValue = allPlayerCards[0].Value + allPlayerCards[1].Value;

                //display meesage
                Console.WriteLine($"Card dealt is the {c1.Face} of {c1.Suit}, value {c1.Value}");
                Console.WriteLine($"Card dealt is the {c2.Face} of {c2.Suit}, value {c2.Value}");
                Console.WriteLine($"Your score is {totalPlayerCardValue}");
                Console.WriteLine($"Do you want to stick or twist - s/t?");
                string playerChoice = Console.ReadLine();
                //convert to lowecasse 
                playerChoice = playerChoice.ToLower();

                //a runnning loop for if player twist and their totalcardvalue is <=21
                while (playerChoice == "t" && totalPlayerCardValue <= 21)
                {
                    //new random card
                    ClubCard c3 = new ClubCard(rnd);
                    //add to player list
                    allPlayerCards.Add(c3);
                    //adding the total card value to the card 3 value created 
                    totalPlayerCardValue += c3.Value;

                    Console.WriteLine($"Card dealt is the {c3.Face} of {c3.Suit}, value {c3.Value}");
                    Console.WriteLine($"Your score is {totalPlayerCardValue}");

                    //if and else statement for when the new totalcard value if less than or equal to 21 and if its greater than 21
                    if (totalPlayerCardValue <= 21)
                    {
                        Console.WriteLine($"Do you want to stick or twist - s/t? ");
                        playerChoice = Console.ReadLine().ToLower();
                    }
                    else if(totalPlayerCardValue > 21)
                    {
                        Console.WriteLine("You lose");
                        //end the code if value is greater 21
                        playBurst = true;
                    }
                }

                //works if the player card doesnt burst
                if (!playBurst)
                {
                    //call dealercard method
                    DealerCard(totalPlayerCardValue); 
                }

                
                Console.WriteLine("Do you want to play again - y/n?");
                PlayAgain = Console.ReadLine().ToLower();
                //clears the screen for a new card game
                Console.Clear();
            }


        }
        static void DealerCard(int totalPlayerCardValue)
        {
            //generate ransdom
            Random rnd = new Random();
            //crete a list for the all dealer cards
            List<ClubCard> allDealerCards = new List<ClubCard>();
            //create random classs
            ClubCard c4 = new ClubCard(rnd);
            //add to all dealer cards list
            allDealerCards.Add(c4);

            ClubCard c5 = new ClubCard(rnd);
            allDealerCards.Add(c5);

            int totalDealerCardValue = allDealerCards[0].Value + allDealerCards[1].Value;

            Console.WriteLine($"Dealer Plays \n");
            Console.WriteLine($"Card dealt is the {c4.Face} of {c4.Suit}, value {c4.Value}");
            Console.WriteLine($"Card dealt is the {c5.Face} of {c5.Suit}, value {c5.Value}");
            Console.WriteLine($"Your score is {totalDealerCardValue}");

            // a loops if the totaldealer value is less than 17
            while (totalDealerCardValue < 17)
            {
                //it automatically genrate a random card 
                ClubCard c6 = new ClubCard(rnd);
                allDealerCards.Add(c6);
                //add totalDealercard to the new random dealer card value
                totalDealerCardValue += c6.Value;
                Console.WriteLine($"Card dealt is the {c6.Face} of {c6.Suit}, value {c6.Value}");
                Console.WriteLine($"Your score is {totalDealerCardValue}");


                //if and else statement for when the totalDealerCardValue is greater than 17
                if (totalDealerCardValue >= 17)
                {

                    //statement to compare the totalPlayerCardValue and Totaldealercardvalue 
                    if (totalPlayerCardValue > totalDealerCardValue)
                    {
                        //display
                        Console.WriteLine("Player wins");
                    }
                    else if (totalDealerCardValue > totalPlayerCardValue)
                        ////display
                        Console.WriteLine("Dealer wins");
                }

            }

        }

    }


}

