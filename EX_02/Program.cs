// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetLen(int number)
{
    
    int numLen = 0;
    int digit = number;
    while(digit != 0)
    {
        digit = digit / 10;
        numLen += 1;
    }
    return numLen;
}

Console.WriteLine(GetLen(num));