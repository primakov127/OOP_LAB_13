using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_13
{
    static class PMNDiskInfo
    {
        static public void WriteFreeDiskSpace()
        {
            var disks = DriveInfo.GetDrives();
            Console.WriteLine("+Disk Name:\t\tFree Space:");
            foreach(var disk in disks)
            {
                Console.WriteLine($"{disk.Name, 9}\t\t {disk.AvailableFreeSpace/1e9:F2} GB");
                
            }
        }

        static public void WriteDriverFormat()
        {
            var disks = DriveInfo.GetDrives();
            Console.WriteLine("+Disk Name:\t\tDrive Format:");
            foreach (var disk in disks)
            {
                Console.WriteLine($"{disk.Name,9}\t\t    {disk.DriveFormat, 8}");

            }
        }

        static public void WriteAllDiskInfo()
        {
            var disks = DriveInfo.GetDrives();
            Console.WriteLine("+Disk Name:\t\tTotal size:\t\tFree Space:");
            foreach (var disk in disks)
            {
                Console.WriteLine($"{disk.Name,9}\t\t {disk.TotalSize/1e9:F2} GB\t\t {disk.TotalFreeSpace/1e9:F2} GB");

            }
        }
    }
}
