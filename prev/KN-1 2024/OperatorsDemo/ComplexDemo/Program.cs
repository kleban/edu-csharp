

using ComplexDemo;

ComplexNumber number1 = new ComplexNumber(5, -2);
ComplexNumber number2 = new ComplexNumber(-2, 6);
ComplexNumber number3 = new ComplexNumber(-1, 1);

//ComplexNumber result = ComplexNumber.Plus(number1, number2);
//result = ComplexNumber.Plus(result, number3);

ComplexNumber result = number1 + number2 + number3;

Console.WriteLine(result);
