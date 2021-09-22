using System;

namespace CsharpRPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Ai computer = new Ai();
            Human person = new Human();
            computer.ChooseGesture();
            Console.WriteLine(computer.pickedGesture);
            person.DisplayGestures();
        }
    }
}
