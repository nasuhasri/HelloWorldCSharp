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
            var fullname = "Mosh Hamedani ";
            Console.WriteLine("Trim: '{0}'", fullname.Trim());

            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); // RM29.95

            var sentence = "This is going to be really really really really really really really really long text";
            var summary = StringUtility.SummarizeText(sentence, 20);
            Console.WriteLine(summary);
        }

    }
}
