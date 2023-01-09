using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess_count = 0;

        int guess = -1;

        while (guess != magicNumber) {

            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber) {
                Console.WriteLine("Lower");
            }

            else if (guess < magicNumber) {
                Console.WriteLine("Higher");
            }

            guess_count += 1;
        }
        Console.Write("Well done! You guessed the magic number!");
        Console.WriteLine($"And it only took {guess_count} guesses!");
    }
}