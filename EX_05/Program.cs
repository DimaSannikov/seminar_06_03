// Бинарный поиск

int getPositionArray(int num, int[] numbs)
{
    int pos1 = 0;
    int pos2 = numbs.Length-1;
    while (pos1 != pos2)
    {
        int midPos = (pos1 + pos2)/2;
        if (numbs[midPos] == num)
        {
            return midPos;
        }
        if(numbs[midPos] < num)
        {
            pos1 = midPos;
        }
        else
        {
            pos2 = midPos;
        }
    }

    return -1;
}

int[] numbs = new int[8] {1,3,4,5,6,8,9,10};
Array.Sort(numbs);
Console.Write("Введите число :");
int num = int.Parse(Console.ReadLine());
int position = getPositionArray(num, numbs);
Console.WriteLine(position+1);