
/* double b = 0;
double.TryParse(Console.ReadLine(), out b); // можно и парсе
Console.Write(b); 

 // int[] array = new int[12];

int sum = 0;

for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
}
foreach (int element in array)
{
    sum = sum + element;
    Console.Write($"{element} ");
}
Console.Write($"\nСумма всех элементов = {sum}");  

// int[] array;
array = new int[12];

int sum1 = 0; // +
int sum2= 0; // -
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]} ");
   array[i] *= -1;
}
Console.WriteLine();

foreach (int element in array)
    Console.Write(element + " "); 

    // создать массив и заполнить его от 1 до размера массива

    int[] array = new int [15];

    for ( int i = 0; i < 15; i++)
    {
        array[i] = i +1;
        Console.Write($"{array[i]} "); 
    }
   

// пусть изначально будет ввод числа и нам нужно создать функцию, которая будет искать наименьший делить, не 1 ( наименьшее число, на которое его можно будет разделить)

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

int LookingFor ( int ab)
{   
    for(int a = 2; a <= MathF.Sqrt(ab); a++)
    {
        if( ab % a == 0)
        {
            return a;
        }
    }
   return ab;
}
Console.WriteLine(LookingFor(n));   */