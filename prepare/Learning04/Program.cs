using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignTest = new Assignment("Jonathan Barnet", "Quantum Mechanics");
        Console.WriteLine(assignTest.GetSummary());

        MathAssignment mathAssignTest = new MathAssignment("Test Name", "Some Topic", "8.9", "31-77");
        Console.WriteLine($"\n{mathAssignTest.GetSummary()}");
        Console.WriteLine(mathAssignTest.GetHomeworkList());

        WritingAssignment writeAssignTest = new WritingAssignment("Write Test", "Some Writing Topic", "Some Cool Paper Title");
        Console.WriteLine($"\n{writeAssignTest.GetSummary()}");
        Console.WriteLine(writeAssignTest.GetWritingInformation());
    }
}