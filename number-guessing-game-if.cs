using System;

Random random = new Random();
int randomNumber = random.Next(1, 101);

Console.WriteLine("Guess a number from 1 to 100: ");

bool guessedCorrectly = false;

while (!guessedCorrectly)
{
    string inputNumber = Console.ReadLine();

    if (inputNumber != null && int.TryParse(inputNumber, out int convertedNumber))
    {
        if (convertedNumber > randomNumber)
        {
            Console.WriteLine($"The number is smaller than {convertedNumber}");
        }
        else if (convertedNumber < randomNumber)
        {
            Console.WriteLine($"The number is larger than {convertedNumber}");
        }
        else if (convertedNumber == randomNumber)
        {
            Console.WriteLine($"You guessed correctly the number {convertedNumber}");
        }
        else
        {
            Console.WriteLine($"Wrong input. Please type a number between 1 and 100");
        }
    }
}
