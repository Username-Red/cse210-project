public class NPC : Character {
    // Attributes
    private int _friendLv; 

    // Constructors
    public NPC(string name, string color, int atk, int def, int hp, List<string> inventory, int friendLv) 
    : base(name, color, atk, def, hp, inventory) {
        _friendLv = friendLv;
    }

    // Methods
    public override void DisplayStats()
    {
        // Code Here
    }

    public void GiveSupport(Character target) {
        // Code here
    }
} 