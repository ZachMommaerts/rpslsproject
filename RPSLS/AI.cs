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
            Console.WriteLine($"Gary chose {gesture}");
        }
    }
}
