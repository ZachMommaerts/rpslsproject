using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {

        //Member Variables (HAS A)
        public string name;
        public int score ;
        public List<string> gestures;
        public string gesture;
        

        //Constructor
        public Player()
        {
            gestures = new List<string>() { "1", "2", "3", "4", "5" };
            score = 0;
        }   
        //Member Methods (CAN DO)



        public abstract void ChooseGesture();
    }
}
