
string path = @"G:\worldbank-reproducible-package";

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
