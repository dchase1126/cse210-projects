using System;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("\nWelcome to 'Abstraction with YouTube Videos' program.\n");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("The Test", "John Tesh", 10);
        video1.AddComment("Sue", "Good video!");
        video1.AddComment("Daniel", "The Test was a great video!");

        Video video2 = new Video("Solo", "Paul Harvey", 20);
        video2.AddComment("Sam", "Awesome a must watch!");

        Video video3 = new Video("Han Solo", "Harison Ford", 60);
        video3.AddComment("Luke", "Awesome! May the Force be with you!");

        Video video4 = new Video("Eternals", "Angelina Jolie", 30);
        video4.AddComment("Ivan", "This was an okay video!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();

        }
    }
}
