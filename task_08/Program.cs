/* int m = 0;
int n = 0;
int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];              // array[1][2]

for (int i =0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,  j] = new Random().Next(10);
    
    }
}
void PrintArray(int[,] array)
{
    for (int i =0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
}
PrintArray(array);        */


// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

/*
int m = 0;
int n = 0;
int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];

void Answer (int[,] array)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,  j] = i+j;
        Console.Write($"{array[i,  j]} ");
    }
    Console.WriteLine();
}
}

void WeAreLookingFor ( int[,] array)
{
    for (int i = 0; i < m; i+=2)
    {
        for (int j = 0; j < n; j+=2)
    {
        array[i,  j] = array[i, j] * array[i, j]; 
        Console.Write($"{array[i,  j]} ");
    }
     Console.WriteLine();
    }
}
Answer(array);
WeAreLookingFor(array);  */


int m = 0;
int n = 0;
int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];

for (int i =0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,  j] = new Random().Next(10);
    
    }
}
void PrintArray(int[,] array)
{
    for (int i =0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
}
PrintArray(array); 