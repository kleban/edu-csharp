

using FiguresDemoApp.Models;

Shape[] shapes = new Shape[5]
{
    new Triangle(3,6,8),
    new EqTriangle(4),
    new Quad(4,5,6,7),
    new IsoscelesTriangle(4,6),
    new RightAngledTriangle(3,6)
};

foreach(var s in shapes)
{
    Console.WriteLine(s.P());
}
