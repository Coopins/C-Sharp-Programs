using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace Declaration
namespace TicTacToe
{
    // Program start class
    class InteractiveWelcome
    {
        // Main begins program execution.
        public static void Main()
        {
            RockPaperScissors();
        }

        static void RockPaperScissors()

        {
            //Rock, papaer, scissors game. 
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;

            while (playAgain)
            {

            }

            while (scorePlayer < 3 && scoreCPU < 3)

            Console.Write("Choose between rock, paper, and scissors:     ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(1,4);
            
            switch (randomInt)
            {
                case 1:
                    inputCPU = "Rock";
                    Console.WriteLine("Computer chose Rock");

                    if (inputPlayer == "Rock")

                    {
                        Console.WriteLine("Draw!\n\n");
                    }

                    else if (inputPlayer == "Paper")

                    {
                        Console.WriteLine("Player Wins!\n\n");
                        scorePlayer++;
                    }

                    else if (inputPlayer == "Scissors")

                    {
                        Console.WriteLine("CPU Wins!\n\n");
                        scoreCPU++;
                    }
                    break;

                case 2:
                    inputCPU = "Paper";
                    Console.WriteLine("Computer chose Paper");

                    if (inputPlayer == "Paper")

                    {
                        Console.WriteLine("Draw!\n\n");
                    }

                    else if (inputPlayer == "Rock")

                    {
                        Console.WriteLine("CPU Wins!\n\n");
                        scorePlayer++;
                    }

                    else if (inputPlayer == "Scissors")

                    {
                        Console.WriteLine("Player Wins!\n\n");
                        scoreCPU++;
                    }
                    break;

                case 3:
                    inputCPU = "Scissors";
                    Console.WriteLine("Computer chose Scissors");

                    if (inputPlayer == "Scissors")

                    {
                        Console.WriteLine("Draw!\n\n");
                    }

                    else if (inputPlayer == "Rock")

                    {
                        Console.WriteLine("Player Wins!\n\n");
                        scorePlayer++;
                    }

                    else if (inputPlayer == "Paper")

                    {
                        Console.WriteLine("CPU Wins!\n\n");
                        scoreCPU++;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }

            if (scorePlayer == 3)

            {
                Console.WriteLine("Player Won!");
            }
            else if (scoreCPU == 3)
            {
                Console.WriteLine("CPU Won!");
            }

            else
            {

            }

            Console.WriteLine("Do you want to play again?(y/n)");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                playAgain = true;
            }
            else if (loop == "n")
            {
                playAgain = false;
            }

        }
    }
}
        
    



