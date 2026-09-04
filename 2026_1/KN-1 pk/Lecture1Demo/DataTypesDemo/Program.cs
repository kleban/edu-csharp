
// ввести з клавіатури число, вивести корінь, якщо воно парне і пінести до квадрату
// якщо непарне

Console.Write("Input some number:\t");
//int num = Convert.ToInt32(Console.ReadLine());
int num = int.Parse(Console.ReadLine());

if(num % 2 == 0)
{
    //Console.WriteLine("Sqrt: " + Math.Sqrt(num));
    //Console.WriteLine("Sqrt: {0:0.000}", Math.Sqrt(num));
    Console.WriteLine($"Sqrt: {Math.Sqrt(num):f5}");
} 
else
{
    Console.WriteLine("^2: " + num*num);
}

//int num = 3;

//switch(num)
//{
//    case 1:       
//    case 2:        
//    case 3:         
//    case 4:       
//    case 5:
//        Console.WriteLine("Working");
//        break;
//    case 6: 
//    case 7: 
//        Console.WriteLine("Weekend");
//        break;
//    default: 
//        Console.WriteLine("Error");
//        break;
//}


//double c = 7.0, d = 3.0;

//Console.WriteLine(c%d);

//bool x = a > b;
//Console.WriteLine(x);

// and - &&, or - ||, not - !









// > < >= <= == != -> bool
