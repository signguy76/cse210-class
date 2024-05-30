using System;
using System.Collections.Generic;



// Main program class
public class Program
{
    public static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create and set up videos
        Video video1 = new Video("How to Create Flowchart in Microsoft Word", "Office Master", 246);
        video1.AddComment(new Comment("@savreetsekhon8418", "This is one of those \'I was today years old\' moment for me. It was so simple and yet I knew nothing about it. Thank you for such an easy and wonderful explanation"));
        video1.AddComment(new Comment("@adisherman8683", "Excellent, clear, and straightforward. Thank you!"));
        video1.AddComment(new Comment("@chuksmoxie7150", "Clear, brief and straightforward, thanks."));

        Video video2 = new Video("Learn Python in Less than 10 Minutes", "Indently", 630);
        video2.AddComment(new Comment("@ytsummary", "Your post was created 2 years ago, but it's still helping newcomers"));
        video2.AddComment(new Comment("@jordanyoung1836", "I appreciate you explaining...it's helping me very well"));
        video2.AddComment(new Comment("@RazielHamalach", "This is very helpfull!"));

        Video video3 = new Video("Motions of a Hidden Fire", "Jeffrey R. Holland", 808);
        video3.AddComment(new Comment("@sydneymay7687", "What a wonderful man."));
        video3.AddComment(new Comment("@tarisainyaumwe2198", "I'm a less active member but this man is on another level, listening to him brings the spirit"));
        video3.AddComment(new Comment("@FabFit87", "Elder Holland, you have been a strength throughout my life. You are apart of the rock I built upon. I love you so much!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"Comment from - {comment._commenterName}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}
