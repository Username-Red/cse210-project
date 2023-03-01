using System;

class Program
{
    static void Main(string[] args)
    {





        List<Goal> goals = new List<Goal>();
        string[] goalTypes = {"Simple", "Eternal", "Checklist"};
        string [] options = {"Create", "List", "Save", "Load", "Record", "Quit"};
        int total = 0;
        string choice = "";


        // Open a while loop that runs as long as the user doesn't choose to quit
        while (choice != "6") {

            // Display current score
            Console.WriteLine($"Your current score is: {total}");

            // Display all options
            for (int i = 0; i < options.Count(); i ++) {
                Console.WriteLine($"  {i+1}. {options[i]}");
            }

            // Allow the user to choose an option
            Console.Write("What will you choose? ");
            choice = Console.ReadLine();

            // If the user chooses the create goal option
            if (choice == "1") {

                Console.WriteLine("Here are the goal types you can choose from:");

                // Display the kinds of goals they can make
                for(int i = 0; i < goalTypes.Count(); i ++) {
                    Console.WriteLine($"   {i+1}. {goalTypes[i]}");
                }

                // Allow them to choose a goal type
                Console.Write("What number will you choose?: ");
                choice = Console.ReadLine();

                // If they choose the simple goal option
                if (choice == "1") {
                    
                    // Get the data to create a new simple goal
                    
                    Console.Write("What is the name of your goal?");
                    string goalName = Console.ReadLine();
                    

                    Console.WriteLine("Give a short description of your goal: ");
                    string goalDesc = Console.ReadLine();
                    

                    Console.WriteLine("How many points is this goal worth? ");
                    int pointValue = Int32.Parse(Console.ReadLine());


                    // Chuck that information into our SimpleGoal object
                    SimpleGoal simple = new SimpleGoal(goalName, goalDesc, pointValue, false);
                    // Add the goal to the list of goals
                    goals.Add(simple);

                }


            }

            else if (choice == "2") {
                foreach (Goal line in goals) {
                    line.DisplayGoal();
                }

            }

            
            

        }


        

    }
}