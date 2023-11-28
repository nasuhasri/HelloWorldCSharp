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
            // Exercise - Loop

            // Exercise 1
            var countNum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    countNum++;
                }
            }

            Console.WriteLine("Number divisible by 3: " + countNum);

            // Exercise 2
            var sum = 0;

            while (true)
            {
                Console.Write("Enter number or 'OK' to exit: ");
                var input = Console.ReadLine();

                if (input.ToUpper() == "OK")
                {
                    break;
                }

                var num = int.Parse(input);
                sum = sum + num;
            }

            Console.WriteLine("Sum of all numbers: " + sum);

            // Exercise 3
            Console.Write("Enter number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i; ;
            }

            Console.WriteLine("Factorial of num {0}: {1}", number, factorial);

            // Exercise 4
            Random rand = new Random();

            var randomNum = rand.Next(1, 10);

            Console.WriteLine("Random number: " + randomNum);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess a number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNum)
                {
                    Console.WriteLine("You won!");
                    break;
                }
            }

            Console.WriteLine("You have exceeded the chances! You lost.");

            // Exercise 5
            Console.Write("Enter a series of numbers: ");
            var inputNumbers = Console.ReadLine();

            var listNumbers = inputNumbers.Split(',');

            var max = 0;
            for (int i = 0; i < listNumbers.Length; i++)
            {
                var intNum = Convert.ToInt32(listNumbers[i]);

                if (intNum > max)
                {
                    max = intNum;
                }
            }

            Console.WriteLine("Maximum number: " + max);
        }

    }
}
