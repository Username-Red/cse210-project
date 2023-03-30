public class Item {
    // Attributes
    public string _name;
    protected string _description;

    // Constructors
    public Item(string name, string desc) {
        _name = name;
        _description = desc;
    }

    public Item(string line) {
    }

    // Methods
    public void Equip(Character target) {
        // Code Here
    }

    public virtual void DisplayInfo() {
        Console.WriteLine($"    Item: {_name} \n    Description: {_description}");
    }
}