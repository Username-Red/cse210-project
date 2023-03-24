public class Player : Character {
    // Attributes
    private int _exp;
    private int _lvUpWall;

    // Constructors
    public Player(string name, string color, int atk, int def, int hp, List<string> inventory) 
    : base(name, color, atk, def, hp, inventory) {}

    // Methods
    public override void DisplayStats()
    {
        // Code Here
    }
}