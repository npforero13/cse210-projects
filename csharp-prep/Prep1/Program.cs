using System;

class Program
{
    static void Main(string[] args)
    {
        //ask user for first name
        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();
        //ask user for last name
        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();
        //write users name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }

}