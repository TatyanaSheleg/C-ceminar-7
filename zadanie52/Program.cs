// Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int a = 3; //rows
int b = 6;//colums

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

double[] AverageSumm(int[,] matrix, int c, int d)
{
    double[] average = new double[d];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average[i] = average[i] + matrix[j, i]; //average[i] = (average[i] + matrix[j, i])/c-выдает какую-то ерунду... Почему, что не так?
        }
    }
    return average;
}

void PrintAverageSumm(double[] summ)
{
    for (int i = 0; i < summ.Length; i++)
    {
        Console.Write($"{summ[i],4} ");
    }
}

int[,] array2D = CreateMatrixRndInt(a, b, -9, 9);
PrintMatrix(array2D);
Console.WriteLine("-----------------------------");
double[] summresult = AverageSumm(array2D, a, b);
PrintAverageSumm(summresult);
