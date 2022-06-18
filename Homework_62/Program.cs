int[,] arr = GetArray(4, 4); // создаем массив 4х4

int[,] GetArray(int row, int col) //метод заполнения массива по спирали
{
    int n = 10;
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            n++;
            array[i, j] = n;
        }
        break;
    }

    for (int i = 3; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            n++;
            array[j, i] = n;
        }
        break;
    }

    for (int i = 3; i < array.GetLength(0); i++)
    {
        for (int j = 2; j >= 0; j--)
        {
            n++;
            array[i, j] = n;
        }
        break;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 2; j > 0; j--)
        {
            n++;
            array[j, i] = n;
        }
        break;
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1) - 1; j++)
        {
            n++;
            array[i, j] = n;
        }
        break;
    }

    for (int i = 2; i < array.GetLength(0); i++)
    {
        for (int j = 2; j >= 1; j--)
        {
            n++;
            array[i, j] = n;
        }
        break;
    }

    return array;
}



PrintArray(arr);

void PrintArray(int[,] array) // метод вывода массива в терминал
{
    Console.WriteLine("Массив 4х4, заполненный спирально: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("|");
            Console.Write(array[i, j]);
            Console.Write("|");

        }
        Console.WriteLine();
    }
}