int[,] arrRes = GetArray(5, 5);

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

FindMinChangeandDelLineArray (arrRes);

void FindMinChangeandDelLineArray(int[,] array) // поиск минимального в массиве
{
    int min = array [0,0];
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i,j] < min)
            {
                min = array [i,j];
                imin = i;
                jmin = j;
            }
        }

    }
    Console.WriteLine($"минимальное значение массива {min} и его координаты:{imin}, {jmin}");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != imin && j != jmin)
            {
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();

    }
} 

