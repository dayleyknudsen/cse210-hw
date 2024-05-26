using System;
using System.Collections.Generic;
using System.IO;
// Add Negative Goals
class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("=====================");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(user);
                    break;
                case "2":
                    RecordEvent(user);
                    break;
                case "3":
                    ShowGoals(user);
                    break;
                case "4":
                    SaveGoals(user);
                    break;
                case "5":
                    LoadGoals(user);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (choice != "6") 
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
 private static void CreateNewGoal(User user)
    {
        Console.Clear();
        Console.WriteLine("Create New Goal");
        Console.WriteLine("================");
        Console.WriteLine("1: Simple Goal");
        Console.WriteLine("2: Eternal Goal");
        Console.WriteLine("3: Checklist Goal");
        Console.WriteLine("4: Negative Goal");
        Console.Write("Enter goal type: ");
        var type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        var name = Console.ReadLine();

        Console.Write("Enter goal points: ");
        var points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                user.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                user.AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                var targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                var bonusPoints = int.Parse(Console.ReadLine());
                user.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            case "4":
                user.AddGoal(new NegativeGoal(name, -points));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        Console.WriteLine("Goal created successfully.");
    }

    private static void RecordEvent(User user)
    {
        Console.Clear();
        Console.WriteLine("Record Event");
        Console.WriteLine("=============");
        Console.Write("Enter goal name to record event: ");
        var name = Console.ReadLine();
        user.RecordEvent(name);
        Console.WriteLine("Event recorded successfully.");
    }

    private static void ShowGoals(User user)
    {
        Console.Clear();
        Console.WriteLine("Your Goals");
        Console.WriteLine("==========");
        user.DisplayGoals();
    }

    private static void SaveGoals(User user)
    {
        Console.Clear();
        Console.WriteLine("Save Goals");
        Console.WriteLine("==========");
        Console.Write("Enter file path to save goals: ");
        var filePath = Console.ReadLine();
        user.SaveGoals(filePath);
        Console.WriteLine("Goals saved successfully.");
    }

    private static void LoadGoals(User user)
    {
        Console.Clear();
        Console.WriteLine("Load Goals");
        Console.WriteLine("==========");
        Console.Write("Enter file path to load goals: ");
        var filePath = Console.ReadLine();
        user.LoadGoals(filePath);
        Console.WriteLine("Goals loaded successfully.");
    }
}