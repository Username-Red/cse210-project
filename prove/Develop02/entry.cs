
public class Entry{
    //attributes 

    Random _rd = new Random();
    public string entry = "";
    public string[] prompts = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What is something that happened today that I am grateful for?"};
    public string prompt = "";
    public string date = "";

    public Entry(){}

    //methods
    public void WriteEntry(){
        Console.Write("> ");
        entry = Console.ReadLine();

    }

    public void GivePrompt(){
        int randomNum = _rd.Next(0, 6);
        prompt = prompts[randomNum];

        Console.WriteLine($"\n> {prompt}");
    }

}