using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video("10 Hours of bird sounds", "10 Hour Complations", "10:00:00");
        Comment comment1 = new Comment("rats263", "I really like this video");
        Comment comment2 = new Comment("DragonsAreCool", "First comment");
        Comment comment3 = new Comment("randomuser", "Do you know how annoying the 'First comment' comments are?");
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        videos.Add(video1);

        Video video2 = new Video("Look at how crazy these animals are", "AnimalsBeingFunny", "1:03:39");
        Comment comment4 = new Comment("ILoveAnimals", "This is so adorable.");
        Comment comment5 = new Comment("just another viewer", "I love this channel.");
        Comment comment6 = new Comment("a fungi", "Please continue making videos like this.");
        Comment comment7 = new Comment("Puppies are the best", "I loved the parts with puppies the most.");
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);
        videos.Add(video2);

        Video video3 = new Video("Minecraft ep 1", "A new Minecraft player", "30:50");
        Comment comment8 = new Comment("I-Like-Watching-Minecraft", "Minecraft is a cool game.");
        Comment comment9 = new Comment("A different random user", "When are you doing ep 2?");
        Comment comment10 = new Comment("WhatsTheNextBuild", "I wonder what you're going to build next.");
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("\nUploaded by: " + video._author + " | Title: " + video._title + " | Length: " + video._length + " | Comments: " + video.NumberOfComments() + "\nusername : comment");
            video.DisplayComments();
        }
    }
}