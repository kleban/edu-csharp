
DriveInfo[] drives = DriveInfo.GetDrives();

Console.WriteLine(drives[2].Name);

//DirectoryInfo dir = new DirectoryInfo(drives[2].Name);

//foreach (DirectoryInfo d in dir.GetDirectories())
//{
//    Console.WriteLine(d.FullName);
//}

//@"c:\users\yura\downloads" - verbatim string

DirectoryInfo dir = new DirectoryInfo("c:\\users\\yura\\downloads");

foreach(FileInfo f in dir.GetFiles("*check*.*"))
{
    Console.WriteLine(f.Name);
}
