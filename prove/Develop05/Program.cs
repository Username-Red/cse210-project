using System;

class Program
{
    static void Main(string[] args)
    {


        SimpleGoal simple = new SimpleGoal("Buid Web Shooters", "Complete the construction of wrist mounted web shooters for comic con", 1000, false);
        simple.DisplayGoal();
        simple.CompleteGoal();
        simple.DisplayGoal();

    }
}