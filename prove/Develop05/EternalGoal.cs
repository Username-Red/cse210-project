public class EternalGoal : Goal {

    // Attributes
    

    // Constructors
    public EternalGoal(string title, string desc, int value) : base(title, desc, value) {
        // no necessary code here
    }

    // Methods

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_title} ({_desc})");
    }

    public override string Serialize()
    {
        string serial = $"EternalGoal|{_title}|{_desc}|{_value}";
        return serial;
    }

    public override Goal Deserialize(string line)
    {
        string[] info = line.Split("|");

        _title = info[1];
        _desc = info[2];
        _value = Int32.Parse(info[3]);

        EternalGoal eternal = new EternalGoal(_title, _desc, _value);
        return eternal;

        


    }





}