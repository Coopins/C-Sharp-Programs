using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word and the program will translate your word into pig latin! ");

            PigTranslate();

            Console.ReadLine();

        }

        static void PigTranslate()
        {
            //Declares what a user's input is
            string userInput;
            userInput = Console.ReadLine();

            //Array library for vowels 
            string[] vowelArray = { "a", "e", "i", "o", "u" };
            char[] vowelArrayChar = { 'a', 'e', 'i', 'o', 'u' };

            string firstPos = userInput.Substring(0, 1);
            string lastPos = userInput.Substring(userInput.Length - 1);
            string firstLetter;
            string restofWord;
            string vowels = "AEIOUaeiou";
            string piggedWord = "";

            int letterPosition;

            //Conditional Statements
            // If a word starts with a vowel and ends in a vowel, add "yay" to the end.
            if (vowelArray.Contains(firstPos) && vowelArray.Contains(lastPos))
            {
                Console.WriteLine(userInput + "yay");
            }

            //If a word starts with a vowel and ends in a consonant, add "ay" to the end
            else if (vowelArray.Contains(firstPos))
            {
                Console.WriteLine(userInput + "ay");
            }

            //If a word has a vowel and starts with a consonant, move all the letters before the initial vowel to the end, then add "ay". 
            else if (userInput.IndexOfAny(vowelArrayChar) == -1)
            {
                Console.WriteLine(userInput + "ay");
            }

            //OTHER
            else
            {
                //Loop that declares a "word" from userInput and applies the Split[] Method 
                foreach (string word in userInput.Split())
                {
                    //Declares what the properties of the "word" string are and logs the position of the first vowel in a word
                    firstLetter = word.Substring(0, 1);
                    restofWord = word.Substring(1, word.Length - 1);
                    letterPosition = vowels.IndexOf(firstLetter);

                    //IF the position of the newly formed "piggedWord" is -1, meaning there are no vowels, then swap all letters before the vowel and add "ay" at the end
                    if (letterPosition == -1)
                    {
                        piggedWord = restofWord + firstLetter + "ay";
                    }


                    else
                    {
                        piggedWord = word + "way";
                    }
                    Console.WriteLine(piggedWord);
                }
            }
        }
    }
}