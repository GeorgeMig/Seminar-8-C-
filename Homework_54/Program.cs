//программа, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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

SwichArray(arrRes);

void SwichArray(int[,] array) // метод упорядочивает элементы массива по убыванию.
{
    int temp = 0;
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] > array[i, j - 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = temp;

                }
            }
        }
    }

}


Console.WriteLine("Упорядоченные элементы двумерного массива");
Console.WriteLine();
PrintArray(arrRes);