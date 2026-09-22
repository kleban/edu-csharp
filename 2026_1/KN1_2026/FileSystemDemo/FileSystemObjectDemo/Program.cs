using System;
using System.Text;
using System.IO;

DriveInfo[] drives = DriveInfo.GetDrives();

foreach (DriveInfo drive in drives)
{
    Console.WriteLine($"Drive: {drive.Name}");
    Console.WriteLine($"  Type: {drive.DriveType}");

    if (drive.IsReady)
    {
        Console.WriteLine($"  Volume Label: {drive.VolumeLabel}");
        Console.WriteLine($"  File System: {drive.DriveFormat}");
        Console.WriteLine($"  Available Free Space: {getGb(drive.AvailableFreeSpace)} Gb");
        Console.WriteLine($"  Total Free Space: {getGb(drive.TotalFreeSpace)} Gb");
        Console.WriteLine($"  Total Size: {getGb(drive.TotalSize)} Gb");
    }
    else
    {
        Console.WriteLine("  Drive is not ready.");
    }
}

double getGb(long size)
{
    return Math.Round(size / (1024.0 * 1024.0 * 1024.0), 0);
}

