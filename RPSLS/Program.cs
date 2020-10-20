using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Player player = new Human("Tim");
            //player.ChooseGesture();
            //game.GameSetup();
            game.RunGame();
            game.CompareGesture();
            game.CompareScore();
        
        }
    }
}
