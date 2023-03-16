using System;

class Program
{
    static void Main(string[] args)
    {
        Character red = new Character("Red", 19);
        Player stephen = new Player("Stephen", 35, "Fountain of Youth");
        Enemy ogre = new Enemy("Urgburt", 23879, "RED");

        red.Introduce();

        stephen.Introduce();
        stephen.SPAttack();

        ogre.Introduce();
        ogre.DisplayEyeCol();



    }
}