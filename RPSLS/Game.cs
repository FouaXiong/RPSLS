using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player player1 = new Human("Tim");
        Player player2 = new ComputerAI(new Random());
            //Method to choose UserType/PlayerType.


        public Game()
        {
            GameSetup();
        }
        public void GameSetup()
        {
            //Ask a question.
            Console.WriteLine("What is your name?");
            //Store the answer.
            string name = Console.ReadLine();
            Console.WriteLine("Would you like to play against another player or an AI?");
            //Another player
            switch (Console.ReadLine())
            {
                case "Player":
                case "Another player":
                    player1 = new Human(name);
                    Console.WriteLine("What is player 2's name?");
                    player2 = new Human(Console.ReadLine());  //logic here!
                    break;
                case "AI":
                    player1 = new Human(name);
                    player2 = new ComputerAI(new Random());  //logic here!
                    break;
                default:
                    break;
                    //Use the answer.
            }

        }
        public void RunGame()
        {
            //Will need a while loop in this method.
            player1.ChooseGesture();
            player2.ChooseGesture();
        }
        public void CompareGesture()
        {
            //Player 1 and 2 chose their gesture and will need to compare each gestures.
            //IF STATEMENT to compare what player 1 chose vs what Player 2 chose. 

            if (string.Compare(player1.gesture, "rock") == 1 && string.Compare(player2.gesture, "scissor") == 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            if (string.Compare(player1.gesture, "rock") == 1 && string.Compare(player2.gesture, "lizard") == 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            if (string.Compare(player1.gesture, "paper") == 1 && string.Compare(player2.gesture, "rock") == 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            if (string.Compare(player1.gesture, "paper") == 1 && string.Compare(player2.gesture, "spock") == 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            if (string.Compare(player1.gesture, "scissor") == 1 && string.Compare(player2.gesture, "paper") == 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            if (string.Compare(player1.gesture, "scissor") == 1 && string.Compare(player2.gesture, "lizard") == 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            if (string.Compare(player1.gesture, "lizard") == 1 && string.Compare(player2.gesture, "spock") == 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            if (string.Compare(player1.gesture, "lizard") == 1 && string.Compare(player2.gesture, "paper") == 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            if (string.Compare(player1.gesture, "spock") == 1 && string.Compare(player2.gesture, "rock") == 1)
            {
                Console.WriteLine("Player 1 wins!");
            }
            if (string.Compare(player1.gesture, "spock") == 1 && string.Compare(player2.gesture, "scissor") == 1)
            {
                Console.WriteLine("Player 1 wins!");
            }

            if (string.Compare(player2.gesture, "rock") == 1 && string.Compare(player1.gesture, "scissor") == 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            if (string.Compare(player2.gesture, "rock") == 1 && string.Compare(player1.gesture, "lizard") == 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            if (string.Compare(player2.gesture, "paper") == 1 && string.Compare(player1.gesture, "rock") == 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            if (string.Compare(player2.gesture, "paper") == 1 && string.Compare(player1.gesture, "spock") == 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            if (string.Compare(player2.gesture, "scissor") == 1 && string.Compare(player1.gesture, "paper") == 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            if (string.Compare(player2.gesture, "scissor") == 1 && string.Compare(player1.gesture, "lizard") == 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            if (string.Compare(player2.gesture, "lizard") == 1 && string.Compare(player1.gesture, "spock") == 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            if (string.Compare(player2.gesture, "lizard") == 1 && string.Compare(player1.gesture, "paper") == 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            if (string.Compare(player2.gesture, "spock") == 1 && string.Compare(player1.gesture, "rock") == 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            if (string.Compare(player2.gesture, "spock") == 1 && string.Compare(player1.gesture, "scissor") == 1)
            {
                Console.WriteLine("Player 2 wins!");
            }
            
            if (string.Compare(player1.gesture, "rock") == 1 && string.Compare(player2.gesture, "rock") == 1)
            {
                Console.WriteLine("Tie!");
            }
            if (string.Compare(player1.gesture, "paper") == 1 && string.Compare(player2.gesture, "paper") == 1)
            {
                Console.WriteLine("Tie!");
            }
            if (string.Compare(player1.gesture, "scissor") == 1 && string.Compare(player2.gesture, "scissor") == 1)
            {
                Console.WriteLine("Tie!");
            }
            if (string.Compare(player1.gesture, "lizard") == 1 && string.Compare(player2.gesture, "lizard") == 1)
            {
                Console.WriteLine("Tie!");
            }
            if (string.Compare(player1.gesture, "spock") == 1 && string.Compare(player2.gesture, "spock") == 1)
            {
                Console.WriteLine("Tie!");
            }



            //This method will determine which gesture will beat each other.
            //Rock beats scissor
            //Rock beats lizard
            //Paper beats rock
            //Paper beats Spock
            //Scissor beats paper
            //Scissor beats lizard
            //Lizard beats paper
            //Lizard beats Spock
            //Spock beats rock
            //Spock beats scissor
            //Figure out which player won at RPSLS


        }

        

    }
}   
