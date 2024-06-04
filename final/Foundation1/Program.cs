using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        List<Video> _videos = new List<Video>();

        //Create videos
        Video _video1 = new Video("Video 1", "Auther 1", 300);
        Video _video2 = new Video("Video 2", "Auther 2", 600);
        Video _video3 = new Video("Video 3", "Auther 3", 900);

        // Create and add coments to video1
        _video1.AddComment(new Comment("User1", "Great video!"));
        _video1.AddComment(new Comment("User2", "Thanks for sharing!"));
        _video1.AddComment(new Comment("User3", "Very informative!"));

        //  Create and add coments to video2
        _video2.AddComment(new Comment("User4", "Loved it!"));
        _video2.AddComment(new Comment("User5", "Nice work!"));
        _video2.AddComment(new Comment("User6", "Awesome content!"));

        // Create and add coments to video3
        _video3.AddComment(new Comment("User7", "Fantastic!"));
        _video3.AddComment(new Comment("User8", "Superb!"));
        _video3.AddComment(new Comment("User9", "Very well done."));

        // Display video and comment information

        foreach (var video in _videos)

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