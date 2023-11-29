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
            // File: static method
            // true - overwite files if existing
            var path = @"C:\somefile.jpg";

            File.Copy(@"C:\temp\myfile.jpg", @"D:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                Console.WriteLine("File exists!");
            }
            else
            {
                Console.WriteLine("File not exists!");
            }

            var content = File.ReadAllText(path); // return string

            //FileInfo: instance method
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"C:\Users\nasas\source\repos");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                Console.WriteLine("File exists!");
            }
            else
            {
                Console.WriteLine("File not exists!");
            }
        }
    }
}
