using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstraction with YouTube Videos");
        Console.WriteLine();
        List<Video> videos = new List<Video>();

        // create videos
        Video video1 = new Video("Soft and Chewy Chocolate Chip Cookies Recipe", "The Cooking Foodie", 178);
        // adds the various comments
        video1.AddComment(new Comment("jamil730", "I made these yesterday and took them to a family event, now my relatives think I am a baking sensation!"));
        video1.AddComment(new Comment("hosana", "I done this recipe twice and my kids loved it!!"));
        video1.AddComment(new Comment("MrMattytee", "This has become my go to chocolate chip cookie recipe! "));
        // adds the objects to the list
        videos.Add(video1);

        Video video2 = new Video("Learn Flexbox CSS in 8 minutes", "Slaying The Dragon", 525);
        video2.AddComment(new Comment("flander", "This is what high value content looks like.   Crystal clear, concise and to the point.  Much appreciated."));
        video2.AddComment(new Comment("lion784", "Very informative!."));
        videos.Add(video2);

        Video video3 = new Video("13 Advanced (but useful) Git Techniques and Shortcuts", "Fireship", 483.6);
        video3.AddComment(new Comment("djordjeni", "The guy who created git seems really smart. He should create a kernel someday."));
        video3.AddComment(new Comment("valvula_", "Good tip, do not use —force, this will make all your coworkers hate you, use —force-with-lease, this will only allow you to push the code if there are no conflicting changes with the current parent branch"));
        videos.Add(video3);

        // display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Video Info:");
            video.DisplayVideoInfo();
            Console.WriteLine();

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"User Name: {comment.GetCommenter()}");
                Console.WriteLine($"Text: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}