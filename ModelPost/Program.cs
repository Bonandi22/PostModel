using ModelPost.Entities;
using System;

namespace ModelPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new ("have a nice trip");
            Comment C2 = new("wow, tha's awesome! ");
            Post p1 = new(
                DateTime.Parse("21/06/2018"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(C2);

            Comment c3 = new ("Good night");
            Comment c4 = new ("May the Force be with you");
            Post p2 = new (
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
