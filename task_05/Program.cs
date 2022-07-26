/*
int maxNum = 20;

int a = 0;
while( a < maxNum)
{
    Console.Write($"{a} ");
    a++;
}
// 2 variant
for ( int i = 0; i < 20; i++)
{
    Console.Write($"{i} "); // Console.WriteLine(i + "");
}
// это для кубов
int N = 20;
for (int i = 0; i < N; i++)
{
    Console.Write($"{i} ");
}
// for внутри for
int M = 7;
int N = 7;
 for (int i = 0; i < M; i++)
 {
    for (int j = 0; j < N; j++)
    {
        Console.Write($"{new Random().Next(0, 10)}" );
    }
    Console.WriteLine();
 }
// выдает сумму от 1 до А
int GetSum(int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
    {
        sum +=i;
    }
    return sum;
}
int A = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма чисел от 1 до {A} = {GetSum(A)}");
 */
/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 

Console.WriteLine("Введите число: ");
int user = int.Parse(Console.ReadLine());

int GetNumber ( int a)
{
    int sum = 0;
   for ( int i = 0; a != 0; i++)
   {
           sum +=1;
           a = a / 10;
   }
   return sum;
}
Console.Write($"Количество цифр в {user} = {GetNumber(user)}"); 

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Console.WriteLine("Введите число: ");
int user = int.Parse(Console.ReadLine());

int GetMultiply ( int a)
{
    int sum = 1;
    for(int i = 1; i <= user; i++)
    {
        sum = sum * i;
    }
    return sum;
}
Console.Write($"Произведение цифр от 1 до {user} = {GetMultiply(user)}"); */

