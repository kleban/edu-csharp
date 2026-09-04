using System.IO;

DriveInfo[] drives = DriveInfo.GetDrives();

foreach (DriveInfo drive in drives)
{
    Console.WriteLine($"Name: {drive.Name}");
    Console.WriteLine($"Type: {drive.DriveType}");
    Console.WriteLine($"Format: {drive.DriveFormat}");
    Console.WriteLine($"Free/Total Space: {toGb(drive.TotalFreeSpace)}/{toGb(drive.TotalSize)} Gb");
}

double toGb(long bytes)
{
    return Math.Round(bytes / 1024.0 / 1024.0 / 1024.0, 0);
}
