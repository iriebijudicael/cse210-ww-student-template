using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scripturereference = new Reference("2 Nephi", "31", "21");
        Scripture scripture = new Scripture(scripturereference, "And now, behold, my beloved brethren, this is the way; and there is none other way nor name given under heaven whereby man can be saved in the kingdom of God.");
        PassageMemorizer passageMemorizer = new PassageMemorizer (scripture);
        
        string userInput = "";

        while(userInput != "quit" && passageMemorizer.WordLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scripturereference.GetToString(), passageMemorizer.GetToString()));
            Console.WriteLine();
            Console.ReadLine();
            passageMemorizer.hideWordFromList();
        }
    }
}