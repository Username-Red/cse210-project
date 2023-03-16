public class Player : Character {
    // Attributes
    private string _spAttack;

    // Constructors
    public Player(string name, int age, string spAttack) : base (name, age) {
        _spAttack = spAttack;
    }


    // Methods
    public void SPAttack() {
        Console.WriteLine($"AAAHHHHHHHHHH! SPECIAL ATTACK GOOOO! {_spAttack}!");
    }

    public override void Introduce()
    {
        Console.WriteLine($"Hi! My name is {_name}, and I am {_age} years old! Also, I am the hero of this story!");
    }

}