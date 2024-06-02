using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Pine St", "London", "England", "UK");

        // Create events
        Event lecture = new Lecture("Tech Talk", "A talk on the latest in technology.", new DateTime(2024, 6, 15), new TimeSpan(14, 0, 0), address1, "John Doe", 100);
        Event reception = new Reception("Networking Event", "An evening of networking.", new DateTime(2024, 7, 20), new TimeSpan(18, 0, 0), address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Picnic", "A fun outdoor picnic.", new DateTime(2024, 8, 5), new TimeSpan(11, 0, 0), address3, "Sunny");

        // Create a list of events
        var events = new List<Event> { lecture, reception, outdoorGathering };

        // Display event details
        foreach (var evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine(new string('-', 20));
        }
    }
}
