public class Character {
    // Attributes
    protected string _name;
    private string _color;
    protected int _atk;
    protected int _def;
    protected int _hp;
    private List<string> _inventory;


    // Constructors
    public Character(string name, string color, int atk, int def, int hp, List<string> inventory) {
        _name = name;
        _color = color;
        _atk = atk;
        _def = def;
        _hp = hp;
        _inventory = inventory;
    }

    public Character(string line) {
        // Code added later
    }


    // Methods
    public virtual void DisplayStats() {
        // This method will display the stats of the character
        Console.WriteLine($"{_name} \n{_hp}");
    }

    public void Introduce() {
        Console.WriteLine($"\"Hi! I'm {_name}!\" A {_color} faced creature says, \"Pleasure to meet you!\"");
    }

    public int GetHP(Character target) {
        int hp = target._hp;
        return hp;
    }
    public void Attack(Character target) {

        target._hp = target._hp - (_atk - target._def);
        Console.WriteLine($"{target._hp}");
        Console.WriteLine("A successful hit!");
    }

    public void Talk(Character target) {
        Console.WriteLine($"Hey, {target._name}! What's up!");
    }

    public void Pickup() {
        // code for later
    }

}