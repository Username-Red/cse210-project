
public class randomPrompt {
    //member variables
    Random rd = new Random();

    string[] prompts = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What is something that happened today that I am grateful for?"};





    //call class
    public randomPrompt() {}


    //methods

    public void Display() {

        int randomNum = rd.Next(0, 6);
        Console.WriteLine(prompts[randomNum]);
    }
}