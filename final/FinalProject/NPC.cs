public class NPC : Character {
    // Attributes
    private int _friendLv; 

    // Constructors
    public NPC(string name, string color, int atk, int def, int hp, List<Item> inventory, int friendLv) 
    : base(name, color, atk, def, hp, inventory) {
        _friendLv = friendLv;
    }

    // Methods
    public override void DisplayStats()
    {
        Console.WriteLine($"Name: {_name} \nHP: {_hp} \nFriend Level: {_friendLv} \nINventory:");
        foreach (Item item in _inventory) {
            item.DisplayInfo();
        }
    }

    public void GiveSupport(Character target) {
        // blank 
    }
} 