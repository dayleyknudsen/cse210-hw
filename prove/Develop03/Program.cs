using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
    Console.WriteLine("Choose a scripture to display:");
    Console.WriteLine("1. John 3:16");
    Console.WriteLine("2. Psalm 30:1-3");

    Console.Write("Enter your choice (1 or 2): ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        // Display the scripture for John 3:16
        Scripture john316 = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        DisplayScripture(john316);
    }
    else if (choice == "2")
    {
        // Display the scripture for Psalm 30:1-2
        Scripture psalm3013 = new Scripture("Psalm", 30, 1, 2, "O Lord my God, I cried unto thee, and thou hast healed me. 2 O Lord, thou hast brought up my soul from the grave: thou hast kept me alive, that I should not go down to the pit.");
        DisplayScripture(psalm3013);
    }
    else
    {
        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
    }
}
public static void DisplayScripture(Scripture scripture)
{
    // Complete scripture
    Console.WriteLine(scripture.GetDisplayText());

    // Prompt the user to continue
    Console.WriteLine("Press Enter to hide a few words or type 'quit' to exit.");
    string input = Console.ReadLine();

    // Continue hiding words until user types 'quit'
    while (input != "quit" && !scripture.IsCompletelyHidden())
    {
        scripture.HideRandomWords();
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press Enter to hide a few words or type 'quit' to exit.");
        input = Console.ReadLine();
    }
}
}