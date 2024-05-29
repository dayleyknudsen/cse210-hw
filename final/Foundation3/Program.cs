using System;

class Program
{
    static void Main(string[] args)
    {
        var lecture = new Lecture(
            "C# Fundamentals",
            "Learn the basics of C#",
            new DateTime(2024, 6, 15),
            "10:00 AM",
            new Address("123 Main St", "Anytown", "CA", "USA"),
            "John Doe",
            50
        );

        var reception = new Reception(
            "Company Party",
            "Annual company gathering",
            new DateTime(2024, 6, 16),
            "6:00 PM",
            new Address("456 Elm St", "Othertown", "ON", "Canada"),
            "rsvp@company.com"
        );

        var outdoorGathering = new OutdoorGathering(
            "Community Picnic",
            "Join us for a fun picnic",
            new DateTime(2024, 6, 17),
            "12:00 PM",
            new Address("789 Park Ave", "Springfield", "IL", "USA"),
            "Sunny"
        );

        var events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}