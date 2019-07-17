using System;
using System.IO;
using System.Linq;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"/Users/vineetsingh/Desktop";
            ShowLargeFilesWithoutLinq(path);

            Console.WriteLine("*******");

            ShowLargeFilesWithLinq(path);
        }

        private static void ShowLargeFilesWithLinq(string path)
        {
            var query = new DirectoryInfo(path).GetFiles()
                        .OrderByDescending(f => f.Length)
                        .Take(5);
                        
            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0} ");
            }
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            var directory = new DirectoryInfo(path);

            var files = directory.GetFiles();
            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name} : {file.Length} ");
            }
        }
    }
}
