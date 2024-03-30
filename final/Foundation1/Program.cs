using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Giant cheese wheel strikes penguin", "Michelangelo", 12);
        video1.AddComment("LeonardoDecaprio2", "NOOOOOOOO");
        video1.AddComment("B4tman", "That's what I do to all the villians in Gotham :P");
        video1.AddComment("LegoGuy738", "Aw he fell over :(");
        videos.Add(video1);

        Video video2 = new Video("Reenactment of the Trojan Horse but with sock puppets", "Mr. Pup", 3120);
        video2.AddComment("SockEnthusiast", "Were these all left socks?");
        video2.AddComment("FootCoverLover", "Great sock show <3");
        video2.AddComment("TheGrinch", "How come I was never gifted socks as a child? ");
        videos.Add(video2);

        Video video3 = new Video("How to make blue cupcakes", "Michael Scott", 270);
        video3.AddComment("Creed", "When do I add the mung beans?");
        video3.AddComment("Meridith", "My son hated these.");
        video3.AddComment("Jim", "Did you film this while you were supposed to be filling out reports?");
        video3.AddComment("Dwight", "Jerky is better. Fact.");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}