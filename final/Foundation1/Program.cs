using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video();
        v1._title = "My first video";
        v1._author = "Jake Nielson";
        v1._length = 134;
        
        Comment v1c1 = new Comment();
        v1c1._name = "Rich Guy";
        v1c1._text = "Get a better camera, the quality is terrible";

        Comment v1c2 = new Comment();
        v1c2._name = "Hyrum Smith";
        v1c2._text = "I appreciate the honesty";

        Comment v1c3 = new Comment();
        v1c3._name = "Burnt Toast";
        v1c3._text = "Nice to meet you!";

        v1._comments.Add(v1c1);
        v1._comments.Add(v1c2);
        v1._comments.Add(v1c3);


        Video v2 = new Video();
        v2._title = "Banana Pancakes";
        v2._author = "Jack Johnson";
        v2._length = 280;
        
        Comment v2c1 = new Comment();
        v2c1._name = "Ethan Houser";
        v2c1._text = "I love this song!";

        Comment v2c2 = new Comment();
        v2c2._name = "Big Wig";
        v2c2._text = "Can I hire you?";

        Comment v2c3 = new Comment();
        v2c3._name = "My TA";
        v2c3._text = "Did you really do all of your homework in the last week you were able to submit it?";

        v2._comments.Add(v2c1);
        v2._comments.Add(v2c2);
        v2._comments.Add(v2c3);


        Video v3 = new Video();
        v3._title = "Art Time Lapse";
        v3._author = "Da Vinci";
        v3._length = 240;
        
        Comment v3c1 = new Comment();
        v3c1._name = "Galileo";
        v3c1._text = "Most impressive!";

        Comment v3c2 = new Comment();
        v3c2._name = "Einstein";
        v3c2._text = "Do you have any other works?";

        Comment v3c3 = new Comment();
        v3c3._name = "Bruno Mars";
        v3c3._text = "This isn't real art.";

        v3._comments.Add(v3c1);
        v3._comments.Add(v3c2);
        v3._comments.Add(v3c3);

        List<Video> list = new List<Video> {v1, v2, v3};
        foreach (Video video in list)
        {
            video.Display();
            Console.WriteLine();
        }

        
    }
}