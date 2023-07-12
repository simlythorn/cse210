using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Youtube video Tracking!");
        Video video1 = new Video("Keto Diet", "Malisa", 600);
        Video video2 = new Video("Learning C# for beginner", "Jose", 7200);
        Video video3 = new Video("Learning Python for beginner", "Jared Judd", 4500);
        Video video4 = new Video("How to make a website using HTML/CSS", "Mose", 6600); 

        Comment comment1 = new Comment("Katy conner", "Thank your for your video");
        Comment comment2 = new Comment("Raksa jesy", "You are amazing");
        Comment comment3 = new Comment("John smith", "I don't understand at second 120");
        Comment comment4 = new Comment("Jarom lopez", "Please make more video");

        video1.Comments.Add(comment1);
        video2.Comments.Add(comment2);
        video3.Comments.Add(comment3);
        video4.Comments.Add(comment4);

        List<Video> videos = new List<Video> {video1, video2, video3, video4};
        foreach(Video video in videos)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Duration: {video._length} seconds");
            Console.WriteLine($"Number of comment: {video.GetNumberOfComment()}");
            foreach (Comment comment in video.Comments)
            {
                Console.Write("Commenter:");
                Console.Write($" {comment._name}: {comment._text}");
            }
            Console.WriteLine(" "); 
        }
    }
}
            
        