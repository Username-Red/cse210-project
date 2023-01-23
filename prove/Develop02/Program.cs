using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";

        while (answer != "5") {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            answer = Console.ReadLine();

            if (answer == "1") {
                //code here
                // we want one of our writing prompts to be displayed to the screen
                // then we want our user to input some text
                randomPrompt prompt1 = new randomPrompt();
            }

            else if (answer == "2") {

            }

            else if (answer == "3") {
                
            }

            else if (answer == "4") {
                
            }
            else if (answer == "5") {
                
            }
        }
    }
}