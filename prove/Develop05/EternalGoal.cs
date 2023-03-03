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

    public override void Deserialize(string line)
    {
        string[] info = line.Split("|");

        string _goaltype = info[0];
        string _title = info[1];
        string _desc = info[2];
        int _value = Int32.Parse(info[3]);
        


    }





}