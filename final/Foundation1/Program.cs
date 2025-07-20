using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("3 graveyards, one deck", "Ken", "12:40");
        video1.AddComment(new Comment("newimmortal", "why is this on my feed"));
        video1.AddComment(new Comment("lavagirl", "this is why education needs reforming"));
        video1.AddComment(new Comment("ShadowNinja69", "Ken is the type of guy to buy sweat in a sweatshop"));
        video1.AddComment(new Comment("xX_Yakub_Xx", "Another clasic from the mayor of yapsville"));
        videos.Add(video1);

        Video video2 = new Video("Why being a pirate actually sucks", "modern yapper", "23:47");
        video2.AddComment(new Comment("texacola", "better a scurvy dog than a navy slave"));
        video2.AddComment(new Comment("JackSparrow", "never said it was easy"));
        video2.AddComment(new Comment("Iamdacaptain", "navy propaganda"));
        video2.AddComment(new Comment("triggertreat", "I love hard tack"));
        videos.Add(video2);

        Video video3 = new Video("Bistro Huddy Job Interview Complilation", "Dreq Talbert", "3:44");
        video3.AddComment(new Comment("jordicue", "The manager constatly getting interrupted by the staff was so accurate it hurts"));
        video3.AddComment(new Comment("hdjksa52", "I like that pickles started off as a questionable hire and he worked up to cook"));
        video3.AddComment(new Comment("mmmghool", "thid is my exposure therapy for getting a new job"));
        video3.AddComment(new Comment("Aperson152", "short for nic gets me every time"));
        videos.Add(video3);

        Console.WriteLine("Advertiser Review");
        Console.WriteLine("==================");
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}