using System;

class Program
{
    static void Main(string[] args)
    {
        List<Item> charInventory = new List<Item>();
        Character sebastian = new Character("Sebastian", "Dark Red", 3, 1, 20, charInventory);
        NPC lucy = new NPC("Lucy", "Black", 3, 2, 20, charInventory, 0);
        
        Item flower = new Item("Water Lilly", "A beautiful blue Water Lilly commonly found near the Wendigo Lakeside");

        // Player starts creating their character

        Console.WriteLine("Hello there, new friend. What is your name? :");
        string name = Console.ReadLine();
        name = char.ToUpper(name[0]) + name.Substring(1);
        string uppername = "";

        foreach (char letter in name) {
            char upperletter = char.ToUpper(letter);
            uppername = uppername + upperletter;
        }

        Console.WriteLine("Very interesting... What is your favourite color?: ");
        string color = Console.ReadLine();

        Player user = new Player(name, color, 2, 2, 20, charInventory);

        Console.WriteLine($"Well {name}, welcome to the Imaginary Island. Don't be alarmed, you will be in good hands. Until we meet again...");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

        // Enter the world

        Console.WriteLine($"\"{name}? {name}... WAKE UP!\"\n(Hit enter to continue)");
        Console.ReadLine();
        Console.WriteLine("*The figure above you shakes you VIGOROUSLY to wake you up.");
        Console.ReadLine();
        Console.WriteLine("\"OKAY OKAY OKAY I'M UP\" Yousay as you push yourself up off the ground");
        Console.ReadLine();
        Console.WriteLine($"\"{uppername} THANK GOODNESS YOU'RE AWAKE\"\n\"You fell from that huge tree you always climb, I was worried ya know,\"");
        Console.ReadLine();
        Console.WriteLine($"*You recognize the kind face staring down at you as your friend... ");
        Console.WriteLine("Wait... What was her name again? (What is your friend's name?): ");
        string friendName = Console.ReadLine();
        friendName = char.ToUpper(friendName[0]) + friendName.Substring(1);


        NPC doodle = new NPC(friendName, "Red", 3, 2, 20, charInventory, 5);

        Console.WriteLine($"\"Well then, let's get you back to the village to make sure youre all clear\" {friendName} says as she hoists you up and supports you as you make your way to the village.");
        

    }
}