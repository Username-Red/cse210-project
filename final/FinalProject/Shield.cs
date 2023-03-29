public class Shield : Item {
    // Attributes
    public int _defBoost;
    public List<Item> _boundItems;

    // Constructors 
    public Shield(string name, string desc, int defBoost) : base(name, desc) {
        _defBoost = defBoost;

    }

    // Methods

    public void Bind(Item misc) {
        _boundItems.Add(misc);
    }

    public void GiveDefBoost(Character target) {
        // Code here
    }  
}