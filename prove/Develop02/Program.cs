using System;
using System.Collections.Generic;

public class Program
{
    static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Add a new prompt");
            Console.WriteLine("6. Remove an existing prompt");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal(journal);
                    break;
                case "4":
                    LoadJournal(journal);
                    break;
                case "5":
                    AddPrompt();
                    break;
                case "6":
                    RemovePrompt();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        journal.AddEntry(new Entry(prompt, response));
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved.");
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
    }

    static void AddPrompt()
    {
        Console.Write("Enter the new prompt text: ");
        string text = Console.ReadLine();
        prompts.Add(text);
        Console.WriteLine("Prompt added.");
    }

    static void RemovePrompt()
    {
        Console.WriteLine("Select the prompt to remove:");
        for (int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }
        Console.Write("Enter the number of the prompt to remove: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= prompts.Count)
        {
            prompts.RemoveAt(index - 1);
            Console.WriteLine("Prompt removed.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}
