using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*** Hangman ***");
            Console.WriteLine("Enter a word to guess: ");
            string secretword = Console.ReadLine();

            int lives = 5;
            

            bool lettersonly = secretword.All(Char.IsLetter);

            while (lettersonly == false || secretword.Length == 0)
            {
                Console.WriteLine("only letters");
                Console.WriteLine("please enter a word");
                secretword = Console.ReadLine();
                lettersonly = secretword.All(Char.IsLetter);
            }

            secretword = secretword.ToUpper();

            int wordLength = secretword.Length;
            char[] secretArray = secretword.ToCharArray();
            char[] Arraylength = new char[wordLength];
            char[] guessedLetters = new char[32];
            int numberStore = 0;
            bool WinCondition = false;
            int counter = -1; 

            foreach (char letter in Arraylength)
            {
                counter++;
                Arraylength[counter] = '-';
            }

            while (lives > 0)
            {
                counter = -1;
                string printProgress = String.Concat(Arraylength);
                bool letterFound = false;
                int multiples = 0;

                if (printProgress == secretword)
                {
                    WinCondition = true;
                    break;
                }

                if (lives > 0)
                {
                    Console.WriteLine("current lives {0}", lives);
                }

                Console.WriteLine("current progress: " + printProgress);
                Console.Write("Guess a letter: ");
                string playerGuess = Console.ReadLine();

                bool guessTest = playerGuess.All(Char.IsLetter);

                while (guessTest == false || playerGuess.Length != 1)
                {
                    Console.WriteLine("single letter only");
                    Console.Write("Guess a letter: ");
                    playerGuess = Console.ReadLine();
                    guessTest = playerGuess.All(Char.IsLetter);
                }

                playerGuess = playerGuess.ToUpper();
                char playerChar = Convert.ToChar(playerGuess);

                if (guessedLetters.Contains(playerChar) == false)
                {

                    guessedLetters[numberStore] = playerChar;
                    numberStore++;

                    foreach (char letter in secretArray)
                    {
                        counter++;
                        if (letter == playerChar)
                        {
                            Arraylength[counter] = playerChar;
                            letterFound = true;
                            multiples++;
                        }

                    }

                    if (letterFound)
                    {
                        Console.WriteLine("Found {0} letter: {1}", multiples, playerChar);
                    }
                    else
                    {
                        Console.WriteLine("Doesnt contain letter: {0}", playerChar);
                        lives -= 1;
                    }
                    
                }
                else
                {
                    Console.WriteLine("You already guessed {0}", playerChar);
                }


            }


            if (WinCondition)
            {
                Console.WriteLine("\n\nwell done");
                Console.WriteLine("The word was:" + secretword);
            }
            else
            {
                Console.WriteLine("\n\nGameover");
                Console.WriteLine("The word was:" + secretword);

            }
            Console.ReadLine();
        }

    }
}
