/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

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

int[,] ComposMatrix(int[,] matr1, int[,] matr2)
{
    int[,] ResultMatr3 = new int[matr1.GetLength(0),matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                ResultMatr3[i,j] += (matr1[i,k])*(matr2[k,j]);
            }
        }
    }
    return ResultMatr3;
}



Console.Write($"Введите размерность  матриц: ");
int m = int.Parse(Console.ReadLine()!);
int[,] matrix1 = new int[m,m];
int[,] matrix2 = new int[m,m];


FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
int[,] composMatrix = ComposMatrix(matrix1,matrix2);
Console.WriteLine($"Произведение матриц равно: ");
PrintArray(composMatrix);