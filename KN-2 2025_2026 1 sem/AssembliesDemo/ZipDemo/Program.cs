using Ionic.Zip;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
string folderPath = "E:\\edu-csharp\\KN-2 2025_2026 1 sem\\AssembliesDemo\\MathLibrary\\bin\\Debug\\net9.0";
using (ZipFile zip = new ZipFile())
{
    foreach (var file in new DirectoryInfo(folderPath).GetFiles())
    {
        zip.AddFile(file.FullName, "");
        Console.WriteLine($"File added: {file.Name}");
    }

    var zipPath = Path.Combine(folderPath, "zip.zip");
    zip.Save(zipPath);
    Console.WriteLine(zip);
}

