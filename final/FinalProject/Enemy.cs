public class Enemy : Character {
    // Attributes
    private int _evilness; 

    // Constructors
    public Enemy(string name, string color, int atk, int def, int hp, List<Item> inventory, int evilness) 
    : base(name, color, atk, def, hp, inventory) {
        _evilness = evilness;
    }

    // Methods
    public override void DisplayStats() {
        
        Console.WriteLine($"Name: {_name} \nHP: {_hp} \nEvilness:{_evilness}");
    }

    public void Infect(Item target) {
        // Code here
    }
}