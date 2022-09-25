// Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];

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

void PrintMatrix(double[,] matrix)
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

double[] AverageSumm(double[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average[i] = Math.Round((average[i] + matrix[j, i]/matrix.GetLength(0)),1);
        }
    }
    return average;
}

void PrintAverageSumm(double[] summ)
{
    for (int i = 0; i < summ.Length; i++)
    {
        Console.Write($"{summ[i],3} ");
    }
}

double[,] array2D = CreateMatrixRndInt(3, 4, -9, 9);
PrintMatrix(array2D);
Console.WriteLine("Среднее арифметическое каждого столбца:");
double[] summresult = AverageSumm(array2D);
PrintAverageSumm(summresult);
