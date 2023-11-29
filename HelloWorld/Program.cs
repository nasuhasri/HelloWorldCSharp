using HelloWorld.Math;
using System; // basic utility classes and primitive types typewriter system
using System.Collections.Generic; // work with list collections
using System.Linq; // work with data
using System.Text; // work with text, coding etc
using System.Threading.Tasks; // used to build multithreaded application

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reverse name: " + reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
            {
                // 3-3 = 0, 3-1 = 2
                // so array[0] = name[2]
                array[name.Length - i] = name[i - 1];
            }

            var reversed = new string(array);

            return reversed;
        }
    }
}
