﻿using System;

namespace _4Guesses
{
    class Program
    {
        static string Guess(int answer, int guesses)
        {
            Console.WriteLine("I am thinking of a number between 1 and 10 try to guess it!");
            try
            {
                var currentGuess = int.Parse(Console.ReadLine());
                if(currentGuess == answer)
                {
                    return("You win!");
                }
                else if(currentGuess != answer && guesses < 3)
                {
                    Console.WriteLine("That is wrong I am not thinking of {0}. Try again!", currentGuess);
                    return(Guess(answer,++guesses));
                }
                else
                {
                    return("You Lose!");
                }
            }
            catch(FormatException) //If the user enters anything other than a number prompt them to try again.
            {
                Console.WriteLine("This is not a valid entry, please try again.");
                return(Guess(answer,guesses));
            }
        }
        static void Main(string[] args)
        {
            var random = new Random();
            var answer = random.Next(1, 11);
            var guesses = 0;
            var result = Guess(answer, guesses);
            Console.WriteLine("{0} I was thinking of {1}",result, answer);
        }
    }
}
