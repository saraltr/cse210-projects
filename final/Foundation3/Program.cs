using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inheritance with Event Planning");
        Console.WriteLine();

        Lecture lecture = new Lecture("Ancient Wisdom Unveiled", "Teachings of the Book of Mormon", new DateTime(2023, 7, 22), new TimeSpan(10, 30, 0), "123 Oxford Street", "Cityville", "Idaho", "12345", "John Doe", 100);

        Reception reception = new Reception("Wedding Reception", "Celebrate the union of two souls", new DateTime(2023, 7, 22), new TimeSpan(14, 0, 0), "456 Elm St", "Townsville", "California", "67890", "rsvp@reception.com");

        OutdoorGathering gathering = new OutdoorGathering("Kids' Adventure Quest", "A Day of Endless Fun and Excitement! Enjoy food, games, and sunshine", new DateTime(2023, 7, 25), new TimeSpan(14, 30, 0), "852 Adventure Road", "Sunnytown", "Arizona", "54321", "Sunny");

        // lecture event details
        Console.WriteLine($"Standard Details:");
        lecture.StandardDetails();
        lecture.FullDetails();
        lecture.ShortDescription();

        // reception event details
        Console.WriteLine($"Standard Details:");
        reception.StandardDetails();
        reception.FullDetails();
        reception.ShortDescription();

        // outdoor Gathering event details
        Console.WriteLine($"Standard Details:");
        gathering.StandardDetails();
        gathering.FullDetails();
        gathering.ShortDescription();

    }
}