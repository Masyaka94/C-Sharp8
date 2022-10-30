/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

void FillArray(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            for (int columns1 = 0; columns1 < matr.GetLength(1); columns1++)
            {
                if (matr[rows, columns] >= matr[rows, columns1])
                {
                    int temp = matr[rows, columns];
                    matr[rows, columns] = matr[rows, columns1];
                    matr[rows, columns1] = temp;
                }
            }
        }
    }
}

Console.Write($"Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write($"Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SortArray(matrix);
PrintArray(matrix);