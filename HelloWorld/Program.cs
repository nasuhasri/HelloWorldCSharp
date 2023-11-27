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
            Console.WriteLine("Hello my family!");

            // can also use var so C# will define it automatically
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Ali";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // format string - shows min and max value for byte
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            // type conversion
            try
            {
                var number1 = "1234";
                byte b = Convert.ToByte(number1);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                throw;
            }

            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(5, 8);
            Console.WriteLine("Result: " + result);
        }
    }
}
