/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetNumber(string message)
{
    Console.WriteLine(message);
    double number = double.Parse(Console.ReadLine() ?? "");
    return number;
}

double FindCrossX(double a, double c, double b, double d)
{
    double x = (d - c) / (a - b);
    return x;
}

double FindCrossY (double b, double d, double x)
{
    double y = b*x + d;
    return y;
}


double firstB = GetNumber("Введите координату пересечения первой прямой с осью: ");
double firstK = GetNumber("Введите угловой коэфицент первой прямой: ");

double secondB = GetNumber("Введите координату пересечения второй прямой с осью: ");
double secondK = GetNumber("Введите угловой коэфицент второй прямой: ");


if ((firstK==secondK) && (firstB != secondB))
    Console.WriteLine("Прямые параллельны");
else if ((firstK==secondK) && (firstB == secondB))
    Console.WriteLine("Введена одна прямая");
else
{
    double x = FindCrossX(firstK, firstB, secondK, secondB);
    double y = FindCrossY(firstK, firstB, x);
    Console.WriteLine($"Точка пересечения: ({x},{y})");
}