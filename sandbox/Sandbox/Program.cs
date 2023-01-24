using System;

class Program
{
    static void Main(string[] args)
    {
        Random rd = new Random();

        int rand_num = rd.Next(100,200);

        Console.WriteLine(rand_num);
    }
}