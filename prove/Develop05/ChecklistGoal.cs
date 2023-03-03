public class ChecklistGoal : Goal {
    // Attributes
    private bool _isComplete;
    private int _timesToComplete;
    private int _timesComplete;


    // Constructors
    public ChecklistGoal(string title, string desc, int value, bool isComplete, int timesToComplete) 
        : base(title, desc, value) {
        _isComplete = isComplete;
        _timesToComplete = timesToComplete;
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
        Console.WriteLine($" {_title} ({_desc}) {_timesComplete}/{_timesToComplete}");
    }

    public override void CompleteGoal() {
        if (_timesComplete < _timesToComplete) {
            _timesComplete += 1;

        }

        if (_timesComplete == _timesToComplete) {
            _isComplete = true;
            Console.WriteLine("Great work! You completed your goal! NOw you get your bonus!");
            _value += _value * 3;
        }
    }



}