using HelloWorld.Math;
using System; // basic utility classes and primitive types typewriter system
using System.Collections.Generic; // work with list collections
using System.IO;
using System.Linq; // work with data
using System.Text; // work with text, coding etc
using System.Threading.Tasks; // used to build multithreaded application

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise - Array and Lists

            // Exercise 1
            Exercise1();

            // Exercise 2
            Exercise2();

            // Exercise 3
            Exercise3();

            // Exercise 4
            Exercise4();

            // Exercise 5
            Exercise5();
            
        }

        public static void Exercise1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter names: ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                names.Add(input);
            }

            if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count - 2);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("{0} like your post.", names[0]);
            }
        }

        public static void Exercise2()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            var array = new char[name.Length];

            Console.WriteLine("name length: " + name.Length);

            for (int i = name.Length; i > 0; i--)
            {
                // index start with 2
                array[name.Length - i] = name[i - 1];
            }

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter 5 numbers: ");
            var numList = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();
                var intInput = Convert.ToInt32(input);

                if (!numList.Contains(intInput))
                {
                    numList.Add(Convert.ToInt32(input));
                }
                else
                {
                    Console.WriteLine("Number has been previously entered. Please re-try!");
                }

                if (numList.Count == 5)
                {
                    break;
                }
            }

            numList.Sort();

            for (var i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }
        }

        public static void Exercise4()
        {
            Console.Write("Enter a number or type 'Quit': ");
            var input = Console.ReadLine();

            var numList = new List<int>();

            while (input != "Quit")
            {
                var num = Convert.ToInt32(input);

                if (!numList.Contains(num))
                {
                    numList.Add(num);
                }

                Console.Write("Enter a number or type 'Quit': ");
                input = Console.ReadLine();
            }

            numList.Sort();

            for (var i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }
        }

        public static void Exercise5()
        {
            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter a list of comma separated numbers: ");
                var input = Console.ReadLine();

                elements = input.Split(',');

                if (elements.Length >= 5)
                {
                    break;
                }

                Console.WriteLine("Invalid list!");
            }

            var numList = new List<int>();

            foreach (var item in elements)
            {
                numList.Add(Convert.ToInt32(item));
            }

            numList.Sort();

            Console.WriteLine("The three smallest numbers are: {0}, {1}, {2}", numList[0], numList[1], numList[2]);
        }
    }
}
