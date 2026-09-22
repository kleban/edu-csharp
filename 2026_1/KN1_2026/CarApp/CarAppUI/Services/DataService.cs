using CarAppUI.Exceptions;
using CarAppUI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarAppUI.Services
{
    public class DataService
    {
        public List<Car> Read(string path)
        {

            StreamReader reader = null;
            List<Car> list = new();

            try
            {
                reader = new StreamReader(path);

                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    Car car = new Car
                    {
                        Model = parts[0],
                        Mark = parts[1],
                        Year = int.Parse(parts[2]),
                        RegisterDate = DateTime.Parse(parts[3]),
                        Price = double.Parse(parts[4])
                    };

                    list.Add(car);
                }
            }
            catch (Exception ex)
            {
                throw new CarFileFormatException("Помилка формату файлу *.car", path);

            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return list;
        }

        public void Write(string path, List<Car> cars)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path);
                foreach (Car car in cars)
                {
                    writer.WriteLine($"{car.Model}|{car.Mark}|{car.Year}|{car.RegisterDate}|{car.Price}");
                }
            }
            catch
            {
                throw new Exception("Помилка запису файлу!");
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

        //public List<Car> Generate()
        //{
        //    return new List<Car>
        //    {
        //        new Models.Car { Model = "Model S", Mark = "Tesla", Year = 2020, RegisterDate = new DateTime(2020, 1, 1), Price = 79999 },
        //        new Models.Car { Model = "Mustang", Mark = "Ford", Year = 2018, RegisterDate = new DateTime(2018, 5, 15), Price = 55999 },
        //        new Models.Car { Model = "Civic", Mark = "Honda", Year = 2019, RegisterDate = new DateTime(2019, 3, 10), Price = 22999 },
        //        new Models.Car { Model = "Corolla", Mark = "Toyota", Year = 2021, RegisterDate = new DateTime(2021, 7, 20), Price = 19999 }
        //    };
        //}
    }
}
