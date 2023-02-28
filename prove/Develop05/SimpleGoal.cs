public class SimpleGoal : Goal {
    // Attributes
    private bool _isComplete;

    // Constructors
    public SimpleGoal(string title, string desc, int value, bool isComplete) 
        : base(title, desc, value) {
        _isComplete = isComplete;
    }


    // Methods
    public override string Serialize()
    {
        string serial = $"SimpleGoal|{_title}|{_desc}|{_value}|{_isComplete}";
        return serial;
    }

    public override void Deserialize(string line)
    {
        string[] info = line.Split("|");

        string _goaltype = info[0];
        string _title = info[1];
        string _desc = info[2];
        int _value = Int32.Parse(info[3]);
        bool _isComplete = bool.Parse(info[4]);


    }

    public override void DisplayGoal()
    {

        if (_isComplete ) {
            Console.Write("[X]");
        }

        else if (!_isComplete) {
            Console.Write("[ ]");
        }
        Console.WriteLine($" {_title} ({_desc})");
    }

    public void CompleteGoal() {
        _isComplete = true;
    }
}