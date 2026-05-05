using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DataReadWright.Services
{
    public class StreamDataManager : IDataManager
    {
        public List<Student> LoadData(string filePath)
        {
            StreamReader reader = null;

            var list = new List<Student>();

            try
            {
                reader = new StreamReader(filePath);

                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    //  Anna Smith, 18, 86

                    var std = new Student
                    {
                        Name = parts[0].Trim(),
                        Age = int.Parse(parts[1].Trim()),
                        Grade = double.Parse(parts[2].Trim())
                    };
                    list.Add(std);
                }
            }
            catch(FormatException fex)
            {
                throw new Exception($"Error reading file: {fex.Message}");
            }
            catch(Exception ex)
            {
                throw new Exception("Error reading file: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return list;
        }

        public void SaveData(List<Student> std, string filePath)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(filePath);

                foreach (Student s in std)
                {
                    string line = $"{s.Name}, {s.Age}, {s.Grade}";
                    writer.WriteLine(line);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error writing file: " + ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Flush();
                    writer.Close();
                }
            }
        }
    }
}
