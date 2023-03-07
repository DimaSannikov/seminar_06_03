// Напишите программу, которая принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.

double GetDegree(int number, int degree)
{
    double newNum = Math.Pow(number, degree);
    return newNum;
}

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Введите еще одно целое число: ");
int deg = int.Parse(Console.ReadLine());

double newNum = GetDegree(num, deg);
Console.WriteLine(newNum);