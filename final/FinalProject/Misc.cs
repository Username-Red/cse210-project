public class Misc : Item {

    // Attributes
    protected int _effect;

    // Constructors 
    public Misc(string name, string desc, int effect) : base(name, desc) {
        _effect = effect;

    }

    public Misc(string line) : base(line) {

    }

    // Methods

    public int GiveInfo() {
        
        return _effect;
    }

    public override void DisplayInfo() {
        Console.WriteLine($"    Item: {_name} \n    Description: {_description}\n    Boost: {_effect}");
    }

}