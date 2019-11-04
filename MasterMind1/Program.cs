using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMastermindGame
{
    class Program
    {
        const int MAX_NUMBER = 6666;
        const int MIN_NUMBER = 1111;
        const int MAX_INDIV_NUMBER = 6;
        const int MIN_INDIV_NUMBER = 1;


        static void Main(string[] args)
        {
            //Loop necessary to play multiple games
            while (true)
            {
                //Intro Sequence & Game Setup
                Console.WriteLine("Welcome to Mastermind!");
                System.Threading.Thread.Sleep(2000);

                int intGuesses = NumGuesses();
                int intSecretCode = GenerateSecretCode();

                bool winState = false;

                bool[] guessAry = { false, false, false, false };
                bool[] answerAry = { false, false, false, false };
                Console.Clear();

                //Guesses Loop
                while (intGuesses > 0)
                {
                    Console.WriteLine("Guesses Remaining: " + intGuesses.ToString());

                    Console.WriteLine("\nMake your guess:\n");
                    int intUserGuess = 0;
                    string strUserGuess = Console.ReadLine();


                    if (isGuessCorrectFormat(ref strUserGuess, intSecretCode))
                    {
                        intUserGuess = Int32.Parse(strUserGuess);

                        if (intUserGuess == intSecretCode) //Game has been won.
                        {
                            winState = true;
                            break;
                        }

                        int inPlaceCount = getInPlaceCount(intUserGuess, guessAry, answerAry, intSecretCode);
                        int outOfPlaceCount = getOutOfPlaceCount(intUserGuess, guessAry, answerAry, intSecretCode);

                        string strFeedback = "\nScore: ";

                        //Switch statement builds feedback string.
                        #region Switch statement w/cases
                        switch (inPlaceCount)
                        {
                            case 0:
                                break;
                            case 1:
                                strFeedback += "+";
                                break;
                            case 2:
                                strFeedback += "++";
                                break;
                            case 3:
                                strFeedback += "+++";
                                break;
                        }
                        switch (outOfPlaceCount)
                        {
                            case 0:
                                break;
                            case 1:
                                strFeedback += "-";
                                break;
                            case 2:
                                strFeedback += "--";
                                break;
                            case 3:
                                strFeedback += "---";
                                break;
                            case 4:
                                strFeedback += "----";
                                break;
                        }
                        #endregion

                        Console.WriteLine(strFeedback + "\n");
                        Console.WriteLine("--------------------\n");
                        intGuesses--;
                    }
                    else
                        Console.WriteLine("Make sure your input is between 1111 and 6666, with each digit being no larger that 6.");
                }
                if (winState)
                {
                    Console.WriteLine("--------------------\n");
                    Console.WriteLine("\nYou solved it!");
                }
                else
                {
                    Console.WriteLine("\nYou lose. :(\n");
                    Console.WriteLine("The code was " + intSecretCode);
                }
    }
}