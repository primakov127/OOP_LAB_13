using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_13
{
    class PMNDirInfo
    {
        private DirectoryInfo _directory;

        public PMNDirInfo(string path)
        {
            _directory = new DirectoryInfo(path);
        }

        public void WriteCountOfFiles()
        {
            if (_directory.Exists)
                Console.WriteLine($"+Count of Files in {_directory.Name}: {_directory.GetFiles().Length}");
            else
                Console.WriteLine($"Directory: {_directory.Name} not found unfortunely :c");

            PMNLog.WriteLog($"WriteCountOfFiles()");
        }

        public void WriteCreationTime()
        {
            if (this._directory.Exists)
                Console.WriteLine($"+{this._directory.Name} Creation time: {Directory.GetCreationTimeUtc(this._directory.FullName)}");
            else
                Console.WriteLine($"Directory {this._directory.Name} not found unfortunately :c");

            PMNLog.WriteLog($"WriteCreationTime()");
        }

        public void WriteCountOfSubdirectories()
        {
            if (this._directory.Exists)
                Console.WriteLine($"+Count of Subdirectories in {_directory.Name}: {_directory.GetDirectories().Length}");
            else
                Console.WriteLine($"Directory {this._directory.Name} not found unfortunately :c");

            PMNLog.WriteLog($"WriteCountOfSubdirectories()");
        }

        public void WriteListOfParentDirectories()
        {
            if (this._directory.Exists)
            {
                var directories = _directory.Parent.GetDirectories();
                Console.WriteLine($"+{_directory.Parent.Name} Subdirectories: ");
                foreach (var dir in directories)
                    Console.WriteLine(dir.Name);
            }   
            else
                Console.WriteLine($"Directory {this._directory.Name} not found unfortunately :c");

            PMNLog.WriteLog($"WriteListOfParentDirectories()");
        }
    }
}
