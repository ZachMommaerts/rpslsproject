using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {

        //Member Variables (HAS A)
        public string gestureName;

        //Constructor
        public AI()
        {
            name = "Gary";
        }

        //Member Methods (CAN DO)
        public override void ChooseGesture()
        {
            Random random = new Random();
            int compgesture = random.Next(1, 5);
            gesture = compgesture.ToString();
            switch (gesture)
            {
                case "1":
                    gestureName = "Rock";
                    break;
                case "2":
                    gestureName = "Paper";
                    break;
                case "3":
                    gestureName = "Scissors";
                    break;
                case "4":
                    gestureName = "Lizard";
                    break;
                case "5":
                    gestureName = "Spock";
                    break;
            }
            Console.WriteLine($"Gary chose {gestureName}");
        }
    }
}
