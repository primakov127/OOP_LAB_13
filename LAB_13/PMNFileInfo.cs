using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_13
{
    class PMNFileInfo
    {
        private FileInfo _file;

        public PMNFileInfo(string path)
        {
            _file = new FileInfo(path);
        }

        public void WriteFilePath()
        {
            if (this._file.Exists)
                Console.WriteLine($"+File namme: {this._file.Name}\nFile path: {this._file.FullName}");
            else
                Console.WriteLine($"File {this._file.FullName} not found unfortunately :c");

            PMNLog.WriteLog($"WriteFilePath()");
        }

        public void WriteFileInfo()
        {
            if (this._file.Exists)
                Console.WriteLine($"+File name: {this._file.Name}\nFile extension: {this._file.Extension}\nFile size: {this._file.Length} byte");
            else
                Console.WriteLine($"File {this._file.FullName} not found unfortunately :c");

            PMNLog.WriteLog($"WriteFileInfo()");
        }

        public void WriteCreationTime()
        {
            if (this._file.Exists)
                Console.WriteLine($"+Creation time: {File.GetCreationTimeUtc(this._file.FullName)}");
            else
                Console.WriteLine($"File {this._file.FullName} not found unfortunately :c");

            PMNLog.WriteLog($"WriteCreationTime()");
        }
    }
}
