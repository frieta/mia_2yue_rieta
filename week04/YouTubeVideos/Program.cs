using System;
using System.Collections.Generic;

// this is where everything comes together
class Program
{
    static void Main()
    {
        // setting up a list of videos
        List<Video> videos = new List<Video>
        {
            new Video("Most funny experience as a tech support.", "Romeo Mabini", 320),
            new Video("What it feels like to be a teacher as your profession and also a parent of two kids?", "Mia Fe A. Rieta", 450),
            new Video("How to earn money in the Philippines?", "CongTV Team Payaman", 600),
            new Video("Life in Japan as an English Teacher.", "Peter Paul Argente", 480)
        };

        // adding comments for each video
        videos[0].AddComment(new Comment("MARY AR ADVINCULA", "Haha! This happened to me once too!"));
        videos[0].AddComment(new Comment("MARVIN BONAGUA", "Classic IT support struggle!"));
        videos[0].AddComment(new Comment("GINALYN CABUGUANG", "This made my day lol"));

        videos[1].AddComment(new Comment("JOCELYN SUHON", "Being a teacher and a parent must be tough but rewarding!"));
        videos[1].AddComment(new Comment("ANA MARIE MASAOY", "So relatable! Balancing both must take a lot of patience."));
        videos[1].AddComment(new Comment("SHERYLL GARCIA", "Such an inspiring story!"));

        videos[2].AddComment(new Comment("JERSON DELA CRUZ", "Great tips! Need more content like this."));
        videos[2].AddComment(new Comment("GEMMA BALONDO", "Hustle culture in PH is real! Thanks for sharing."));
        videos[2].AddComment(new Comment("ILUMINADA SENOBIO", "Awesome ideas! Time to grind!"));

        videos[3].AddComment(new Comment("RESTITUTO ILANO", "Life in Japan sounds amazing!"));
        videos[3].AddComment(new Comment("LOUIE DESOYO", "This is super informative, thanks!"));
        videos[3].AddComment(new Comment("AIKIE PERIDA", "Thinking about teaching in Japan myself!"));

        // looping through and displaying everything
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}