using System;

class Program
{
    static void Main(string[] args)
    {
        List<Item> charInventory = new List<Item>();
        Character sebastian = new Character("Sebastian", "Dark Red", 3, 1, 20, charInventory);
        NPC lucy = new NPC("Lucy", "Black", 3, 2, 20, charInventory, 0);
        Item flower = new Item("Water Lilly", "A beautiful blue Water Lilly commonly found near the Wendigo Lakeside");

        lucy.Pickup(flower);
        sebastian.Pickup(flower);
        sebastian.Introduce();
        sebastian.Talk(lucy);
        sebastian.Attack(lucy);
        lucy.DisplayStats();
    }
}