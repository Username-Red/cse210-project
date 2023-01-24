using System.IO;

public class Journal {

     

    //member variables
    Random _rd = new Random();
    string[] prompts = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What is something that happened today that I am grateful for?"};

    public List<string> pages = new List<string>();
    public string _entry = "";
    public string _filename = ""; 
    public string _prompt = "*";


    //call class
    public Journal(){}

    //methods
    public void AddEntry(){

        // display _prompt
        int randomNum = _rd.Next(0, 6);
        _prompt = (prompts[randomNum]);
        Console.WriteLine(_prompt);

        // Allow user to write their entry
        Console.Write(": ");
        _entry = Console.ReadLine();
        
        // Get the date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString(); 

        // Add all information to the pages list
        pages.Add("Date: " + dateText + " - Prompt: " + _prompt + "\n" + _entry);
    }

    public void DisplayEntries(){
        foreach (string page in pages) {
            Console.WriteLine(page);
        }
    }

    public void Save(){
        Console.Write("What file would you like to save these entries to?: ");
        _filename = Console.ReadLine();
        Console.WriteLine();

        using (StreamWriter journalContent = new StreamWriter(_filename)) {

            foreach (string page in pages) {
                journalContent.WriteLine(page);
            }

        }

        
    }

    public void Load(){
        Console.Write("Please enter the name of the file you would like to load: ");
        _filename = Console.ReadLine();
        string[] content = System.IO.File.ReadAllLines(_filename);

        foreach (string page in content) {
            pages.Add(page);

        }


    }

}