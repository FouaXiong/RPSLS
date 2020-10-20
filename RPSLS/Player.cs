using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        // Member Variable
        public string gesture;
        public int score;
        public List<string> Gestures;
        
        // Constructor
        public Player()
        {
            Gestures = new List<string>()
            {
                "paper", "rock", "scissor", "lizard", "spock"
            };
            score = 0;
        }  


        // Member Method
        // What a Player can do
        public abstract void ChooseGesture();
    }



}
