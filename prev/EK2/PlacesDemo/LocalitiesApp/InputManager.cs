using LocalitiesApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalitiesApp
{
    public class InputManager
    {
        public void ShowCountries(Country[] countries, bool withIndex = false)
        {
            int index = 1;
            foreach (Country country in countries)
            {
                if (!withIndex)
                    Console.WriteLine(country);
                else
                    Console.WriteLine($"{index++} - {country}");
            }
        }

        public Country CreateCountry()
        {
            Console.Write("Input name: \t");
            string name = Console.ReadLine();
            Console.Write("Input population: \t");
            int pop = int.Parse(Console.ReadLine());
            Console.Write("Input country code: \t");
            string code = Console.ReadLine();

            return new Country { Name = name, Population = pop, CountryCode = code };
        }

        public void ShowRegions(Country[] data)
        {
            Console.Write("Choose country:");
            ShowCountries(data, true);
            int num = int.Parse(Console.ReadLine());

            foreach (Region r in data[num - 1].Regions)
            {
                Console.WriteLine(r);
            }
        }
    }
}
