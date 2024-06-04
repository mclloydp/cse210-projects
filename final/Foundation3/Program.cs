using System;

class Program
{
    static void Main(string[] args)
    {
        {
        Address _address1 = new Address("123 Main St", "Anytown", "Western Cape", "South Africa");
        Event _lecture = new Lecture("C# Programming", "An in-depth look at C#", DateTime.Now, _address1, "John Doe", 100);

        Address _address2 = new Address("456 Oak St", "Othertown", "Gauteng", "South Africa");
        Event _reception = new Reception("Networking Event", "Meet and greet with industry professionals", DateTime.Now.AddDays(1), _address2, "rsvp@example.com");

        Address _address3 = new Address("789 Pine St", "Somewhere", "Mpumalanga", "South Africa");
        Event _outdoorGathering = new OutdoorGathering("Community Picnic", "Enjoy a day in the park with your neighbors", DateTime.Now.AddDays(2), _address3, "Sunny with a chance of rain");

        Event[] _events = { _lecture, _reception, _outdoorGathering };

        foreach (var ev in _events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("\n-----------------------\n");
        }
    }

    }
}