// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.


void ReturnElements()
{
    int[] array = new int[8] {0, 0, 0, 0, 0, 0, 0, 0};
    for(int i = 0; i < 8; i++)
    {
        int num = new Random().Next(2);
        array[i] = num;
        Console.Write($"{array[i]} ");
    }
}

ReturnElements();