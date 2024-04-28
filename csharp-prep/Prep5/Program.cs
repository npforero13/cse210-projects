using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favNumber);

        DisplatResult(userName, squareNumber);



        static void DisplayWelcome()
        {
            Console.WriteLine ("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("what is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;

        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
        static void DisplatResult(string name, int number)
        {
            Console.WriteLine(name + ", the square of your number is " + number);
        }

    }
}