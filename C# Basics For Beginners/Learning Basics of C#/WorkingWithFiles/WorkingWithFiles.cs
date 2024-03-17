using Microsoft.VisualBasic;
using System;
using System.Text;

public class WorkingWithFiles
{
	public WorkingWithFiles()
    {
    }

    public void someExample()
    {
        var path = @"C:\Users\gamas1\Downloads\UsefulCommands.txt";
        var mPath = @"C:\Users\gamas1\Downloads";
        File.Copy(path,
            @"C:\Users\gamas1\Downloads\Installer Files\UsefulCmd.txt", true);
        //File.Delete(path);
        if (File.Exists(path))
        {
            //
        }
        var content = File.ReadAllText(path);
        Console.WriteLine("Busy: " + path);
        var fileInfo = new FileInfo(path);
        if (fileInfo.Exists)
        {
            Console.WriteLine("The file: " + path + " exists.");
        }
        //Create a directory
        Directory.CreateDirectory(@"C:\Users\gamas1\Downloads\Coding");
        /*
         * Copy a file from one location into another location.
         */
        File.Copy(@"C:\Users\gamas1\Downloads\Screenshot 2024-03-11 104855.png",
            @"C:\Users\gamas1\Downloads\Coding\ViewScreenShot.png", true);
        File.Copy(path,
            @"C:\Users\gamas1\Downloads\Coding\UsefulCmd.txt", true);
        //Search for all files in the given directory and subdirectories.
        var files = Directory.GetFiles(@"C:\Users\gamas1\Downloads", "*.txt", SearchOption.AllDirectories);
        Console.WriteLine("All Files in this directory: ");
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }
        //Get only the directories within.
        var dirs = Directory.GetDirectories(@"C:\Users\gamas1\Downloads", "*.*", SearchOption.AllDirectories);
        Console.WriteLine("All Directories in Downloads: ");
        foreach (var dir in dirs)
        {
            Console.WriteLine(dir);
        }
        var directoryInfo = new DirectoryInfo(mPath);
        Console.WriteLine("================= Directory Info Exists: " + directoryInfo.Exists);

        //Using Path
        var myPath = @"C:\Users\gamas1\Downloads\Coding\ViewScreenShot.png";
        Console.WriteLine("Extension: " + Path.GetExtension(myPath));
        Console.WriteLine("File Name: " + Path.GetFileName(myPath));
        Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(myPath));
        Console.WriteLine("Directory Name: " + Path.GetDirectoryName(myPath));
    }
}
