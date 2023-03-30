public class Shield : Item {
    // Attributes
    protected int _defBoost;
    protected List<Item> _boundItems = new List<Item>();

    // Constructors 
    public Shield(string name, string desc, int defBoost) : base(name, desc) {
        _defBoost = defBoost;

    }

    // Methods

    public void Bind(Item misc) {
        _boundItems.Add(misc);
        Console.WriteLine($"*{misc.GetName()} has been bound to the Shield*");
    }

    public int GiveDefBoost() {
        return _defBoost;
    }  

    public override void DisplayInfo() {
        Console.WriteLine($"    Item: {_name} \n    Description: {_description}\n    Def Boost: {_defBoost}");
    }
}