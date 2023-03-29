public class Misc : Item {

    // Attributes
    public int _effect;

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
        //Code here
    }

}