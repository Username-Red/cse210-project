public class Enemy : Character {
    // Attributes
    private int _evilness; 

    // Constructors
    public Enemy(string name, string color, int atk, int def, int hp, List<string> inventory, int evilness) 
    : base(name, color, atk, def, hp, inventory) {
        _evilness = evilness;
    }

    // Methods
    public override void DisplayStats()
    {
        // Code Here
    }

    public void Infect(Item target) {
        // Code here
    }
}