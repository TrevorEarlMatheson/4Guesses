using System;

namespace _4Guesses
{
    class Program
    {
        static string Guess(int answer, int guesses)
        {
            Console.WriteLine("I am thinking of a number between 1 and 10 try to guess it!");
            try
            {
                var currentGuess = int.Parse(Console.ReadLine()); // Return if they get the answer right.
                if(currentGuess == answer)
                {
                    return("You win!");
                }
                else if(currentGuess != answer && guesses < 3) //If user is wrong and they still have more guesses have the user guess again.
                {
                    Console.WriteLine("That is wrong I am not thinking of {0}. Try again!", currentGuess);
                    return(Guess(answer,++guesses));
                }
                else // If they have no more guesses return a lose prompt.
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
            Console.WriteLine("{0} I was thinking of {1}",result, answer); //Inform the user whether they have won or lost and what the correct answer was.
        }
    }
}
