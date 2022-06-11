// ПРОГРАММА СОЗДАЕТ ДВУМЕРНЫЙ МАССИВ, ВЫВОДИТ ЕГО НА ЭКРАН, ЗАТЕМ МЕНЯЕТ  МЕСТАМИ ЗНАЧЕНИЯ ПЕРВОЙ И ПОСЛЕДНЕЙ СТРОК МАССИВА  И ВЫВОДИТ ИЗМЕНЕННЫЙ МАССИВ НА ЭКРАН

int[,] GetArray(int a, int b)
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

int[,] arrRes = GetArray(5, 5); //метод создания массива 

Console.WriteLine("Исходный массив");
Console.WriteLine();

PrintArray(arrRes);// печать массива

Console.WriteLine();

void LineChangeArray(int [,] array)
{
    int t = 0;
    for (int i = 0; i < array.GetLength(0);)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            t = array[i, j];
            array[i, j] = array[array.GetLength(1) - 1, j];
            array[array.GetLength(1) - 1, j] = t;

        }

        break;
    }

}

LineChangeArray(arrRes); // метод меняет местами значения первой и последней строчек массива.

void PrintArray(int[,] array)
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

Console.WriteLine("Измененный массив");
Console.WriteLine();
PrintArray(arrRes);// печать массива