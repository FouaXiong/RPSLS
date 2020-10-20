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
            //Player 1 and 2 chose their gesture and will need to Equals each gestures.
            //IF STATEMENT to Equals what player 1 chose vs what Player 2 chose. 

            if (string.Equals(player1.gesture, "rock") && string.Equals(player2.gesture, "scissor"))
            {
                Console.WriteLine("Player 1 wins!");
                player1.score += 1;
            }
            else if (string.Equals(player1.gesture, "rock") && string.Equals(player2.gesture, "lizard"))
            {
                Console.WriteLine("Player 1 wins!");
                player1.score += 1;
            }
            else if (string.Equals(player1.gesture, "paper") && string.Equals(player2.gesture, "rock"))
            {
                Console.WriteLine("Player 1 wins!");
                player1.score += 1;
            }
            else if (string.Equals(player1.gesture, "paper") && string.Equals(player2.gesture, "spock"))
            {
                Console.WriteLine("Player 1 wins!");
                player1.score += 1;
            }
            else if (string.Equals(player1.gesture, "scissor") && string.Equals(player2.gesture, "paper"))
            {
                Console.WriteLine("Player 1 wins!");
                player1.score += 1;
            }
            else if (string.Equals(player1.gesture, "scissor") && string.Equals(player2.gesture, "lizard"))
            {
                Console.WriteLine("Player 1 wins!");
                player1.score += 1;
            }
            else if (string.Equals(player1.gesture, "lizard") && string.Equals(player2.gesture, "spock"))
            {
                Console.WriteLine("Player 1 wins!");
                player1.score += 1;
            }
            else if (string.Equals(player1.gesture, "lizard") && string.Equals(player2.gesture, "paper"))
            {
                Console.WriteLine("Player 1 wins!");
                player1.score += 1;
            }
            else if (string.Equals(player1.gesture, "spock") && string.Equals(player2.gesture, "rock"))
            {
                Console.WriteLine("Player 1 wins!");
                player1.score += 1;
            }
            else if (string.Equals(player1.gesture, "spock") && string.Equals(player2.gesture, "scissor"))
            {
                Console.WriteLine("Player 1 wins!");
                player1.score += 1;
            }

            else if (string.Equals(player2.gesture, "rock") && string.Equals(player1.gesture, "scissor"))
            {
                Console.WriteLine("Player 2 wins!");
                player2.score += 1;
            }
            else if (string.Equals(player2.gesture, "rock") && string.Equals(player1.gesture, "lizard"))
            {
                Console.WriteLine("Player 2 wins!");
                player2.score += 1;
            }
            else if (string.Equals(player2.gesture, "paper") && string.Equals(player1.gesture, "rock"))
            {
                Console.WriteLine("Player 2 wins!");
                player2.score += 1;
            }
            else if (string.Equals(player2.gesture, "paper") && string.Equals(player1.gesture, "spock"))
            {
                Console.WriteLine("Player 2 wins!");
                player2.score += 1;
            }
            else if (string.Equals(player2.gesture, "scissor") && string.Equals(player1.gesture, "paper"))
            {
                Console.WriteLine("Player 2 wins!");
                player2.score += 1;
            }
            else if (string.Equals(player2.gesture, "scissor") && string.Equals(player1.gesture, "lizard"))
            {
                Console.WriteLine("Player 2 wins!");
                player2.score += 1;
            }
            else if (string.Equals(player2.gesture, "lizard") && string.Equals(player1.gesture, "spock"))
            {
                Console.WriteLine("Player 2 wins!");
                player2.score += 1;
            }
            else if (string.Equals(player2.gesture, "lizard") && string.Equals(player1.gesture, "paper"))
            {
                Console.WriteLine("Player 2 wins!");
                player2.score += 1;
            }
            else if (string.Equals(player2.gesture, "spock") && string.Equals(player1.gesture, "rock"))
            {
                Console.WriteLine("Player 2 wins!");
                player2.score += 1;
            }
            else if (string.Equals(player2.gesture, "spock") && string.Equals(player1.gesture, "scissor"))
            {
                Console.WriteLine("Player 2 wins!");
                player2.score += 1;
            }

            else if (string.Equals(player1.gesture, "paper") && string.Equals(player2.gesture, "paper"))
            {
                Console.WriteLine("Tie!");
            }
            else if (string.Equals(player1.gesture, "rock") && string.Equals(player2.gesture, "rock"))
            {
                Console.WriteLine("Tie!");
            }
            else if (string.Equals(player1.gesture, "scissor") && string.Equals(player2.gesture, "scissor"))
            {
                Console.WriteLine("Tie!");
            }
            else if (string.Equals(player1.gesture, "lizard") && string.Equals(player2.gesture, "lizard"))
            {
                Console.WriteLine("Tie!");
            }
            else if (string.Equals(player1.gesture, "spock") && string.Equals(player2.gesture, "spock"))
            {
                Console.WriteLine("Tie!");
            }
            Console.ReadLine();


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

        public void CompareScore()
        {
            // Whichever player reaches 2 points wins the game
            while(player1.score < 2 && player2.score < 2)
            {
                Console.WriteLine(player1.score);
                Console.WriteLine(player2.score);
                RunGame();
                CompareGesture();
                
            }
            if(player1.score > player2.score)
            {
                Console.WriteLine("Player 1 has won the game!");
            }
            else
            {
                Console.WriteLine("Player 2 has won the game!");
            }
         
            Console.ReadLine();
        }
        

    }
}   
