using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        video1.AddComment("Alice", "Great tutorial!");
        video1.AddComment("Bob", "Thanks for sharing.");
        video1.AddComment("Charlie", "Very helpful.");

        Video video2 = new Video("Introduction to Python", "Jane Smith", 280);
        video2.AddComment("David", "I learned a lot from this.");
        video2.AddComment("Eve", "Looking forward to more videos.");
        video2.AddComment("Frank", "Keep up the good work!");

        videos.Add(video1);
        videos.Add(video2);
        
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}