//программа, которая cоздает две матрицы и находит их произведение;


Console.Write("Введите количество строк в матрице (ВНИМАНИЕ! кол-во строк должно быть больше на единицу, чем столбцов): ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице(ВНИМАНИЕ! кол-во стобцов должно быть меньше на единицу, чем строк): ");
int b = int.Parse(Console.ReadLine());

int[,] matrix1 = GetArray(a, b); // создаем первую матрицу;

int[,] matrix2 = GetArray(b, a); // создаем вторую матрицу

int[,] GetArray(int row, int col) //метод создания массива (матрицы)
{
    int[,] array = new int[row, col];
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

Console.WriteLine();
Console.WriteLine("Матрица 1:");
Console.WriteLine();

PrintArray(matrix1); // выводим матрицу 1

Console.WriteLine();
Console.WriteLine("Матрица 2:");
Console.WriteLine();

PrintArray(matrix2); // выводим матрицу 2

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

Findmultiplmatrixs(matrix1, matrix2);

void Findmultiplmatrixs(int[,] array1, int [,] array2) // метод находит произведение двух матриц;
{
    int[,] matrixmultipl = new int[a, a];
    for (int m = 0; m < a; m++)
    {
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matrixmultipl[m, i] += array1[m, j] * array2[j, i];

            }

        }
    }

    Console.WriteLine("Произведение матриц:");
    Console.WriteLine();

    PrintArray(matrixmultipl); // выводим произведение двух матриц;

}

