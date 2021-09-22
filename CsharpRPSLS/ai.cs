using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpRPSLS
{
    public class Ai : Player

    {
        public Ai()
        {
            
        }

        public override void ChooseGesture()
        {
            pickedGesture = gestures[RandomNumber(0, 4)];
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

       
      
    }
}
