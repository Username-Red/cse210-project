public class Player : Character {
    // Attributes
    private int _exp = 0;
    private int _lvUpWall = 10;
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

        if (_exp == _lvUpWall) {
            _lv += 1;

            int newLvWall = _lvUpWall + (10 * _lv);
            int newExp = _exp + (10*_lv);
        }
        

    }

    public void GainExp() {
        _exp += 5;
    }

    public void GetSupport(int friendBoost) {
        _atk += friendBoost;
        
    }
}