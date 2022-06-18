int[,] arrRes = GetArray(3, 3);

int[,] GetArray(int a, int b) //метод создания массива 
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);

        }
    }
    return array;
}

PrintArray(arrRes);

void PrintArray(int[,] array) // метод вывода массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
}

LineChangeArray(arrRes);

void LineChangeArray(int[,] array)
{
    int count = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (array[m, n] == array[m, n]
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[m, n] == array [i,j]) count++;
                }

            }

            Console.WriteLine($"| {array[m,n]} встречается {count} раз |");
            count = 0;
        }

    }

}
