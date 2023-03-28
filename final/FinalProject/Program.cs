using System;

class Program
{
    static void Main(string[] args)
    {
        List<Item> charInventory = new List<Item>();
        Character sebastian = new Character("Sebastian", "Dark Red", 3, 1, 20, charInventory);
        NPC lucy = new NPC("Lucy", "Black", 3, 2, 20, charInventory, 0);
        
        Item flower = new Item("Water Lilly", "A beautiful blue Water Lilly commonly found near the Wendigo Lakeside");


        bool battling = false;
        string[] combatOptions = {"Attack", "Defend", "Special Attack"};
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

        Player user = new Player(name, color, 4, 2, 20, charInventory);

        Console.WriteLine($"Well {name}, welcome to the Imaginary Island. Don't be alarmed, you will be in good hands. Until we meet again...");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

        // Enter the world

        Console.WriteLine($"\"{name}? {name}... WAKE UP!\"\n(Hit enter to continue)");
        Console.ReadLine();
        Console.WriteLine("*The figure above you gives you a VIGOROUS shake.");
        Console.ReadLine();
        Console.WriteLine("\"OKAY OKAY OKAY I'M UP\" You say as you push yourself up out of the warm sheets of the bed.");
        Console.ReadLine();
        Console.WriteLine($"\"{uppername}, THANK GOODNESS YOU'RE AWAKE\"\n\"You fell from that huge tree you always climb, I was worried ya know,\"");
        Console.ReadLine();
        Console.WriteLine($"*You recognize the kind face staring down at you as your friend... ");
        Console.WriteLine("Wait... What was her name again? (What is your friend's name?): ");
        string friendName = Console.ReadLine();
        friendName = char.ToUpper(friendName[0]) + friendName.Substring(1);


        NPC doodle = new NPC(friendName, "Red", 3, 2, 20, charInventory, 5);

        Console.WriteLine($"\"Well,\" {friendName} says as she straightens up, \"Mama says we should bring you to the combat arena to make sure you're all clear,\"");
        Console.ReadLine();
        Console.WriteLine($"(what will yo do?) \n  1. Stay in bed \n  2. Follow {friendName} to the combat arena");
        string choice = Console.ReadLine();

        // get to combat arena

        if (choice == "1") {
            Console.WriteLine("\"You wanna stay in bed? TOO BAD WE'RE GOING TO THE COMBAT ARENA\" She pulls you ROUGHLY out of bed and almost DRAGS you to the combat arena.");

        }

        else if (choice == "2") {
            Console.WriteLine($"\"That's the spirit, {name}!\"");
            doodle.AddFriendLv(2);
        }
        Console.ReadLine();
        Console.WriteLine("*As the pair of you enter the great walls of the combat arena, you are filled with a feelng of memories of the past. You have been here before.");
        Console.ReadLine();
        Console.WriteLine($"\"Hey, {name}! Catch!\" You look to where the noise came from and instinctively put your hand out to grab the thing flying at you.");
        Console.ReadLine();
        Console.WriteLine("\"Whaddya think?\" Says the dark red indivdual who threw the thing at you, \"We heard about your accident and decided \nto get your shield in good shape. Is it good?\"");
        Console.ReadLine();
        Console.WriteLine($"*Huh? Shield? As you look down to inspect what you had caught, you see a wonderful {color} shield. After a second of consideration, \nyou remember that this is the same shield that you have had for years, but it looks brand new now.");  
        Console.ReadLine();

        Console.WriteLine($"\"Okay okay enough dilly dally, we gotta check that you're firing on all cylinders, remember?\" {friendName} says as she fastens her own shield to her arm.");
        Console.ReadLine();


        // start combat tutorial


        battling = true;
        while (battling) {

            int opponentHP = doodle.GetHp();
            int playerHP = user.GetHp();

            if (playerHP > 0) {
                for (int i = 0; i < combatOptions.Count(); i ++) {
                Console.WriteLine($"{i + 1}.  {combatOptions[i]}");
                }

                choice = Console.ReadLine();

                if (choice == "1") {
                    // attack code
                    user.Attack(doodle);
                }

                else if (choice == "2") {
                    // defend code
                    user.Defend(doodle);
                }

                else if (choice == "3") {
                    // special attack code
                }

                else {
                    Console.WriteLine("I'm sorry, that is not a registered command.");
                }
            }

            if (playerHP <= 0) {
                Console.WriteLine("Game Over");
                battling = false;
            }

            else if (opponentHP <= 0) {
                Console.WriteLine("VIctory! Fight over");
                battling = false;
            }
            
        }


        // complete combat tutorial

        Console.WriteLine("Okay, you're all clear. Go find something to put on your shield in the eternal Woods!");
        // explore Eternal Woods
        // find something to add to your inventory
        user.Pickup(flower);
        // find badguy
        Enemy badguy = new Enemy("Aleister", "Purple", 2, 2, 25, charInventory, 10);
        // defeat badguy
        // find weird crystal thing

        // give weird crystal thing to village elder
        // roll credits

    }
}