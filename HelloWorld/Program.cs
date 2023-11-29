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
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or 'Quit' to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit") break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = GetUniqueNumbers(numbers);

            Console.WriteLine("Unique numbers: ");
            foreach (var unique in uniques)
            {
                Console.WriteLine(unique);
            }
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            return uniques;
        }
    }
}
