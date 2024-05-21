using System;

class Program
{
    static void Main(string[] args)
    {
        Reference refJohn = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(refJohn, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        while (!scripture.IsFullyHidden)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            scripture.HideWords();
        }
    }
}