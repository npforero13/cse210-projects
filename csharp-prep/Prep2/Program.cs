using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);

        string letterGrade = "";

        if (number >= 90)
        {
             letterGrade = "A";
        }
        else if (number >= 80)
        {
            letterGrade = "B";
        }
        else if (number >= 70)
        {
            letterGrade = "C";
        }
        else if (number >= 60)
        {
            letterGrade = "D";
        }
        else if (number < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine("Your grade is " + letterGrade);

        if (letterGrade != "F")
        {
            Console.WriteLine("You passed bro.");
        }
        else
        {
            Console.WriteLine("You failed bro.");
        }

    }

    
}