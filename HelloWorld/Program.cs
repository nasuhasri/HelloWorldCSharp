using HelloWorld.Math;
using System; // basic utility classes and primitive types typewriter system
using System.Collections.Generic; // work with list collections
using System.Linq; // work with data
using System.Text; // work with text, coding etc
using System.Threading.Tasks; // used to build multithreaded application

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1, // if not set, will start with 0
        RegisteredAirMail = 2,
        Express = 3
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // creating time span objects
            var timeSpan = new TimeSpan(1, 2, 3); // hours/minutes/seconds

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            Console.WriteLine(timeSpan2); // 01:00:00

            var start = DateTime.Now; // returns the current date/time
            var end = DateTime.Now.AddMinutes(30);
            var duration = end - start;

            Console.WriteLine("Start: " + start);
            Console.WriteLine("End: " + end);
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes); // return 2
            // 62.05, from timespan object -> 1 hour: 60 minutes + 2 minutes + (3 sec/60)
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add
            // add 8 mins to current timespan object
            // return Add Example: 01:10:03
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
        }
    }
}
