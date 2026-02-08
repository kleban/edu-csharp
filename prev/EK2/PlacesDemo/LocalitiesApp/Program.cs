
using LocalitiesApp;

var _manager = new DataManager();
var _input = new InputManager();
var data = _manager.GetInitialData();
int input = 0;
while (input != 100)
{
    Console.WriteLine("\n ----- NAVIGATION -----\n");
    Console.WriteLine(" ----- country -----");
    Console.WriteLine("\t11 - Show countries");
    Console.WriteLine("\t12 - Add country");
    Console.WriteLine("\t13 - Remove country");
    Console.WriteLine(" ----- region -----");
    Console.WriteLine("\t21 - Show regions");
    Console.WriteLine("\t22 - Add region");
    Console.WriteLine("\t23 - Remove region");
    Console.Write("\t\t Make your choise:\t");

    input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 11:
            _input.ShowCountries(data);
            break;
        case 12:
            var newCountry = _input.CreateCountry();
            data = _manager.AddCountry(data, newCountry);
            Console.WriteLine("Country added to list");
            break;
        case 21:
            _input.ShowRegions(data);
            break;
        default:
            Console.WriteLine("Error!");
            break;
    }
}



