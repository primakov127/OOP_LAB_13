using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

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

            PMNLog.WriteLog($"WriteListOfFilesAndDirectories(\"{path}\")");
        }

        static public void CreateDirectory(string path)
        {
            if (Directory.Exists(path))
                Console.WriteLine($"Directory {path} already exist!");
            else
            {
                Directory.CreateDirectory(path);
            }

            PMNLog.WriteLog($"CreateDirectory(\"{path}\")");
        }

        static public void CreateFile(string path)
        {
            if (File.Exists(path))
                Console.WriteLine($"File {path} already exist!");
            else
            {
                File.Create(path);
            }

            PMNLog.WriteLog($"CreateFile(\"{path}\")");
        }

        static public void CopyFile(string originPath, string newPath)
        {
            if (File.Exists(newPath))
                Console.WriteLine($"File {originPath} already exist!");
            else
            {
                File.Copy(originPath, newPath);
            }

            PMNLog.WriteLog($"CreateFile(\"{originPath}\", \"{newPath}\")");
        }

        static public void DeleteFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
            else
                Console.WriteLine($"File {path} not found!");

            PMNLog.WriteLog($"DeleteFile(\"{path}\")");
        }

        static public void SaveStringInFile(string path, string Data)
        {
            if (!File.Exists(path))
                return;
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(Data);
            }

            PMNLog.WriteLog($"SaveStringInFile(\"{path}\", \"{Data}\")");
        }

        static public string ReadAllInformationFromFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"File {path} not found :c");
                PMNLog.WriteLog($"ReadAllInformationFromFile(\"{path}\") - File not found");
                return null;
            }
                
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }

            PMNLog.WriteLog($"ReadAllInformationFromFile(\"{path}\")");
        }

        static public void CopyFilesFromTo(string originDir, string newDir, string extension)
        {
            if (!Directory.Exists(originDir))
            {
                Console.WriteLine($"{originDir} not found :c");
                return;
            }

            if (!Directory.Exists(originDir))
            {
                CreateDirectory(newDir);
            }
            

            var OD = new DirectoryInfo(originDir);
            var ODfiles = OD.GetFiles();

            foreach (var item in ODfiles)
            {
                string name = Path.Combine(newDir, item.Name);
                if (item.Extension == extension)
                {
                    if (!File.Exists(name))
                        item.CopyTo(name);
                }
                    
            }

            PMNLog.WriteLog($"CopyFilesFromTo(\"{originDir}\", \"{newDir}\", \"{extension}\")");
        }

        static public void CreateArchive(string originPath, string zipPath)
        {
            ZipFile.CreateFromDirectory(originPath, zipPath);

            PMNLog.WriteLog($"CreateArchive(\"{originPath}\", \"{zipPath}\")");
        }

        static public void UnArchive(string zipPath, string newPath)
        {
            ZipFile.ExtractToDirectory(zipPath, newPath);

            PMNLog.WriteLog($"UnArchive(\"{zipPath}\", \"{newPath}\")");
        }
    }
}
