// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.WriteLine("Введите число строк массивов m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массивов n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int[,] table = new int[m, n];

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
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rand = new Random();
            matr[i, j] = rand.Next(1, 11);
        }
    }
}
FillArray(matrix);
FillArray(table);
PrintArray(matrix);
Console.WriteLine();
PrintArray(table);

int[,] newmatrix = new int[m, n];

{
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {

            newmatrix[i, j] = matrix[i, j] * table[i, j];
        }
    }
}
Console.WriteLine();
PrintArray(newmatrix);
