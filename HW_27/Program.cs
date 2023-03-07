// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int GetSum(int num)
{
    int sum = 0;
    int newNum = num;
    while(newNum != 0)
    {
        int digit = newNum % 10;
        newNum = newNum / 10;
        sum += digit;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(GetSum(number));