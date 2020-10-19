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

        }
        

    }
}   
