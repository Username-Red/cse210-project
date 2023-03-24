public class Weapon : Item {
    // Attributes
    public int _atkBoost;

    // Constructors 
    public Weapon(string name, string desc, int atkBoost) : base(name, desc) {
        _atkBoost = atkBoost;

    }

    // Methods
    public void GiveAttackBoost(Character target) {
        // code here
    }
}