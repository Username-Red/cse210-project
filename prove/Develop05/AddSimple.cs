public class AddSimple : Origin{
    // Attributes
    private List<string> _simpleGoals = new List<string>();

    // Constructors
    public AddSimple() 
        : base() {}

    // Methods 

    public override void AddGoal() {

        Console.Write("What is the name of your goal?");
        string goalName = Console.ReadLine();
        

        Console.WriteLine("Give a short description of your goal: ");
        string goalDesc = Console.ReadLine();
        

        Console.WriteLine("How many points is this goal worth? ");
        string pointValue = Console.ReadLine();

        
        



        
    }
    





}