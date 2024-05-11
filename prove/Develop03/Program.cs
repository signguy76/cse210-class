using System;

public class Program
{
    public static void Main(string[] args)
    {
        var reference = new ScriptureReference("John", 3, 16);
        var scriptureText = "For God so loved the world that he gave his only begotten Son, that whoever believeth in him shall not perish but have everlasting life.";
        var scripture = new Scripture(reference, scriptureText);

        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine();
        Console.WriteLine("Above is a scripture for you to memorize.\nTo help, each time you press 'Enter', one word will be hidden.");
        Console.WriteLine("");

        Console.WriteLine("Press Enter to hide a word, or type 'quit' to exit.");


        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words in scripture are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture);
        }
    }
}
