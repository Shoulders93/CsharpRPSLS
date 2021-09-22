using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpRPSLS
{
    public abstract class Player
    {
        public string pickedGesture;
        public int score;
        public List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

        public void DisplayGestures()
        {
            int index = 0;
            foreach(string gesture in gestures)
            {
                Console.WriteLine($"{index}: {gesture}");
                index++;
            }
        }

        public abstract void ChooseGesture();


    }
    
}
