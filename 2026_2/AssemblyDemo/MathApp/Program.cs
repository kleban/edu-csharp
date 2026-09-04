using Ionic.Zip;

string folderPath = "E:\\edu-csharp\\2026_2\\AssemblyDemo\\MathLib\\bin\\Debug\\net10.0";

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


//using MathLib;

//Fraction f1 = new Fraction(1,2);
//Fraction f2 = new Fraction(1,3);
//Fraction f3 = f1 + f2;

//Console.WriteLine(f3);