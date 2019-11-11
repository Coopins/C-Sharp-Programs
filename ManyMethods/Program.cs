using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace Declaration
namespace TowersOfHonai
{

    // Program start class
    class InteractiveWelcome
    {
        // Main begins program execution.
        public static void Main()

        {
            Hello();
            Addition();
            Catdog();
            Oddeven();
            Inches();
            Echo();
            Killigram();
            Date();
            Age();
            Guess();
        }
        static void Hello()
        {
            //Prints out a greeting and ask the user their name. Then responds with a "Bye Bob!" (replacing Bob with the name entered)
            Console.WriteLine("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Bye {0} ! ", name);
        }

        static void Addition()
        {
            //A method that ask the user for 2 numbers and prints out their sum
            Console.WriteLine("Pick your first number.: ");
            int response1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(response1);

            Console.WriteLine("Pick your second number.: ");
            int response2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(response2.GetType());

            int total = response1 + response2;
            Console.WriteLine("The sum is " + total + "."); //string concatenation
            Console.WriteLine("The sum is {0}.", total); //string interpolation
        }

        static void Catdog()
        {
            //A method that ask the user if they prefer cats or dogs, and either "Barks" or "Meows" back depending on what they entered.
            Console.WriteLine("Do you prefer cats or dogs?:");
            string name = Console.ReadLine().ToLower();
            if (name == "cats")
            {
                Console.WriteLine("Meow");
            }
            else if (name == "dogs")
            {
                Console.WriteLine("Bark");
            }
            else
            {
                Console.WriteLine("ERROR");
            }


        }

        static void Oddeven()
        {
            //A method that asks the user for a number, and prints out if it is odd or even
            int num;
            Console.WriteLine("Pick a number.");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)

            {
                Console.WriteLine("Number {0} is Even", num);
            }
            else
            {
                Console.WriteLine("Number {0} is Odd", num);
            }
            Console.ReadLine();

        }

        static void Inches()
        {
            double inch;

            Console.WriteLine("enter your height in Feet: "); //i.e. 3,4,5, etc
            double feet = Convert.ToDouble(Console.ReadLine());
            inch = feet * 12;

            Console.WriteLine("You are {0} inches tall!", inch);
        }

        static void Echo()
        {
            //A method that ask the user for a word then prints it 3 times, first in all caps, then 2 more time in all lower case
            Console.WriteLine("Type a word to witness an echo: ");
            string input = Console.ReadLine();
            string upper = input.ToUpper();
            string lower = input.ToLower();

            Console.WriteLine(upper + " " + lower + " " + lower);
        }

        static void Killigram()
        {
            //A method that ask the user for a weight in pounds, then converts it to killograms
            double kilograms;

            Console.WriteLine("Enter your weight in pounds: "); //Numbers only
            double pounds = Convert.ToDouble(Console.ReadLine());

            kilograms = pounds / 2.205;

            Console.WriteLine("You weigh {0} in KIlograms!", kilograms);
        }

        static void Date()
        {

            Console.WriteLine("The current date and time is: ");

            var today = DateTime.Now;
            Console.WriteLine(today);
        }

        static void Age()
        {
            // A method that asks the user their birth year, and print out their age
            Console.WriteLine("Enter your birth year: ");
            var input = Convert.ToString(Console.ReadLine());

            DateTime currentYear = DateTime.Today;

            int age = currentYear.Year - Convert.ToInt32(input);
            Console.WriteLine("You are {0} years young, or old, depending on how you look at it LOL!", age);
        }

        static void Guess()
        {
            //A method that ask the user to guess a word, and print out 'CORRECT!!' if the word is "chsarp", otherwise prints out 'WRONG!!'
            Console.WriteLine("Guess the correct word.");
            string answer = Console.ReadLine();

            if (answer == "Csharp")
            {
                Console.WriteLine("CORRECT!!!");
            }

            else
            {
                Console.WriteLine("WRONG!!!");
            }

        }
    }



}