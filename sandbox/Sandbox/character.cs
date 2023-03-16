public class Character {
    // Attributes
    protected string _name;
    protected int _age;

    // Constructors 
    public Character(string name, int age) {
        _name = name;
        _age = age;
    }

    // Methods
    public virtual void Introduce() {
        Console.WriteLine($"Hi! My name is {_name}, and I am {_age} years old!");
    }
}