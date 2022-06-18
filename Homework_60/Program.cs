//программа, которая создает трехмерный массив

int[,,] arrRes = GetArray(3, 3, 3);

int[,,] GetArray(int a, int b, int c) //метод создания трехмерного массива 
{
    int[,,] array = new int[a, b, c];
    //Random rnd = new Random();
    int n = 10;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                //array[m, i, j] = rnd.Next(1, 10);
                n++;
                array[m, i, j] = n;
            }
        }
    }
    return array;
}

Console.WriteLine();
Console.WriteLine("Трехмерный массив с индексами:");

PrintArray(arrRes);

void PrintArray(int[,,] array) // метод вывода массива в терминал
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        Console.WriteLine();
        Console.Write("~" + m + "~");
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write("_|" + k + "|");
        }
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write("|" + i + "|");

            for (int j = 0; j < array.GetLength(2); j++)
            {

                Console.Write(" " + array[m, i, j] + " ");

            }
            Console.WriteLine();
        }
        
    }

}

Console.WriteLine();
