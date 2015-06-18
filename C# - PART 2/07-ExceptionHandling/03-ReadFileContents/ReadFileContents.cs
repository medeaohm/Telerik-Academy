//### Problem 3. Read file contents
//*	Write a program that enters file name along with its full file path (e.g. `C:\WINDOWS\win.ini`), reads its contents and prints it on the console.
//*	Find in MSDN how to use `System.IO.File.ReadAllText(...)`.
//*	Be sure to catch all possible exceptions and print user-friendly error messages.


using System;
using System.Text;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        try
        {
            StreamReader file = new StreamReader("C:\\WINDOWS\\win.ini");
            using (file)
            {
                string fileContents = file.ReadToEnd();
                Console.WriteLine(fileContents);
            }
        }
        catch (DirectoryNotFoundException dnf)
        {
            Console.WriteLine(dnf.Message);
        }
        catch (NullReferenceException nr)
        {
            Console.WriteLine(nr.Message);
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine(fnf.Message);
        }
        catch (DriveNotFoundException drnf)
        {
            Console.WriteLine(drnf.Message);
        }
        catch (EndOfStreamException ese)
        {
            Console.WriteLine(ese.Message);
        }
        catch (FileLoadException fle)
        {
            Console.WriteLine(fle.Message);
        }
        catch (PathTooLongException ptl)
        {
            Console.WriteLine(ptl.Message);
        }
        catch 
        {
            Console.WriteLine("Something bad happend...");
        }
    }
}

