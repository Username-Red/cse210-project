using System;


class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        Journal prompt1 = new Journal();
        Journal write = new Journal();

        Console.WriteLine("HI!");
        Console.WriteLine("I'm Citree! I'll be your Journal Keeper for this writing session!");

        while (answer != "5") {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit \n");
            Console.Write("Select an option: ");
            answer = Console.ReadLine();

            if (answer == "1") {
                //code here
                write.AddEntry();

                Console.WriteLine("That was a lovely entry!");


            }

            else if (answer == "2") {
                
                write.DisplayEntries();
                Console.WriteLine("Yup, those aresome deep entries right there.");

            }

            else if (answer == "3") {

                Console.WriteLine("Loading deep dark secrets... Kidding XD");


                write.Load();
                
            }

            else if (answer == "4") {

                Console.WriteLine("Saving data...");

                write.Save();

                Console.WriteLine("Data stored successfully!");
                
            }
            else if (answer == "5") {
                
            }
        }
    }
}