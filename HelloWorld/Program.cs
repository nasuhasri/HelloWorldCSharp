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
            // Exercise - Control Flow

            // Exercise 1
            Console.Write("Enter number: ");
            var input = Console.ReadLine();
            var num = int.Parse(input);

            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            // Exercise 2
            Console.Write("Enter number 1: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }

            // Exercise 3
            /*
             * the height of the image is longer than the width - portrait
             * Images where the width is longer - landscape
             */
            Console.Write("Enter width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("Portrait");
            }
            else
            {
                Console.WriteLine("Landscape");
            }

            // Exercise 4
            Console.Write("Enter speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter speed of car: ");
            var speedCar = Convert.ToInt32(Console.ReadLine());

            if (speedCar < speedLimit)
            {
                Console.WriteLine("Okay");
            }
            else
            {
                var demeritPoints = (speedCar - speedLimit) / 5;

                if (demeritPoints < 12)
                {
                    Console.WriteLine("Demerit Points: " + demeritPoints);
                }
                else
                {
                    Console.WriteLine("License suspended!");
                }
            }
        }

    }
}
