using System;

class Program
{
    static void Main(string[] args)
    {
        List<Item> charInventory = new List<Item>();
        NPC mama = new NPC("Mama", "White", 10, 15, 40, charInventory, 10);
        Misc flower = new Misc("Water Lilly", "A beautiful blue Water Lilly commonly found near the Wendigo Lakeside", 1);
        Misc ore = new Misc("Iron Ore", "A shiny piece of iron ore commonly found near the base of Curiosity Peaks", 2);
        Misc crystal = new Misc("Purple Crystal", "A strange purple crystal found growing in a tree. I'm sure it's not very important... Right?", 0);
        Shield shield = new Shield("Shield", "A beatiful shield matching your own colours. You can Bind certain items to it for boosts!", 2);
        Text text = new Text();
        bool battling = false;
        bool playerTurn = true;
        string[] combatOptions = {"Attack", "Defend", "Special Attack"};

        // Player starts creating their character

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        string name =  text.Puts("Hello there, new friend. What is your name? :");
        name = char.ToUpper(name[0]) + name.Substring(1);
        string uppername = "";

        foreach (char letter in name) {
            char upperletter = char.ToUpper(letter);
            uppername = uppername + upperletter;
        }

        Console.WriteLine("Very interesting... What is your favourite color?: ");
        string color = Console.ReadLine();

        Player user = new Player(name, color, 5, 2, 20, charInventory);

        
        Console.WriteLine($"Well {name}, welcome to the Imaginary Island. Don't be alarmed, you will be in good hands. Until we meet again...");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

        // Enter the world

        text.Print($"\"{name}? {name}... WAKE UP!\"\n(Hit enter to continue)", "Magenta");

        text.Print("*The figure above you gives you a VIGOROUS shake.", color);
        text.Puts("\"OKAY OKAY OKAY I'M UP\" You say as you push yourself up out of the warm sheets of the bed.");
        
        text.Print($"\"{uppername}, THANK GOODNESS YOU'RE AWAKE\"\n\"You fell from that huge tree you always climb, I was worried ya know,\"", "Magenta");
        
        text.Print($"*You recognize the kind face staring down at you as your friend... ", color);
        string friendName = text.Puts("Wait... What was her name again? (What is your friend's name?): ");
        
        friendName = char.ToUpper(friendName[0]) + friendName.Substring(1);
        NPC doodle = new NPC(friendName, "Red", 3, 2, 20, charInventory, 5);

        text.Print($"\"Well,\" {friendName} says as she straightens up, \"Mama says we should bring you to the combat arena to make sure you're all clear,\"", "Magenta");
        string choice = text.Print($"(what will yo do?) \n  1. Stay in bed \n  2. Follow {friendName} to the combat arena", "Cyan");
        

        // get to combat arena

        if (choice == "1") {
            text.Print("\"You wanna stay in bed? TOO BAD WE'RE GOING TO THE COMBAT ARENA\" She pulls you ROUGHLY out of bed and almost DRAGS you to the combat arena.","Magenta");
        }

        else if (choice == "2") {
            text.Print($"\"That's the spirit, {name}!\"", "Magenta");
            doodle.AddFriendLv(2);
        }

        text.Print("*As the pair of you enter the great walls of the combat arena, you are filled with a feelng of memories of the past. \nYou have been here before.", "Cyan");

        text.Print($"\"Hey, {name}! Catch!\" You look to where the noise came from and instinctively put your hand out to grab the thing flying at you.", "DarkRed");
       
        text.Puts("\"Whaddya think?\" Says the dark red indivdual who threw the thing at you, \"We heard about your accident and decided \nto get your shield in good shape. Is it good?\"");

        text.Print($"*Huh? Shield? As you look down to inspect what you had caught, you see a wonderful {color} shield. After a second of consideration, \nyou remember that this is the same shield that you have had for years, but it looks brand new now.", color);
        user.Equip(shield);

        text.Print($"\"Okay okay enough dilly dally, we gotta check that you're firing on all cylinders, remember?\" {friendName} says as she fastens her own shield to her arm.", "Magenta");

        text.Print("Fighters ready?", "Red");
        text.Puts("Fight!");
        // start combat tutorial
        battling = true;
        
        while (battling) {

            Console.ResetColor();

            int opponentHP = doodle.GetHp();
            int playerHP = user.GetHp();

            Console.WriteLine($"{friendName} HP: {opponentHP} \n{name} HP: {playerHP}");

            if (playerTurn) {
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
                    user.DefendFrom(doodle);
                }

                else if (choice == "3") {
                    // special attack code
                }

                else {
                    Console.WriteLine("I'm sorry, that is not a registered command.");
                }

                playerTurn = false;
            }

            else if (!playerTurn) {
                if (playerHP <= 5) {
                    text.Say($"Come on, wake up {name}!", "Magenta");
                }

                else if (playerHP > 5) {
                    doodle.Attack(user);
                }

                else if (opponentHP < 5) {
                    doodle.DefendFrom(user);
                }

                playerTurn = true;
            }

            if (playerHP <= 0) {
                Console.WriteLine("Game Over");
                battling = false;
                
            }

            else if (opponentHP <= 0) {
                Console.WriteLine("Victory! Fight over");
                battling = false;
            }
            
        }


        // complete combat tutorial

