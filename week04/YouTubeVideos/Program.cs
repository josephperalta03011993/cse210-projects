using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial", "Joseph", 60);
        video1.AddComment(new Comment("Karen", "Great video!"));
        video1.AddComment(new Comment("Terio", "Thanks for the tutorial!"));
        video1.AddComment(new Comment("Nell", "I didn't understand the last part."));
        videos.Add(video1);

        Video video2 = new Video("Python Tutorial", "Peralta", 120);
        video2.AddComment(new Comment("Michael", "Awesome Staff!"));
        video2.AddComment(new Comment("Katty", "Can you explain the last part again?"));
        video2.AddComment(new Comment("Christine", "Cool!"));
        video2.AddComment(new Comment("Rizza", "I am confused."));
        videos.Add(video2);

        Video video3 = new Video("Java Tutorial", "Dagohoy", 180);
        video3.AddComment(new Comment("Jenifer", "I love this video!"));
        video3.AddComment(new Comment("Kristine", "I learned a lot!"));
        video3.AddComment(new Comment("Sherlyn", "Can you explain it again?"));
        videos.Add(video3);

        Video video4 = new Video("JavaScript Tutorial", "Dagohoy", 240);
        video4.AddComment(new Comment("Paul", "I like this tutorial"));
        video4.AddComment(new Comment("Justine", "Excited to learn more!"));
        video4.AddComment(new Comment("Beng", "Very helpful!"));
        videos.Add(video4);

        foreach(Video video in videos)
        {
            Console.WriteLine(video.GetVideoDetails());
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            foreach(Comment comment in video.Comments())
            {
                Console.WriteLine(comment.DisplayComment());
            }
            Console.WriteLine();
        }
    }
}