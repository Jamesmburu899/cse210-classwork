using System;

class Program
{
    static void Main(string[] args)
    {
        // Load a scripture (example: Proverbs 3:5-6)
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            // Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt the user
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            // Exit if the user types "quit"
            if (input.ToLower() == "quit")
                break;

            // Hide 3 random words
            scripture.HideRandomWords(3);

            // End the program if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program will now end.");
                break;
            }
        }
    }
}