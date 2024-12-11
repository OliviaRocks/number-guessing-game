using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine("Guess a number from 1 to 100: ");

            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                string inputNumber = Console.ReadLine();

                if (inputNumber != null && int.TryParse(inputNumber, out int convertedNumber))
                {
                    switch (convertedNumber)
                    {
                        case int n when n > randomNumber:
                            Console.WriteLine($"The number is smaller than {convertedNumber}");
                            break;
                        case int n when n < randomNumber:
                            Console.WriteLine($"The number is bigger than {convertedNumber}");
                            break;
                        case int n when n == randomNumber:
                            Console.WriteLine($"You guessed the correct number {convertedNumber}");
                            break;
                        default:
                            Console.WriteLine("Wrong input. Please type a number between 1 and 100");
                            return;
                    }
                }
            }

        }

    }

}
