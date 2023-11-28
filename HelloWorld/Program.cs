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
            var builder = new StringBuilder();
            builder.Append('-', 10); // append 10x
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            var builder1 = new StringBuilder();
            builder1.Append('-', 10) // append 10x
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            Console.WriteLine(builder);
        }

    }
}
