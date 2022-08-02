// **Задача 53:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

// сделать одним фором

int m = 0;
int n = 0;
int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int [m,n];

void PrintArray ( int[,] arr)
{
    for ( int i = 0; i < m; i++)
    {
        for( int j =0; j < n; j++)
        {
            array[i,j] = new Random().Next(0, 10);
            Console.Write($"{array[i,j]} ");
        }
        Console.Write($"\n");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{   
   int c = array[0,i]; 
   array[0,i] = array[m-1, i];
   array[m-1, i] = c;
}
Console.WriteLine();
PrintArray(array);

/*
int n = 4;
int m = 4;
int[,] array = new int[n,m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i,j]} ");
    
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 1+i; j < m; j++)
    {
        int tmp = 0;
        tmp = array[i, j];
        array[i,j] = array[j, i];
        array[j,i] = tmp;
    }
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{array[i,j]} ");
    
    }
    Console.WriteLine();
}
*/
