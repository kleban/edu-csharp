
// condition ? code if true : code if false

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.Write("Input number:\t");
//int number = int.Parse(Console.ReadLine());

////if (number % 2 == 0)
////    Console.WriteLine("парне");
////else
////    Console.WriteLine("непарне");

//string result = number % 2 == 0 ? "парне" : "непарне";

//Console.WriteLine(result);

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Input grade:\t");
int grade_int = int.Parse(Console.ReadLine());

string grade = grade_int < 20 ? "Повторне прослуховування курсу" : (grade_int >= 20 && grade_int < 61 ? "Нездача" : "Зарах");
Console.WriteLine(grade);