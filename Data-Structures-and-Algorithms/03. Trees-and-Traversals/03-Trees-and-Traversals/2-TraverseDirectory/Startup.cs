// 2. Write a program to traverse the directory `C:\WINDOWS` and all its subdirectories recursively and to display all files matching the mask `*.exe`. Use the class `System.IO.Directory`.

namespace TraverseDirectory
{
    using System;
    using System.Linq;
    using System.Text;
    using System.IO;

    public class Startup
    {
        private const string Path = "C:\\WINDOWS";

        public static void Main()
        {
            var entryPoint = new DirectoryInfo(Path);
            var result = Traverse(entryPoint);
            Console.WriteLine(result);
        }

        private static string Traverse(DirectoryInfo directory)
        {
            var result = new StringBuilder();

            var executables = directory.GetFiles().Where(file => file.Extension == ".exe");

            try
            {
                foreach (var file in executables)
                {
                    result.AppendLine(file.Name);
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Cannot access directory {0} - skipped", directory.FullName);
                return result.ToString();
            }
           

            foreach (var subDirectory in directory.GetDirectories())
            {
                try
                {
                    Traverse(subDirectory);
                }
                catch (Exception)
                {
                    Console.WriteLine("Cannot access directory {0} - skipped", subDirectory.FullName);
                    continue;
                }
                
            }

            return result.ToString();
        }
    }
}
