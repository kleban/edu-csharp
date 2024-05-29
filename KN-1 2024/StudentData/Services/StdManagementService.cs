using StudentData.Exceptions;
using StudentData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Services
{
    public class StdManagementService
    {
        public static List<Student> Read(string path)
        {
            var list = new List<Student>();

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(path);

                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    var items = line.Split(";");
                    try


                        var student = new Student
                        {
                            Id = int.Parse(items[0]),
                            Name = items[1],
                            Group = items[2],
                            AvgGrade = double.Parse(items[3].Replace(".", ","))
                        };
                    list.Add(student);

                    if (student.AvgGrade > 100)
                        throw new GradeMoreThan100Exception(student);

                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader is not null)
                    reader.Close();
            }

            return list;
        }

        public static void Save(string fileName, List<Student> students)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(fileName);
                students.ForEach(s => writer.WriteLine($"{s.Id};{s.Name};{s.Group};{s.AvgGrade}"));
            }
            catch
            {
                throw;
            }
            finally
            {
                if (writer is not null)
                {
                    writer.Flush();
                    writer.Close();
                }
            }
        }

    }
}
