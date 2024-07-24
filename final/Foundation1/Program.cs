using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>{
            new Video("Pagliacci full opera with Placido Domingo as Canio", "Arthur Kondratjev", new TimeSpan(1, 11, 7), new List<Comment>{
                new Comment("@joshuagerthoffer4664", "44:56 we all know you came for it. Be honest."),
                new Comment("@JewishKeto", "Such a sad story.. but such a good opera and one of my favorites"),
                new Comment("@lohengrin1172", "Bonjour, cette interprétation n'a pas pris une ride: tout simplement génial....")}),
            new Video("Reciting The Iliad: my first attempt", "Charlie Hilbert", new TimeSpan(0, 6, 36), new List<Comment>{
                new Comment("@nof9395", "Barabarian sage recites Iliad in PERFECT Greek, local sophists and rhapsodes STUNNED"),
                new Comment("@wickedraptor2651", "Im not gonna lie. Actually reciting the normal/real version and not the english/translated version made me beyond impressed"),
                new Comment("@america-san", "*Looks the part\n   *Does the thing\n   *Doesnt disappoint"),
                new Comment("@marinadeboeck2003", "we found it, the best video in the entirety of internet. shut it all down now, there's nothing else to see")}),
            new Video("How To Read Russian In 9 Minutes (Seriously)", "Life of Yama", new TimeSpan(0, 9, 9), new List<Comment>{
                new Comment("@Lord_cartoon", "Русские настолько суровы, что учат английский по урокам русского XD"),
                new Comment("@AprilOilAB", "“Like the English word, Je m\'appelle.”\n   Guys that’s my favourite English word."),
                new Comment("@bshthrasher", "Letter Щ is close to the initial sound in the word \"shoot\" :)"),
                new Comment("@mihanich", "33 letters is too much!\n   Chinese: allow me to introduce myself"),
                new Comment("@darthzayexeet3653", "A lot of Russian words sound quite similar to Polish words like “dom”, “drzewo” and “miód”")}),
            new Video("Procedural Walking Animation in Minecraft", "Cymaera", new TimeSpan(0, 8, 40), new List<Comment>{
                new Comment("@trevorhaddox6884", "\"Here at Minecraft Dynamics we make the most advanced walking robots in Minecraft.\""),
                new Comment("@Horzinicla", "It's so weird how we immediately feel like something is sentient when it moved a certain way"),
                new Comment("@SlothOfTheSea", "My guy wanted to show a step-by-step process for procedural animation and ended up creating a terrifying abomination. 10/10.")}),
            new Video("The Caretaker's An Empty Bliss Beyond This World", "alteredzones", new TimeSpan(0, 52, 26), new List<Comment>{
                new Comment("@SX1995able", "This is what it feels like when you look through your saved videos on Youtube and it says \"Video removed\" But you don\'t even remember what the video was"),
                new Comment("@brokenblender12", "\"The most merciful thing in the world, I think, is the inability of the human mind to correlate all its contents. We live on a placid island of ignorance in the midst of black seas of the infinity, and it was not meant that we voyage this far\" -H. P. Lovecraft"),
                new Comment("@Bindleton", "It's like sitting at a bar with a bunch of faceless individuals"),
                new Comment("@foolycooly3763", "Woke up from a dream that my father no longer had dementia, we spent days together in my childhood home and I was crying tears of happiness. Toward the end of the dream he had to go \"back home\" and I couldn\'t stop balling my eyes out. Waking up and getting ready for work while this album plays seems fitting today.")})
        };

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"\x1b[1m{video._title}\x1b[0m\nPosted by: {video._author}\nRuntime: {video._videoLength}\n\nComments ({video.GetCommentsAmount()}):");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"\x1b[1m{comment._author} commented:\x1b[0m");
                Console.Write(" - " + Regex.Replace(comment._commentText, @"(.{1," + 64 +@"})(?:\s|$)", "$1\n"));
            }
        }
    }
}