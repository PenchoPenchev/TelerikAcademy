using System;
using System.IO;
using System.Security;
using System.Text;

class ReadFileAndPrintIt
{
    /*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
        * reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
        * Be sure to catch all possible exceptions and print user-friendly error messages.*/
        
    static void Main()
    {
        Console.WriteLine("Enter file name along with its full file path.");
        Console.Write("File path = ");
        string path = Console.ReadLine();

        try
        {
            string readAllText = File.ReadAllText(path);
            Console.WriteLine(readAllText);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
