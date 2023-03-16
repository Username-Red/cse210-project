public class Enemy : Character {
    // Attributes
    private string _eyeCol;

    // Constructors
    public Enemy(string name, int age, string eyeCol) : base(name, age) {
        _eyeCol = eyeCol;
    }

    // Methods
    public void DisplayEyeCol() {
        Console.WriteLine($"I am a villain! I have {_eyeCol} eyes!");
    }

    public override void Introduce()
    {
        Console.WriteLine($"Hi! My name is {_name}, and I am {_age} years old! Also, I am the badguy of this story!");
    }

}