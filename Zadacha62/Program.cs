/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
            Console.Write($" {array[i, j]} "); 
        Console.WriteLine(); 
    } 
} 
int n = 4; 
int[,] Array = new int [n,n]; 
int value = 1; 
 
for (int j = 0; j < n; j++) 
{ 
    Array[0,j]=value++; 
} 
for (int i = 1; i < n; i++) 
{ 
    Array[i,n-1] = value++; 
} 
for (int j = n-2; j > -1; j--) 
{ 
    Array[n-1,j]=value++; 
} 
for (int i = n-2; i > 0; i--) 
{ 
    Array[i,0] = value++; 
} 
for (int j = 1; j < n-1; j++) 
{ 
    Array[1,j]=value++; 
} 
for (int i = n-2; i >1 ; i--) 
{ 
    Array[i,(n-2)] = value++; 
} 
for (int j = n-3; j >0; j--) 
{ 
    Array[n-2,j]=value++; 
} 
 
 
PrintArray(Array);