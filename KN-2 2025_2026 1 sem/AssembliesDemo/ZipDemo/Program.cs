using System.IO.Compression;
using System.Text;

string zipPath = @"d:\zip_demo\MyArchive.zip";
/*string folderPath = @"d:\website";

using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
{
    foreach(var file in Directory.GetFiles(folderPath))
    {        
        archive.CreateEntryFromFile(file, Path.GetFileName(file));
        Console.WriteLine($"file added to archive: {file}");
    }
}

Console.WriteLine("Complete!");*/

string extractPath = @"d:\zip_demo\extracted";

ZipFile.ExtractToDirectory(zipPath, extractPath);

Console.WriteLine($"Archive '{zipPath}' has been extracted to '{extractPath}'.");