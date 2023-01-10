using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int user_num = -1;

        while (user_num != 0){
            Console.WriteLine("Enter a number:");
            string user_response = Console.ReadLine();

            user_num = int.Parse(user_response);

            if (user_num != 0) {
                numbers.Add(user_num);
            }

            else if (user_num == 0) {
                break;
            }
        }
        
        for (int item = 0; item < numbers.Count; item++) {
            Console.WriteLine(numbers[item]);
        }

        int sum = 0;
        foreach (int item in numbers) {
            sum += item;
        }

        Console.WriteLine($"The sum of those numbers is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = 0;

        foreach (int number in numbers) {
            if (number > max) {
                max = number;
            }
        }

        Console.WriteLine($"The highest number is {max}");


    }
}