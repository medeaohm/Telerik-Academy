//3. Define classes `File { string name, int size }` and `Folder { string name, File[] files, Folder[] childFolders }` and using them build a tree keeping all files and folders on the hard drive starting from `C:\WINDOWS`. Implement a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly.Use recursive DFS traversal.

namespace FilesAndFolders
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var entryPoint = new Folder("Windows", @"C:\Windows");
            GetSubFolders(entryPoint);

            StringBuilder output = new StringBuilder();
            GetFileSystemString(entryPoint, output, 0);
            Console.WriteLine(output);
        }

        private static void GetFileSystemString(Folder folder, StringBuilder sb, int depth)
        {
            string indent = new string('*', depth + 1);

            sb.AppendLine(string.Format("{0} - {1} -> size: {2}", indent, folder.Name, folder.GetSize()));

            foreach (var file in folder.Files)
            {
                sb.AppendLine(string.Format("* {0} - {1} -> size: {2}", indent, file.Name, file.Size));
            }

            foreach (var subFolder in folder.ChildFolders)
            {
                GetFileSystemString(subFolder, sb, depth + 1);
            }
        }

        private static void GetSubFolders(Folder folder)
        {
            foreach (var file in folder.Directory.GetFiles())
            {
                folder.Files.Add(new File(file.Name, file.Length));
            }

            foreach (var subFolder in folder.Directory.GetDirectories())
            {
                folder.ChildFolders.Add(new Folder(subFolder.Name, subFolder.FullName));
            }
        }
    }
}
