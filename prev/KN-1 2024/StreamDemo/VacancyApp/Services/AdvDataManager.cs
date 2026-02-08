using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyApp.Exceptions;
using VacancyApp.Models;

namespace VacancyApp.Services
{
    public class AdvDataManager
    {
        public static List<Adv> Read(string path)
        {
            var list = new List<Adv>();

            /*using (StreamReader r = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] items = line.Split(";");

                    var adv = new Adv
                    {
                        Id = int.Parse(items[0]),
                        Name = items[1],
                        Company = items[2],
                        Salary = double.Parse(items[3].Replace(".", ","))
                    };

                    if (adv.Salary < 0)
                        throw new NegativeSalaryExeception(adv);

                    list.Add(adv);
                }
            }*/

                StreamReader reader = null;

            try
            {
                reader = new StreamReader(path);

                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] items = line.Split(";");

                    var adv = new Adv
                    {
                        Id = int.Parse(items[0]),
                        Name = items[1],
                        Company = items[2],
                        Salary = double.Parse(items[3].Replace(".", ","))
                    };

                    if (adv.Salary < 0)
                        throw new NegativeSalaryExeception(adv);

                    list.Add(adv);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }

            return list;
        }

        public static void Save(string fileName, List<Adv> advs)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(fileName);
                advs.ForEach(a => writer.WriteLine($"{a.Id};{a.Name};{a.Company};{a.Salary}"));
            }
            catch
            {
                throw;
            }
            finally
            {
                if(writer is not null)
                {
                    writer.Flush();
                    writer.Close();
                }
            }
        }
    }
}
