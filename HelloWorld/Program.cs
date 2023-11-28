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
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour + "\n" + "Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString()); // Tuesday, 28 November, 2023
            Console.WriteLine(now.ToShortDateString()); // 28/11/2023
            Console.WriteLine(now.ToLongTimeString()); // 2:09:01 PM
            Console.WriteLine(now.ToShortTimeString()); // 2:09 PM
            Console.WriteLine(now.ToString()); // 28/11/2023 2:10:40 PM
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
        }
    }
}
