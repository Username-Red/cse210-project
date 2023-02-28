public class Goal {
    // Attributes
    protected string _title;
    protected string _desc;
    protected int _value;

    // Constructors
    public Goal(string title, string desc, int value) {
        _title = title;
        _desc = desc;
        _value = value;
    }

    public Goal(string line){}

    // Methods
    public virtual string Serialize() {
        // Code here
        return null;
    }

    public virtual void Deserialize(string line) {
        // Code here
    }

    public virtual void DisplayGoal() {
        // Code Here
    }

    
}