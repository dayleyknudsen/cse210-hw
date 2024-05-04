using System;

public class Program
{
    public static void Main(string[] args)
    {
        Records Records = new Records();
        Prompt promptGenerator = new Prompt();

        string date = DateTime.Now.ToShortDateString();
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Enter your response:");
        string entryText = Console.ReadLine();

        Record newRecord = new Record(date, prompt, entryText);
        Records.AddEntry(newRecord);
        Records.DisplayAll();
    }
}