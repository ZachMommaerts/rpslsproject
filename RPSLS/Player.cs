using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {

        //Member Variables (HAS A)
        int rock;
        int paper;
        int scissor;
        int lizard;
        int spock;
        int userInput;
        int opponentInput;
        int userScore;
        int opponentScore;

        //Constructor

        //Member Methods (CAN DO)
        protected List<int> gestures = new List<int>() {0, 1, 2, 3, 4};
        

        protected virtual void PlayGame()
        {
            Console.WriteLine("Play a gesture! Choose between Rock(1), Paper(2), Scissors(3), Lizard(4), Spock(5)");
            userInput = Int32.Parse(Console.ReadLine());
            while (userScore < 2 && opponentScore < 2)
            {
                while (userInput == 1)
                {
                    if (userInput == opponentInput)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (opponentInput == 3 && opponentInput == 4)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        userScore++;
                    }
                    if (opponentInput == 2 && opponentInput == 5)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        opponentScore++;
                    }
                }
                while (userInput == 2)
                {
                    if (userInput == opponentInput)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (opponentInput == 1 && opponentInput == 5)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        userScore++;
                    }
                    if (opponentInput == 3 && opponentInput == 4)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        opponentScore++;
                    }
                }
                while (userInput == 3)
                {
                    if (userInput == opponentInput)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (opponentInput == 2 && opponentInput == 4)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        userScore++;
                    }
                    if (opponentInput == 1 && opponentInput == 5)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        opponentScore++;
                    }
                }
                while (userInput == 4)
                {
                    if (userInput == opponentInput)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (opponentInput == 2 && opponentInput == 5)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        userScore++;
                    }
                    if (opponentInput == 1 && opponentInput == 3)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        opponentScore++;
                    }
                }
                while (userInput == 5)
                {
                    if (userInput == opponentInput)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (opponentInput == 1 && opponentInput == 3)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        userScore++;
                    }
                    if (opponentInput == 2 && opponentInput == 4)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        opponentScore++;
                    }
                }
            }
        }
    }
}
