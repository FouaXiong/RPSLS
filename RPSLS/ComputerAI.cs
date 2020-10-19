using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerAI : Player
    {
        Random random;

        public ComputerAI(Random bot)
        {
            random = bot;
        }

        public override void ChooseGesture()
        {
            // UserRandom number to choose a gesture.
            int num = random.Next(Gestures.Count);
            gesture = Gestures[num];
            Console.WriteLine(gesture);
        }
    }
}
