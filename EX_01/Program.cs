// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от A до B.


int GetSum(int startNumber, int endNumber)
{
    int sum = 0;
    for(int i = startNumber; i <= endNumber; i++)
    {
        sum += i;
    }
    
    return sum;
}


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int sum = GetSum(1, num);
Console.WriteLine(sum);