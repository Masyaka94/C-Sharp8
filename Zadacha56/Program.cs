/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

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

int[] SumRows(int[,] matr)
{
    int [] ResultOfSum = new int[matr.GetLength(0)];
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        int sumRow = 0;
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            sumRow += matr[rows,columns];
        }
        ResultOfSum [rows] = sumRow;
    }
    return ResultOfSum;
}

Console.Write($"Введите размерность массива: ");
int m = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m,m];

FillArray(matrix);
PrintArray(matrix);
int[] sumRows = SumRows(matrix);
int minPos = sumRows[0];
int index = 0;
for (int i = 0; i < sumRows.Length; i++)
{
        if (sumRows[i]<minPos)
    {
        minPos = sumRows[i];
        index = i;
    }
}

Console.Write($"Минимальная сумма в строке {index} и равна {minPos}");
