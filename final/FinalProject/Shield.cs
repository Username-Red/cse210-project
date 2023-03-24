public class Shield : Item {
    // Attributes
    public int _defBoost;

    // Constructors 
    public Shield(string name, string desc, int defBoost) : base(name, desc) {
        _defBoost = defBoost;

    }

    // Methods

    public void Bind(Item misc) {
        // code here
    }

    public void GiveDefBoost(Character target) {
        // Code here
    }  
}