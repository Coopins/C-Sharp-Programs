using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TowerofHanoi
{
    class Program
    {
        public static void Main(string[] args) // stacks are used to push and pop disks from rod to rod
        {
            Stack<int> A = new Stack<int>();
            A.Push(4);
            A.Push(3);
            A.Push(2);
            A.Push(1);
            Stack<int> B = new Stack<int>();
            Stack<int> C = new Stack<int>();
            string from;
            string to;

            int[] win = new int[] { 1, 2, 3, 4 }; // this is the condition for the winning array

            bool play = false;

            while (play == false)
            {


                printgame(A.ToArray(), B.ToArray(), C.ToArray());


                Console.WriteLine("Welcome to Towers of Honai! Give the game a go!");
                from = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine("Welcome to Towers of Honai! Give the game a go!");
                Console.WriteLine();

                // Peek is used to compare the disk size from one stack to another, to determine if the move is valid. 
                if (from == "A")
                {
                    if (A.Count == 0)
                    {
                        continue;
                    }
                    else if (to == "B")
                    {
                        if (B.Count == 0 || B.Peek() > C.Peek())
                        {
                            B.Push(A.Pop());
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else if (to == "C")
                    {
                        if (C.Count == 0 || C.Peek() > A.Peek())
                        {
                            C.Push(A.Pop());

                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect input!");
                        Console.WriteLine("Press any key to continue.");
                        Console.WriteLine();
                        Console.ReadKey();
                        continue;
                    }
                }
                else if (from == "B")
                {
                    if (B.Count == 0)
                    {
                        continue;
                    }
                    else if (to == "A")
                    {
                        if (A.Count == 0 || A.Peek() > B.Peek())
                        {
                            A.Push(B.Pop());
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else if (to == "C")
                    {
                        if (C.Count == 0 || C.Peek() > C.Peek())
                        {
                            C.Push(B.Pop());
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect input!");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        continue;
                    }
                }
                else if (from == "C")
                {
                    if (C.Count == 0)
                    {
                        continue;
                    }
                    else if (to == "A")
                    {
                        if (A.Count == 0 || A.Peek() > C.Peek())
                        {
                            A.Push(C.Pop());
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else if (to == "B")
                    {
                        if (B.Count == 0 || B.Peek() > C.Peek())
                        {
                            B.Push(C.Pop());
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect input!");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered incorrect input!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }
                if (C.Count == 4)
                {
                    Console.WriteLine("Congratulations! You Win!"); // this determines if the user has won the game. 
                    play = true;
                    break;
                }

            }
            Console.WriteLine("");
            Console.ReadKey();
        }

        public static void printgame(int[] A, int[] B, int[] C) // this program prints the status of which disks are on which rods as the user plays the game
        {
            Console.Write("A: ");
            for (int i = A.Length - 1; i >= 0; i--)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.Write("B: ");
            for (int i = B.Length - 1; i >= 0; i--)
            {
                Console.Write(B[i] + " ");
            }
            Console.WriteLine();
            Console.Write("C: ");
            for (int i = C.Length - 1; i >= 0; i--)
            {
                Console.Write(C[i] + " ");
            }
            Console.WriteLine();
        }
    }
}