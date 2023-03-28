public class Player : Character {
    // Attributes
    private int _exp;
    private int _lvUpWall;
    private int _lv = 1;

    // Constructors
    public Player(string name, string color, int atk, int def, int hp, List<Item> inventory) 
    : base(name, color, atk, def, hp, inventory) {}

    // Methods
    public override void DisplayStats()
    {
        Console.WriteLine("Name: {_name} \nEXP: {_exp} \nHP: {_hp} \nATK: {_atk} \nDEF: {_def}");
    }

    public void LevelUp() {
        // code here
        _lv += 1;

        int newLvWall = _lvUpWall + (10 * _lv);
        int newExp = _exp + (10*_lv);

    }

    public void GainExp() {
        // For reference, I have no idea why I added this when LevelUp() Is right above it
        // I'm just adding it because it matches the plan
    }

    public void GetSupport() {
        // Again, no idea why I added this when the Supporter game mechanic is already located in the NPC class
        // But it matches the plan, so I have added it
    }
}