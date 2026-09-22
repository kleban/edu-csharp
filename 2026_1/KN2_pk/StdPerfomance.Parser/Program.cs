
using CsvHelper;
using StdPerfomance.Core;
using StdPerfomance.Parser.Models;
using System.Globalization;
using StdPerfomance.Core.Entities;

var data = new List<StudentScoreReadItem>();

using (var reader = new StreamReader("student_stress_dataset.csv"))
using (var csv = new CsvReader(reader, new CultureInfo("en")))
{
    data = csv.GetRecords<StudentScoreReadItem>().ToList();
    Console.WriteLine("Data Reading Finished");
}

using (var ctx = new DataContext())
{
    var levels = data.Select(x => x.stress_level).Distinct().ToList();

    foreach (var level in levels)
    {
        if (!ctx.StressLevels.Any(x => x.Title == level))
        {
            ctx.StressLevels.Add(new StressLevel { Title = level });
            ctx.SaveChanges();
        }
    }

    Console.WriteLine("Levels Added!");

    foreach (var item in data)
    {
        ctx.StudentScores.Add(new StudentScore
        {
            Name = item.name,
            ExamScore = item.exam_score,
            SleepHours = item.sleep_hours,
            SocialMediaHours = item.social_media_hours,
            StudyHours = item.study_hours,
            StressLevel = ctx.StressLevels.FirstOrDefault(x => x.Title == item.stress_level)
        });

    }

    ctx.SaveChanges();
    Console.WriteLine("Scores Added!");
}

