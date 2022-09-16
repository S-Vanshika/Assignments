using System;
using System.Collections.Generic;
using System.IO;

class ListDir
{
    //using directory
    public void ListUsingDirectory()
    {
        string rootPath = @"D:\ASSIGNMENTS\C#\Assignments";
        
        string[] directories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
        foreach (string d in directories)
        {
            Console.WriteLine(d);
        }
    }

    //using directoryfile
    public void ListUsingDirectoryInfo()
    {
        string rootPath = @"D:\ASSIGNMENTS\C#\Assignments";

        DirectoryInfo dir = new DirectoryInfo(rootPath);
        foreach(DirectoryInfo dirInfo in dir.GetDirectories())
        {
            Console.WriteLine(dirInfo);
        }
    }

    //using files
    public void ListUsingFile()
    {
        string rootPath = @"D:\ASSIGNMENTS\C#\Assignments";

        var files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
        foreach(string file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }

    //using fileinfo
    public void ListUsingFileInfo()
    {
        string rootPath = @"D:\ASSIGNMENTS\C#\Assignments";
        DirectoryInfo dir = new DirectoryInfo(rootPath);

        FileInfo[] file = dir.GetFiles();
        foreach(FileInfo fileInfo in file)
        {
            Console.WriteLine(fileInfo);
        }
    }
}
class Program
{
    public static void Main()
    {
        int choice;
        ListDir listDir = new ListDir();

        while (true)
        {
            Console.WriteLine("Press 1 for List Using Directory Method");
            Console.WriteLine("Press 2 for List Using DirectoryInfo Method");
            Console.WriteLine("Press 3 for List Using File Method");
            Console.WriteLine("Press 4 for List Using FileInfo Method");
            Console.WriteLine("Press 5 to Exit");
            choice = int.Parse(Console.ReadLine());
            if(choice == 5)
            {
                break;
            }
            switch (choice)
            {
                case 1:
                    listDir.ListUsingDirectory();
                    break;
                case 2:
                    listDir.ListUsingDirectoryInfo();
                    break;
                case 3:
                    listDir.ListUsingFile();
                    break;
                case 4:
                    listDir.ListUsingFileInfo();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Enter valid Choice!");
                    break;
            }
        }
    }
}