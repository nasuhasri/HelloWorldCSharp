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
            Directory.CreateDirectory(@"C:\Users\nasas\folder1");

            // return string -> all files in the current directory and its up directory
            var files = Directory.GetFiles(@"C:\Users\nasas\source\repos\HelloWorld", "*.sln*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            // return only directories
            var directories = Directory.GetDirectories(@"C:\Users\nasas\source\repos\HelloWorld", "*.*", SearchOption.AllDirectories);

            foreach (var dir in directories)
            {
                Console.WriteLine(dir);
            }
        }
    }
}
