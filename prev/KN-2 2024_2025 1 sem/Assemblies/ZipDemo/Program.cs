
using Ionic.Zip;

string folderPath = "E:\\edu-csharp\\KN-2 2024_2025 1 sem\\Assemblies\\MathLibrary\\bin\\Release\\net8.0";
using (ZipFile zip = new ZipFile())
{
    foreach(var file in new DirectoryInfo(folderPath).GetFiles())
    {
        zip.AddFile(file.FullName, "");
        Console.WriteLine($"File added: {file.Name}");
    }

    var zipPath = Path.Combine(folderPath, "zip.zip");
    zip.Save(zipPath);
    Console.WriteLine(zip);
}

Console.WriteLine("DONE");