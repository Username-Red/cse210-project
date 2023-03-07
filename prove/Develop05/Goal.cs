public class Goal {
    // Attributes
    protected string _title;
    protected string _desc;
    protected int _value;

    protected string _line;

    // Constructors
    public Goal(string title, string desc, int value) {
        _title = title;
        _desc = desc;
        _value = value;
    }

    public Goal(string line){
        _line = line;
    }

    // Methods
    public virtual string Serialize() {
        // Code here
        return null;
    }

    public virtual Goal Deserialize(string line) {
        // Code here
        Console.WriteLine("This method is not working");
        return null;
    }

    public virtual void DisplayGoal() {
        // Code Here
    }

    public virtual void CompleteGoal() {
        //Code here
    }

    public int GetValue() {
        return _value;
    }

}