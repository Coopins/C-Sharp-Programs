using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE

{

    class Program

    {

        //making array and   

        //by default I am providing 0-9 where no use of zero  

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1; //By default player 1 is set  

        static int choice; //This holds the choice at which position user want to mark   



        // The flag veriable checks who has won if it's value is 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running  

        static int flag = 0;



        static void Main(string[] args)

        {

            do

            {

                Console.Clear();// whenever loop will be again start then screen will be clear  

                Console.WriteLine("Player1:X and Player2:O");

                Console.WriteLine("\n");

                if (player % 2 == 0)//checking the chance of the player  

                {

                    Console.WriteLine("Player 2 Chance");

                }

                else

                {

                    Console.WriteLine("Player 1 Chance");

                }

                Console.WriteLine("\n");

                Board();// calling the board Function  

                choice = int.Parse(Console.ReadLine());//Taking users choice   



                // checking that position where user want to run is marked (with X or O) or not  

                if (arr[choice] != 'X' && arr[choice] != 'O')

                {

                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  

                    {

                        arr[choice] = 'O';

                        player++;

                    }

                    else

                    {

                        arr[choice] = 'X';

                        player++;

                    }

                }

                else //If there is any possition where user want to run and that is already marked then show message and load board again  

                {

                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);

                    Console.WriteLine("\n");

                    Console.WriteLine("Please wait 2 second board is loading again.....");

                    Thread.Sleep(2000);

                }

                flag = CheckWin();// calling of check win  

            } while (flag != 1 && flag != -1);// This loof will be run until all cell of the grid is not marked with X and O or some player is not win  



            Console.Clear();// clearing the console  

            Board();// getting filled board again  



            if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  

            {

                Console.WriteLine("Player {0} has won", (player % 2) + 1);

            }

            else// if flag value is -1 the match will be draw and no one is winner  

            {

                Console.WriteLine("Draw");

            }

            Console.ReadLine();

        }

        // Board method which creats board  

        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");

        }



        //Checking that any player has won or not  

  

        

    }

}