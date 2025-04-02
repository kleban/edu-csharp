//Створити ієрархію класів: фігура, трикутник, чотирикутник, квадрат,
//прямокутник, трапеція, рінобедрений трикутник, прямокутний трикутник,
//рівносторонній трикутник. Оптимізувати обчислення площі (S) та
//периметра (P) для кожної фігури. 


// Figura <- Triangle
// Figura <- Quadrilateral
// Triangle <- IsoscelesTriangle
// Triangle <- RightTriangle
// Triangle <- EquilateralTriangle
// Figura <- Quadrilateral <- Rectangle <- Square
// Quadrilateral <- Trapezoid

using FiguresDemo.Models;

Figure[] figures = new Figure[]
{
    new Rectangle(3, 4),
    new Square(3),
    new Quadrilateral(4,5,2,5)
};

foreach (var figure in figures)
{
    Console.WriteLine(figure);
}