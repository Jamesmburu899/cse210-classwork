using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice;

        do
        {
            Console.Clear();
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Please select an option (1-5): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal);
                    break;
                case "2":
                    journal.DisplayEntries();
                    Pause();
                    break;
                case "3":
                    SaveJournal(journal);
                    break;
                case "4":
                    LoadJournal(journal);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Pause();
                    break;
            }
        } while (choice != "5");
    }

    static void WriteNewEntry(Journal journal)
    {
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        Entry newEntry = new Entry(prompt, response);
        journal.AddEntry(newEntry);
        Console.WriteLine("Entry added successfully!\n");
        Pause();
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Pause();
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename to load journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
