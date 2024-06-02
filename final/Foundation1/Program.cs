using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        List<Video> videos = new List<Video>();

        //Create videos
        Video video1 = new Video("Video 1", "Auther 1", 300);
        Video video2 = new Video("Video 2", "Auther 2", 600);
        Video video3 = new Video("Video 3", "Auther 3", 900);

        // Create and add coments to video1
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Thanks for sharing!"));
        video1.AddComment(new Comment("User3", "Very informative!"));

        //  Create and add coments to video2
        video2.AddComment(new Comment("User4", "Loved it!"));
        video2.AddComment(new Comment("User5", "Nice work!"));
        video2.AddComment(new Comment("User6", "Awesome content!"));

        // Create and add coments to video3
        video3.AddComment(new Comment("User7", "Fantastic!"));
        video3.AddComment(new Comment("User8", "Superb!"));
        video3.AddComment(new Comment("User9", "Very well done."));

        // Display video and comment information

        foreach (var video in videos)

        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Lenght: {video._length} secords");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"\t{comment._commenterName}: {comment._text}");
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to view next video... ");
            Console.ReadLine();
        }
    }
}