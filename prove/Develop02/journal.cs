using System.IO;

public class Journal {

     

    //member variables
    public List<string> prompts = new List<string>();

    public List<string> pages = new List<string>();

    public string _filename = ""; 

    public List<string> dates = new List<string>();


    //call class
    public Journal(){}

    //methods

    public void DisplayEntries(){
        for (int i = 0; i <= pages.Count() - 1; i++) {
            Console.Write($"\nDate: {dates[i]} - ");
            Console.WriteLine($"Prompt: {prompts[i]}");
            Console.WriteLine($"{pages[i]}");
        }
    }

    public void Save(){
        Console.Write("What .txt file would you like to save these entries to?: ");
        _filename = Console.ReadLine();
        Console.WriteLine();

        using (StreamWriter journalContent = new StreamWriter(_filename)) {

            for(int i = 0; i <= pages.Count() - 1; i++){
                journalContent.Write(dates[i]);
                journalContent.Write("|");
                journalContent.Write(prompts[i]);
                journalContent.Write("|");
                journalContent.WriteLine(pages[i]);

            }

        }

        
    }

    public void Load(){
        Console.Write("Please enter the name of the .txt file you would like to load: ");
        _filename = Console.ReadLine();
        string[] content = System.IO.File.ReadAllLines(_filename);

        foreach (string line in content){
            string[] parts = line.Split("|");

            string loadDate = parts[0];
            string loadPrompt = parts[1];
            string loadContent = parts[2];

            dates.Add(loadDate);
            prompts.Add(loadPrompt);
            pages.Add(loadContent);
        }


    }

}