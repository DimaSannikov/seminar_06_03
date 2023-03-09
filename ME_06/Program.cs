// Программа создает массив после того как принимает некоторое число,
// которое в массиве может быть максимальным,
// Далее программа принимает число которое задает длину массива.
// Затем программа сортирует массив вставками.
// После ищет есть ли следующее введенное пользователем число в
// массиве с помощью бинарного поиска


int[] MakeArray(int number, int len)
{
    int[] array = new int[len];
    for(int i = 0; i < len; i++)
    {
        int num = new Random().Next(number);
        array[i] = num;
    }
    return array;
}


int[] SortArray(int[] array)
{
    int[] newArray = array;
    int beforeElem = 0;
    int sortElem = 1;
    int newElem = 0;

    while(sortElem < newArray.Length)
    {
        if(newArray[sortElem] < newArray[beforeElem])
        {
            newElem = newArray[beforeElem];
            newArray[beforeElem] = newArray[sortElem];
            newArray[sortElem] = newElem;
            
            if(sortElem > 1)
            {
                sortElem -= 1;
                beforeElem -= 1;
            }
        }
        else
        {
            sortElem += 1;
            beforeElem += 1;
        }
    }
    
    return newArray;
}


void SearchArrElem(int num, int[] arr)
{
    int firstArray = 0;
    int lastArray = arr.Length;

    while(firstArray + 1 != lastArray)
    {
        int midArray = (firstArray + lastArray) / 2;
        if(num == arr[midArray])
        {
            Console.WriteLine($"Число {num} есть в массиве");
            break;
        }
        else
        {
            if(num > arr[midArray])
            {
                firstArray = midArray;
            }
            else
            {
                lastArray = midArray;
            }
        }

        // Console.WriteLine($"first - {firstArray}, mid {midArray}, last - {lastArray}");

        if(firstArray + 1 == lastArray)
        {
            Console.WriteLine($"Числа {num} нет в массиве");
        }
    }
}


Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Задайте длину массива: ");
int len = int.Parse(Console.ReadLine());

Console.Write("Введите число для поиска в массиве: ");
int searchNum = int.Parse(Console.ReadLine());

int[] arr = MakeArray(number, len);

// Console.WriteLine("["+$"{String.Join(", ", arr)}"+"]");

int[] sortedArr = SortArray(arr);

Console.WriteLine("["+$"{String.Join(", ", sortedArr)}"+"]");

SearchArrElem(searchNum, sortedArr);