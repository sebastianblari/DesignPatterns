using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\";
            ShowLargeFilesWithoutLinq(path);
            ShowLargeFilesWithLinq(path);
            Console.WriteLine("Hello World!");

            Func<int, int, int> addMultiple = (x, y) => x + y;
            addMultiple += (x, y) => x * y;
            Console.WriteLine(addMultiple(5,6));

        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            var directory = new DirectoryInfo(path);
            var files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());
            /*
            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }*/

            for (int i = 0; i < 5; i++)
            {
                var file = files[i];
                Console.WriteLine($"{file.Name,-30} : {file.Length,10:N}");
            }
            Console.WriteLine("***");
        }

        private static void ShowLargeFilesWithLinq(string path)
        {
            /*
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;
            */

            
            var query = new DirectoryInfo(path).GetFiles()
                .OrderByDescending(f => f.Length)
                .Take(5);
            
            
            foreach(var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name,-30} : {file.Length,10:N}");
            }
        }
    }

    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare([AllowNull] FileInfo x, [AllowNull] FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
