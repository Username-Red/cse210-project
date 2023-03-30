public class Text {
    // attributes

    // constructors
    public Text() {}

    // methods

    public string Print(string text, string color) {
        color = char.ToUpper(color[0]) + color.Substring(1);
        if (color == "Red") {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (color == "Blue") {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (color == "Green") {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (color == "White") {
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (color == "DarkRed") {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        else if (color == "DarkBlue") {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        else if (color == "DarkGreen") {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        else if (color == "DarkMagenta") {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        else if (color == "DarkCyan") {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        else if (color == "DarkYellow") {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        else if (color == "Cyan") {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        else if (color == "Magenta") {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        else if (color == "Yellow") {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }


        Console.WriteLine(text);
        string input = Console.ReadLine();

        return input;
    }

    public string Puts(string text) {
        Console.WriteLine(text);
        string input = Console.ReadLine();
        return input;
    }

    public void Say(string text, string color) {
        color = char.ToUpper(color[0]) + color.Substring(1);
        if (color == "Red") {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (color == "Blue") {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (color == "Green") {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (color == "White") {
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (color == "DarkRed") {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        else if (color == "DarkBlue") {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        else if (color == "DarkGreen") {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        else if (color == "DarkMagenta") {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        else if (color == "DarkCyan") {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        else if (color == "DarkYellow") {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        else if (color == "Cyan") {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        else if (color == "Magenta") {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        else if (color == "Yellow") {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }


        Console.WriteLine(text);
        
    }
}