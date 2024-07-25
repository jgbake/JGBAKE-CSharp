using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Lecture someLecture = new Lecture(
            "Jonah Timothy",
            320,
            "On The Meaning of \"Happiness\"",
            "Jonah Timothy will give a lecture on the meaning of happiness, how it relates to our lives, along with many ways to increase happiness not only for ourselves but for others too.",
            "9/25/2031",
            "2:30 PM",
            new Address(
                "1072 East Mount Street",
                "Torrey",
                "NC",
                "27529",
                "USA"));
        
        Console.WriteLine("\n\x1b[1m------------------------------------------------\x1b[0m");
        someLecture.ShortDescription();
        Console.WriteLine("--------------------------------");
        someLecture.StandardDetails();
        Console.WriteLine("--------------------------------");
        someLecture.DisplayFullDetails();


        Reception someReception = new Reception(
            "wedding.joeyandjayla.com",
            "Joey and Jayla's Wedding Reception",
            "We are holding a wedding reception! We will be getting married the day before and want to celebrate with everyone! Please register as there's limited space in the venue!",
            "3/30/2029",
            "6:30 PM",
            new Address(
                "764 Blue Spring Street",
                "Ridgefield",
                "CT",
                "60877",
                "USA"));
        
        Console.WriteLine("\n\x1b[1m------------------------------------------------\x1b[0m");
        someReception.ShortDescription();
        Console.WriteLine("--------------------------------");
        someReception.StandardDetails();
        Console.WriteLine("--------------------------------");
        someReception.DisplayFullDetails();


        Gathering someGathering = new Gathering(
            "Sunny with a few clounds",
            "Mormont Family Reunion",
            "Welcome one and all! Our annual family reunion is coming up quickly! Tell all the family members you have contact with to come! We'll be grilling and will have all sorts of games so come hungry and bored!",
            "6/12/2033",
            "10:00 AM",
            new Address(
                "764 Blue Spring Street",
                "Ridgefield",
                "CT",
                "60877",
                "USA"));
        
        Console.WriteLine("\n\x1b[1m------------------------------------------------\x1b[0m");
        someGathering.ShortDescription();
        Console.WriteLine("--------------------------------");
        someGathering.StandardDetails();
        Console.WriteLine("--------------------------------");
        someGathering.DisplayFullDetails();
        Console.WriteLine("\x1b[1m------------------------------------------------\x1b[0m");
    }
}