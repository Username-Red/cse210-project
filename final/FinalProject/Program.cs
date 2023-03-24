using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> charInventory = new List<string>();
        Character sebastian = new Character("Sebastian", "Dark Red", 3, 1, 20, charInventory);
        Character lucy = new Character("Lucy", "Black", 3, 2, 20, charInventory);

        sebastian.Introduce();
        sebastian.Talk(lucy);
        sebastian.Attack(lucy);
        lucy.DisplayStats();
    }
}