using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_13
{
    static class PMNFileManager
    {
        static public void WriteListOfFilesAndDirectories(string path)
        {
            Console.WriteLine($"Disk Name: {path}");
            Console.WriteLine("Directories: ");
            var directories = Directory.GetDirectories(path);
            foreach (var item in directories)
                Console.WriteLine($"\t{item}");

            Console.WriteLine("Files: ");
            var files = Directory.GetFiles(path);
            foreach (var item in files)
                Console.WriteLine($"\t{item}");
        }

        static public void CreateDirectory(string path)
        {
            if (Directory.Exists(path))
                Console.WriteLine($"Directory {path} already exist!");
            else
            {
                Directory.CreateDirectory(path);
            }
        }

        static public void CreateFile(string path)
        {
            if (File.Exists(path))
                Console.WriteLine($"File {path} already exist!");
            else
            {
                File.Create(path);
            }
        }

        static public void CopyFile(string originPath, string newPath)
        {
            if (File.Exists(newPath))
                Console.WriteLine($"File {originPath} already exist!");
            else
            {
                File.Copy(originPath, newPath);
            }
        }

        static public void DeleteFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
            else
                Console.WriteLine($"File {path} not found!");
        }
    }
}
