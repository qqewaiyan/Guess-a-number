using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int min = 0;
            int max = 100;
            int guess;
            int guesses;
            int number;
            String response;
            bool playAgain = true;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max +1);
                
                while(guess != number)
                {
                    Console.WriteLine("Guess a number between" + min + "-" + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("guess" + guess);
                    if( guess > number)
                    {
                        Console.WriteLine(guess + "is too high" );
                    }
                    else if( guess < number)
                    {
                        Console.WriteLine(guess + "is too low");
                    }
                    guesses++;
                }
                Console.WriteLine("Number =" + number);
                Console.WriteLine("You Win");
                Console.WriteLine("Guesses" +guesses);

                Console.WriteLine("Would you like to play again? Y/N");
                response =Console.ReadLine();
                response = response.ToUpper();

                if( response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain= false;
                }
                
            }
            Console.WriteLine("Thank you for playing" +
                "");

            Console.ReadKey();


        }
    }
}
