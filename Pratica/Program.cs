
using System;

namespace SBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("How that's awsime");

            Post p1 = new Post(
                DateTime.Parse("21/06/2021"),
                "Travaling to New Zealand",
                "I'm going to visit this wondeful country",
                12
                );

            p1.addComment(c1);
            p1.addComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");

            Post p2 = new Post(
                DateTime.Parse("21/06/2021"),
                "Good nith guys",
                "See you tomorrow",
                20
                );

            p2.addComment(c3);
            p2.addComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);

        }
    }
}
