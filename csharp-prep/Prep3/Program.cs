using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //string userMagicNum = Console.ReadLine();
        //int intMagicNum = int.Parse(userMagicNum);


        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);

        int guess = 0;
        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            

            if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }  while (!(magicNum == guess));


        

        
    }
}