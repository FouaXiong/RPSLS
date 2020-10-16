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
        public override void ChooseGestures()
        {

        }


    }
}
