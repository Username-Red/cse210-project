public class Character {
    // Attributes
    protected string _name;
    private string _color;
    protected int _atk;
    protected int _def;
    protected int _hp;
    protected List<Item> _inventory;


    // Constructors
    public Character(string name, string color, int atk, int def, int hp, List<Item> inventory) {
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
        Console.WriteLine($"Name: {_name} \nHP: {_hp}");
    }

    public void Introduce() {
        Console.WriteLine($"\"Hi! I'm {_name}!\" A {_color} faced creature says, \"Pleasure to meet you!\"");
    }

    public void Attack(Character target) {

        

        if (target._def < _atk) {
            target._hp -= _atk - target._def;
        }

        else if (target._def > _atk) {
            target._def -= 1;
        }
        Console.WriteLine($"{target._hp}");
        Console.WriteLine("A successful hit!");
    }

    public void Defend(Character target){
        if (target._atk > _def) {
            _hp += target._atk - _def;
        }

        else if (target._atk < _def) {
            _hp += _def;
        }
    }

    public int GetHp() {
        return _hp;
    }

    public void Talk(Character target) {
        Console.WriteLine($"Hey, {target._name}! What's up!");
    }

    public void Pickup(Item target) {
        _inventory.Add(target);
    }

}