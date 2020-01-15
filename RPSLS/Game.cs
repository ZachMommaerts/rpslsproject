using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {

        //Member Variables (HAS A)

        Player playerOne;
        Player playerTwo;
        string gesture;

        //Constructor
        
        //Member Methods (CAN DO)
        public void SetNumberOfPlayers()
        {
            Console.WriteLine("Do you want to play against the computer [1] or against another player [2]?");
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    Console.WriteLine("You have selected to play against the computer.");
                    playerOne = new Human();
                    playerTwo = new AI();
                    break;
                case "2":
                    Console.WriteLine("You have selected to play against another player");
                    playerOne = new Human();
                    playerTwo = new Human();
                    break;
                default:
                    Console.WriteLine("You did not choose a valid option. Please choose again.");
                    SetNumberOfPlayers();
                    break;
            }
        }
        public void CheckingForRule()
        {
            Console.WriteLine("Do you know the rules? Hit [1] for yes or [2] for no");
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    SetNumberOfPlayers();
                    break;
                case "2":
                    Console.WriteLine("Rules:\nRock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock");
                    SetNumberOfPlayers();
                    break;
                default:
                    Console.WriteLine("You did not select a valid option. Please choose again");
                    CheckingForRule();
                    break;
            }
        }
        public void CompareGesture()
        {
            if(playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} wins!");
            }
            if(playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} wins!");
            }
            while (playerOne.score < 2 || playerTwo.score < 2)
            {
                while (playerOne.gesture == "1")
                {
                    Console.WriteLine("Player 1 chose Rock");
                    if (playerOne.gesture == playerTwo.gesture)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                        break;
                    }
                    if (playerTwo.gesture == "3" || playerTwo.gesture == "4")
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        playerOne.score++;
                        break;
                    }
                    if (playerTwo.gesture == "2" || playerTwo.gesture == "5")
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        playerTwo.score++;
                        break;
                    }
                }
                while (playerOne.gesture == "2")
                {
                    Console.WriteLine("Player 1 chose Paper");
                    if (playerOne.gesture == playerTwo.gesture)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                        break;
                    }
                    if (playerTwo.gesture == "1" || playerTwo.gesture == "5")
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        playerOne.score++;
                        break;
                    }
                    if (playerTwo.gesture == "3" || playerTwo.gesture == "4")
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        playerTwo.score++;
                        break;
                    }
                }
                while (playerOne.gesture == "3")
                {
                    Console.WriteLine("Player 1 chose Scissors");
                    if (playerOne.gesture == playerTwo.gesture)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                        break;
                    }
                    if (playerTwo.gesture == "2" || playerTwo.gesture == "4")
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        playerOne.score++;
                        break;
                    }
                    if (playerTwo.gesture == "1" || playerTwo.gesture == "5")
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        playerTwo.score++;
                        break;
                    }
                }
                while (playerOne.gesture == "4")
                {
                    Console.WriteLine("Player 1 chose Lizard");
                    if (playerOne.gesture == playerTwo.gesture)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                        break;
                    }
                    if (playerTwo.gesture == "2" || playerTwo.gesture == "5")
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        playerOne.score++;
                        break;
                    }
                    if (playerTwo.gesture == "1" || playerTwo.gesture == "3")
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        playerTwo.score++;
                        break;
                    }
                }
                while (playerOne.gesture == "5")
                {
                    Console.WriteLine("Player 1 chose Spock");
                    if (playerOne.gesture == playerTwo.gesture)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                        break;
                    }
                    if (playerTwo.gesture == "1" || playerTwo.gesture == "3")
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        playerOne.score++;
                        break;
                    }
                    if (playerTwo.gesture == "2" || playerTwo.gesture == "4")
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        playerTwo.score++;
                        break;
                    }
                }
            }
        }
        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
            CheckingForRule();
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
            CompareGesture();
        }
    }
}
