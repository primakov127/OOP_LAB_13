using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Second Task

            //PMNDiskInfo.WriteFreeDiskSpace();
            //PMNDiskInfo.WriteDriverFormat();
            //PMNDiskInfo.WriteAllDiskInfo();

            #endregion Second Task

            #region Third Task

            PMNFileInfo file = new PMNFileInfo(@"..\..\example.txt");
            //file.WriteFilePath();
            //file.WriteFileInfo();
            //file.WriteCreationTime();

            #endregion Third Task

            #region Fourth Task

            PMNDirInfo dir = new PMNDirInfo(@"..\Debug");
            //dir.WriteCountOfFiles();
            //dir.WriteCreationTime();
            //dir.WriteCountOfSubdirectories();
            //dir.WriteListOfParentDirectories();

            #endregion Fourth Task

            #region Fifth Task

            //PMNFileManager.WriteListOfFilesAndDirectories(@"E:\");
            PMNFileManager.CreateDirectory(@"E:\PMNInspect");
            //PMNFileManager.CreateFile(@"E:\PMNInspect\PMNDirInfo.txt");
            //PMNFileManager.CopyFile(@"E:\PMNInspect\PMNDirInfo.txt", @"E:\PMNInspect\PMNNewDirInfo.txt");
            //PMNFileManager.DeleteFile(@"E:\PMNInspect\PMNDirInfo.txt");
            PMNFileManager.SaveStringInFile(@"E:\PMNInspect\example.txt", "Привет Андрей!");
            PMNFileManager.CopyFilesFromTo(@"E:\PMNInspect", @"E:\PMNInspect\PMNFiles\", @".txt");
            //PMNFileManager.CreateArchive(@"E:\PMNInspect\PMNFiles\", @"E:\PMNInspect\archive.zip");
            PMNFileManager.UnArchive(@"E:\PMNInspect\archive.zip", @"E:\PMNInspect\P");

            #endregion Fifth Task
        }
    }
}
