using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new Random();
        int magicNumber = randomGen.Next(1,100);
        bool isRight;

        do {
            Console.Write("What is your guess? ");
            int numGuess = int.Parse(Console.ReadLine());
            if (numGuess == magicNumber)
            {
                Console.WriteLine("You Got It!");
                isRight = true;

            }
            else if (numGuess > magicNumber)
            {
                Console.WriteLine("Lower!");
                isRight = false;
            }
            else if (numGuess < magicNumber)
            {
                Console.WriteLine("Higher!");
                isRight = false;
            }
            else
            {
                Console.WriteLine("Something weird happened...");
                isRight = true;
            }} while (isRight == false);
    }
}