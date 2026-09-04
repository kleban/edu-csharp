
using Microsoft.VisualBasic.FileIO;

string path = @"H:\worldbank-reproducible-package";

DirectoryInfo dir = new DirectoryInfo(path);

Console.WriteLine("---- Folders:");
foreach(var d in dir.GetDirectories())
{
    Console.WriteLine($"\t{d.Name}");
}

Console.WriteLine("\n---- Files:");
foreach (var f in dir.GetFiles("*.md"))
{
    Console.WriteLine($"\t{f.Name}");
}

//Console.Write("\nInput new folder name:\t");
//string newFolderName = Console.ReadLine() ?? "New Folder";
//dir.CreateSubdirectory(newFolderName);
//Console.WriteLine($"New subfolder created: {newFolderName}");

string pathfrom = @"H:\nlp-job-wb\package\code";
string pathto = @"f:\111";

//DirectoryInfo dir2 = new DirectoryInfo(pathfrom);
//dir2.
//dir.(Path.Combine(pathto, dir2.Name));

//Console.WriteLine("Moved");

//FileSystem.CopyDirectory(pathfrom, pathto);