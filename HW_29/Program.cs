// Напишите программу, которая задаёт массив
// из N элементов и выводит их на экран.

void ReturnElements(int number, int len)
{
    int[] array = new int[len];
    for(int i = 0; i < len; i++)
    {
        int num = new Random().Next(number);
        array[i] = num;
    }
    Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
}

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Задайте длину массива: ");
int len = int.Parse(Console.ReadLine());

ReturnElements(number, len);