using System; // basic utility classes and primitive types typewriter system
using System.Collections.Generic;

namespace HelloWorld
{
    public class WorkingWithText
    {
        public static void Exercise1()
        {
            // Exercise 1
            Console.WriteLine("Enter a few numbers separated by a hyphen (-): ");
            var input = Console.ReadLine().Split('-');

            var listNumbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                listNumbers.Add(int.Parse(input[i]));
            }

            var numbers = new int[listNumbers.Count];
            listNumbers.CopyTo(numbers);
            Array.Sort(numbers);

            bool isCons = false;

            for (int i = 1; i < numbers.Length; i++)
            {
                var secondElement = numbers[i]; // second element
                var firstElement = numbers[i - 1]; // first element

                if (secondElement - firstElement == 1)
                {
                    isCons = true;
                    break;
                }
            }

            if (isCons)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not consecutive");
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }
            else
            {
                var numbers = input.Split('-');
                var listNumbers = new List<int>();

                foreach (var number in numbers)
                {
                    var num = Convert.ToInt32(number);

                    if (!listNumbers.Contains(num))
                    {
                        listNumbers.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("Duplicate");
                    }
                }
            }
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter a time value in 24 hour format: ");

            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time!");
            }

            var time = input.Split(':');

            if (time.Length != 2)
            {
                return;
            }

            for (int i = 1; i < time.Length; i++)
            {
                var hour = int.Parse(time[i - 1]);
                var minute = int.Parse(time[i]);

                if ((hour >= 0 && hour <= 23) && (minute >= 0 && minute <= 59))
                {
                    Console.WriteLine("Valid time");
                }
                else
                {
                    Console.WriteLine("Invalid time");
                }
            }
        }

        public static bool IsConsecutive(List<int> list)
        {
            // create an array of int numbers based on list elements
            var numbers = new int[list.Count];
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (int i = 1; i < numbers.Length; i++)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Iteration {0}", i);
                Console.WriteLine("Numbers [i] ---- {0}", numbers[i]);
                Console.WriteLine("Numbers [i-1] --- {0}", numbers[i - 1]);
                Console.WriteLine("Numbers[i] - numbers[i-1] ---- {0}", numbers[i] - numbers[i - 1]);

                if (numbers[i] - numbers[i - 1] != 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Exercise4()
        {
            // Exercise 4
            Console.Write("Please enter words separated by space: ");
            var input = Console.ReadLine();

            var elements = input.Split(' ');
            var strElement = "";

            foreach (var element in elements)
            {
                var result = char.ToUpper(element[0]) + element.Substring(1);
                strElement += result;
            }

            Console.WriteLine(strElement);
        }

        public static void Exercise5()
        {
            // Exercise 5
            Console.WriteLine("Please enter English words: ");
            var input = Console.ReadLine();

            //var countVowels = 0;
            //foreach (var character in input)
            //{
            //    if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            //    {
            //        countVowels++;
            //    }
            //}

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;

            // Note the ToLower() here. This is used to count for both A and a. 
            foreach (var character in input.ToLower())
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine("Number of vowels: " + vowelsCount);
        }
    }
}
