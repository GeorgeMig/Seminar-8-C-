
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

LineChangeArray(arrRes); 

void LineChangeArray(int [,] array) // метод переводит строки в столбцы, а столбцы в строки
{
    int t = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            t = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = t;
        }

    }

}

Console.WriteLine();

PrintArray(arrRes);