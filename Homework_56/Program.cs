//программа, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int[,] arrRes = GetArray(6, 7);

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

Console.WriteLine("Массив:");
Console.WriteLine();

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

Console.WriteLine();

FindminsumElementlinesArray(arrRes);

void FindminsumElementlinesArray(int[,] array) // метод упорядочивает элементы массива по убыванию.
{
    int[] arrsum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];

        }
        arrsum[i] = sum;
    }

    int minsumline = 0;
    int minsum = arrsum[0];
    for (int i = 0; i < arrsum.Length; i++)
    {
        if (minsum > arrsum [i])
        {
            minsum = arrsum[i];
            minsumline = i + 1;
        }
        else if (minsum == arrsum [0])
        {
            minsumline = 1;
        }
    }

    Console.WriteLine($"Наименьшая сумма ({minsum}) элементов в строке: {minsumline}");

}