        text.Print("Okay, you're all clear. Go find something to put on your shield in the eternal Woods!", "Magenta");
        // explore Eternal Woods

        text.Print($"*{friendName} gives you a playful shove in the direction of the Eternal Woods.", "Cyan");
        text.Puts("*As you pass into the thicket of trees and bushes, it is as if the outside noise begins to vanish entirely.");
        text.Puts("*You are filled with Determination.");

        choice = text.Puts("Where will you go? \n(Left/Right)");
        choice = char.ToUpper(choice[0]) + choice.Substring(1);

        if (choice == "Left") {
            text.Print("*The sound of running water beckons you to go left.", color);
            text.Puts("It is not long before you find a beautful water lilly floating close to the lakeside.");
            text.Puts($"You gently pick it up. The second your hand grasps its petals, you know that his is the item {friendName} told you about.");
            text.Puts("You place the flower on your shield, and it immediately attaches itself. You have done well.");
            shield.Bind(flower);
        }

        else if (choice == "Right") {
            text.Print("The wind gently tugs at your hand, coaxing you to the right.", color);
            text.Puts("It is not long before you stumble upon a piece of iron ore laying near the base of the great mountain.");
            text.Puts($"You lift the small piece of ore into your palm, and as you feel its weight in your hand, you know this is the item {friendName} was talking about.");
            text.Puts("You place the ore on your shiled, and it immediately adhears itself. You have done well.");
            shield.Bind(ore);
        }

        else {
            Misc leaf = new Misc("Leaf", "It's a leaf. Not much to say. Probably fell from like a tree or something.", 0);
            text.Print("You begin wondering aimlessly between the trees because that you did not shoose either Right or Left.", color);
            text.Puts($"A leaf falls on your head. You pick it off of your ear and lay it in your hand. This must be what {friendName} was talking about!");
            text.Puts("You place the leaf on your shield. It sticks. Kinda.");
            shield.Bind(leaf);
        }

        // find badguy

        text.Print($"\"You take such things as if they are yours, oh strange one with face of {color}.\"", "DarkMagenta");
        text.Puts("For this, you shall be punished!");

        text.Print("*A strange creature attacks you!", "Cyan");
        Enemy badguy = new Enemy("Aleister", "Purple", 2, 2, 25, charInventory, 10);


        battling = true;
        
        while (battling) {

            Console.ResetColor();

            int opponentHP = badguy.GetHp();
            int playerHP = user.GetHp();

            Console.WriteLine($"Aleister HP: {opponentHP} \n{name} HP: {playerHP}");

            if (playerTurn) {
                for (int i = 0; i < combatOptions.Count(); i ++) {
                    Console.WriteLine($"{i + 1}.  {combatOptions[i]}");
                }

                choice = Console.ReadLine();

                if (choice == "1") {
                    // attack code
                    user.Attack(badguy);
                }

                else if (choice == "2") {
                    // defend code
                    user.DefendFrom(badguy);
                }

                else if (choice == "3") {
                    // special attack code
                }

                else {
                    Console.WriteLine("I'm sorry, that is not a registered command.");
                }

                playerTurn = false;
            }

            else if (!playerTurn) {
                if (playerHP <= 5) {
                    text.Say($"Fight back oh cowardly one with face of {color}!", "DarkMagenta");
                }

                else if (playerHP > 5) {
                    badguy.Attack(user);
                }

                else if (opponentHP < 5) {
                    badguy.DefendFrom(user);
                }

                playerTurn = true;
            }

            if (playerHP <= 0) {
                Console.WriteLine("Game Over");
                battling = false;
                
            }

            else if (opponentHP <= 0) {
                Console.WriteLine("Victory! Fight over");
                battling = false;
            }
            
        }

        // defeat badguy

        text.Print("*The enemy scurries away, and in it's haste, it drops it's bag.", "Cyan");
        text.Puts("As you open the flap, a great purple light eminates from the bag. Perhaps some kind of Light Stone?");
        text.Puts("Mama will probably know what it is! You put it in your bag and start heading back toward the village.");
        
        // find weird crystal thing
        user.Pickup(crystal);

        // give weird crystal thing to village elder
        text.Print("*You burst ot of the eternal woods, rush past the great combat arena, fly through the village and almost way overshoot Mama's hut.", color);
        text.Puts("\"MAMA I FOUND SOMETHING\" You call as you rush into the large enclosure of Mama's hut.");

        text.Print("A beautiful individual adorned with white and gold turns to you.", "Cyan");
        text.Puts($"\"Hmm?\" She hums as she strides towards you, \"What is it, my small {color} friend?\"");

        text.Print("*You explain what happened in the Eternal Woods and show Mama the purple crystal", color);

        text.Print("\"Hmmmm... Indeed\"", "Cyan");
        text.Puts("\"I will keep it here, if I may. I wish to study it, I have no memory of any item like it.\" She says, holding out her hands.");
        choice = text.Print("    \"1. Here you go\" \n    \"2. No, I will keep this crystal in my own hut\"", color);

        if (choice == "1") {
            text.Print($"Thank you, {name}", "Cyan");
            user.Drop(crystal);
            mama.Pickup(crystal);
        }
        else if (choice == "2") {
            text.Print("Ah, very well. Be careful though, {name}. I know nothing of this strange rock.", "Cyan");
        }

        else {
            
        }
        
        // roll credits

    }
}