using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName() {
            Console.WriteLine("Please enter your name: ");
            string answer = Console.ReadLine();
            return answer;
        }

        static int PromptUserNumber() {
            Console.WriteLine("Please enter your favourite number: ");
            string answer = Console.ReadLine();
            int fav_num = int.Parse(answer);
            return fav_num;
        }

        static int SquareNumber(int fav_num) {
            int squared = fav_num*fav_num;
            return squared;

        }

        static void DisplayResult(int squared, string name){
            Console.WriteLine($"{name}, your favourite number is {squared} squared.");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int fav_num = PromptUserNumber();
        int square_fav = SquareNumber(fav_num);
        DisplayResult(square_fav, name);
    }
}