public class Origin {
    // Attributes
    
    
    private int points;
    string _goalType;
    private string[] _goalTypes = {"Simple", "Eternal", "Checklist"};


    // Constructors

    public Origin() {}

    // Methods

    public void DisplayGoals(List<string> goals) {
        foreach (string item in goals) {
            Console.WriteLine(item);
        }
    }

    public void GetGoal() {
        
        Console.WriteLine("Here are the types of goals you can create:");

        for (int i = 0; i < _goalTypes.Count(); i++) {
            Console.WriteLine($"  {i}. {_goalTypes[i]}");
        }

        Console.Write("Which type of goal would you like to create?");
        string answer = Console.ReadLine();

        int numAnswer = Int32.Parse(answer);
        _goalType = _goalTypes[numAnswer];

        

    }

    public virtual void AddGoal() {
        // Blank
    }
    

    public void SaveGoals() {
        // Code here
    }

    public void LoadGoals() {
        // Code here
    }
}