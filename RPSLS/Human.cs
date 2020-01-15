using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        //Member Variables (HAS A)


        //Constructor
        public Human()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        //Member Methods (CAN DO)
        public override void ChooseGesture()
        {
            Console.WriteLine("Play a gesture! Choose between Rock(1), Paper(2), Scissors(3), Lizard(4), Spock(5)");
            gesture = Console.ReadLine();
            //To Do - Check If Gesture is in List of gesture.contains
            switch (gesture)
            {
                case "1":
                    Console.WriteLine($"{name} chose Rock!");
                    gesture = gestures[0];
                    break;
                case "2":
                    Console.WriteLine($"{name} chose Paper!");
                    gesture = gestures[1];
                    break;
                case "3":
                    Console.WriteLine($"{name} chose Scissors!");
                    gesture = gestures[2];
                    break;
                case "4":
                    Console.WriteLine($"{name} chose Lizard!");
                    gesture = gestures[3];
                    break;
                case "5":
                    Console.WriteLine($"{name} chose Spock!");
                    gesture = gestures[4];
                    break;
                default:
                    Console.WriteLine($"{name} did not choose a valid option. Please select again.");
                    ChooseGesture();
                    break;
            }
        }
    }
}