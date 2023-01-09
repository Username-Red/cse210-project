using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade pergentage?: ");
        string grade_percentage = Console.ReadLine();
        string grade = "blank";

        int gp = int.Parse(grade_percentage);

        if (gp >= 90) {
            grade = "A";

        }

        else if (gp >= 80 && gp < 90) {

            grade = "B";

        }

        else if (gp >= 70 && gp < 80) {

            grade = "C";

        }

        else if (gp >= 60 && gp < 70) {

            grade = "D";

        }

        else if (gp < 60) {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");

        if (gp >= 70) {
            Console.WriteLine("Congratulations! You passed!");
        }

        else if (gp < 70) {
            Console.WriteLine("Awww too bad, you didn't make it. But I'm sure you'll get there next time!");
        }

    }
}