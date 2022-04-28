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


            //make sure that the secret words only contains letters
            while (lettersonly == false || secretword.Length == 0)
            {
                Console.WriteLine("only letters");
                Console.WriteLine("please enter a word");
                secretword = Console.ReadLine();
                lettersonly = secretword.All(Char.IsLetter);
            }
            
            //changes all lowercase letter to capital letters
            secretword = secretword.ToUpper();

            //used arrry to check how many letters are ther in the word
            int wordLength = secretword.Length;
            char[] secretArray = secretword.ToCharArray();
            char[] Arraylength = new char[wordLength];
            char[] guessedLetters = new char[32];
            int guessStore = 0;
            bool WinCondition = false;
            int size = -1; 


            //for every letter in the secret word change it to "-"
            foreach (char letter in Arraylength)
            {
                size++;
                Arraylength[size] = '-';
            }


            while (lives > 0)
            {
                size = -1;
                string printProgress = String.Concat(Arraylength);
                bool letterFound = false;
                int multiples = 0;

                if (printProgress == secretword)
                {
                    WinCondition = true;
                    break;
                }

                //displays current lives
                if (lives > 0)
                {
                    Console.WriteLine("current lives {0}", lives);
                }

                //prints out the right letter guessed so far 
                Console.WriteLine("current progress: " + printProgress);
                Console.Write("Guess a letter: ");
                string playerGuess = Console.ReadLine();

                bool guessTest = playerGuess.All(Char.IsLetter);


                //Will prompt if user input more than 1 letter
                while (guessTest == false || playerGuess.Length != 1)
                {
                    Console.WriteLine("single letter only");
                    Console.Write("Guess a letter: ");
                    playerGuess = Console.ReadLine();
                    guessTest = playerGuess.All(Char.IsLetter);
                }

                //changes users guess to uppercase
                playerGuess = playerGuess.ToUpper();
                char playerChar = Convert.ToChar(playerGuess);


                //stores users guess letters
                if (guessedLetters.Contains(playerChar) == false)
                {

                    guessedLetters[guessStore] = playerChar;
                    guessStore++;

                    foreach (char letter in secretArray)
                    {
                        size++;
                        if (letter == playerChar)
                        {
                            Arraylength[size] = playerChar;
                            letterFound = true;
                            multiples++;
                        }

                    }

                    //condition if the player guesses a word right or wrong or reused the same letter
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

            //condition if player wins or loses
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
