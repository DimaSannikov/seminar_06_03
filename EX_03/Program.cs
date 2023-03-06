// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.

int GetMulti(int startNumber, int endNumber)
{
    int multi = 1;
    for(int i = startNumber; i <= endNumber; i++)
    {
        multi *= i;
    }
    
    return multi;
}


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int multi = GetMulti(1, num);
Console.WriteLine(multi);