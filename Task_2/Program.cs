// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] matrix = new int[4, 5];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void FillRndArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rand = new Random();
            matr[i, j] = rand.Next(0, 11);
        }
    }
}

FillRndArray(matrix);
PrintArray(matrix);

int sum0 = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    {
        sum0 += matrix[0, j];
    }
}

int sum1 = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    {
        sum1 += matrix[1, j];
    }
}

int sum2 = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    {
        sum2 += matrix[2, j];
    }
}

int sum3 = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    {
        sum3 += matrix[3, j];
    }
}

int[] Sums = { sum0, sum1, sum2, sum3 };
int min = Sums[0];
int minCount = 0;
for (int i = 0; i < Sums.Length; i++)
{
    if (min > Sums[i])
    {
        min = Sums[i];
        minCount = i;
        
    }
    
}
Console.WriteLine($"{minCount + " (подсчет с 0) строка с найменьшей суммой элементов"}");

