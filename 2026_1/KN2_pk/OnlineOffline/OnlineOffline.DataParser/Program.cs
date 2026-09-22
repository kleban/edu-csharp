using CsvHelper;
using OnlineOffline.Core;
using OnlineOffline.Core.Models;
using OnlineOffline.DataParser;
using System.Globalization;

var path = "online_vs_offline_learning_dataset.csv";

List<LearningCsvItem> items = null;

using (var reader = new StreamReader(path))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    items = csv.GetRecords<LearningCsvItem>().ToList();
}

var subjects = items.Select(x => x.Subject).Distinct().ToList();
var modes = items.Select(x => x.Learning_Mode).Distinct().ToList();

using (var ctx = new LearningContext())
{
    //ctx.Subjects.AddRange(subjects.Select(x => new Subject { Name = x }));   
    //ctx.Modes.AddRange(modes.Select(x => new LearningMode { Name = x }));

    foreach(var item in items)
    {
        var res = new LearningResult
        {
            ExamScore = item.Exam_Score,
            FocusLevel = item.Focus_Level,
            StudyHours = item.Study_Hours,
            RetentionScore = item.Retention_Score,
            Mode = ctx.Modes.FirstOrDefault(x => x.Name == item.Learning_Mode),
            Subject = ctx.Subjects.FirstOrDefault(x => x.Name == item.Subject)
        };

        ctx.Results.Add(res);
    }

    ctx.SaveChanges();
}


//items.Select(x => $"{x.Subject} ({x.Learning_Mode}): {x.Exam_Score}").ToList().ForEach(Console.WriteLine);