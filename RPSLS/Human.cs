using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   public class Human : Player
    {
        // Member Variable
        public string name;


        // Constructor
        public Human(string name)
        {
            this.name = name;   
        }

        public override void ChooseGesture()
        {
            //Take userInput to choose a gesture.
            //Store into a variable.
 
            Console.WriteLine("Choose gesture.");
            for (int i = 0; i < this.Gestures.Count; i++)
            {
                Console.WriteLine(i + 1 + " " + Gestures[i]);
            }
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            gesture = Gestures[userNumber - 1];
            Console.WriteLine(gesture);
        }
    }
}
