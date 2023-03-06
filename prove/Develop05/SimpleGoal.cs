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

    public override Goal Deserialize(string line)
    {
        string[] info = line.Split("|");

        
        _title = info[1];
        _desc = info[2];
        _value = Int32.Parse(info[3]);
        _isComplete = bool.Parse(info[4]);

        SimpleGoal simple = new SimpleGoal(_title, _desc, _value, _isComplete);

        return simple;

    }

    public override void DisplayGoal()
    {

        if (_isComplete ) {
            Console.Write("[X]");
        }

        else if (!_isComplete) {
            Console.Write("[ ]");
        }
        Console.WriteLine($" {_title} ({_desc}) {_value}");
    }

    public override void CompleteGoal() {
        _isComplete = true;
    }




}