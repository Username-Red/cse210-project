public class Character {
    // Attributes
    protected string _name;
    private string _color;
    protected int _atk;
    protected int _def;
    protected int _hp;
    protected List<Item> _inventory;

    protected Item _equippedItem;


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
        
        Console.WriteLine($"{_name} lands a successful hit on {target._name}!");
    }

    public void DefendFrom(Character target){
        if (target._atk > _def) {
            _hp += target._atk - _def;
        }

        else if (target._atk < _def) {
            _hp += _def;
        }

        Console.WriteLine($"{_name} has taken a defensive stance against {target._name}!");
    }

    public int GetHp() {
        return _hp;
    }

    public void Talk(Character target) {
        Console.WriteLine($"Hey, {target._name}! What's up!");
    }

    public void Pickup(Item target) {
        _inventory.Add(target);
        Console.WriteLine($"*{target.GetName()} added to {_name}'s inventory.");
    }

    public void Drop(Item target) {

        for (int i = 0; i <= _inventory.Count(); i ++) {
            if (_inventory[i] == target) {
                _inventory.Remove(_inventory[i]);
            }
        }
    }

    public void Equip(Item target) {
        _equippedItem = target;
        Console.WriteLine($"*{_name} equipped {target.GetName()}*");
    }

}