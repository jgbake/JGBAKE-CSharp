using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<float> numList = new List<float>();
        bool isOver = false;
        do {
            Console.Write("Enter number: ");
            float currentNum = float.Parse(Console.ReadLine());
            if (currentNum == 0)
            {
                float numSum = 0;
                foreach (float num in numList)
                {
                    numSum += num;
                }
                Console.WriteLine($"The sum is: {numSum}");
                float numAvg = numSum / numList.Count;
                Console.WriteLine($"The average is: {numAvg}");
                Console.WriteLine($"The largest number is: {numList.Max()}");
                isOver = true;
            }
            else
            {
                numList.Add(currentNum);
                isOver = false;
            }
        } while (isOver == false);
    }
}