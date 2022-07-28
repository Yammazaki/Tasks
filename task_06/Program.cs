 /* int size = 0;
Console.WriteLine($"Введите размер массива: ");
int[] array = new int[size];

int i = 0;
while(i < size) // = array.Length
{
    Console.Write($"Введите [{i}] элемент: ");
    int temp = int.Parse(Console.ReadLine());
    array[i] = temp;
    i++;
}
for(int j = 0; j < size; j++)
{
    Console.Write($"{array[j]}");
}
// это получается наша ДЗ 3 */


Console.WriteLine($"Введите размер массива: "); // вводим программу на проверки ввода данных
int size = 0;
bool check = false; // если сможет проверить, то true, а если нет, то false

string userEnter = Console.ReadLine();

check = int.TryParse(userEnter, out size); // то что переводим(userEnter), в куда ( в size) получается, что в инт siz'a

if (check == true) // check сама по себе хранит тру или фолс так что можно if (check) или if(!check) = это проверка на символы
{
    Console.Write($"Ваше число = {size}");
}
else
{
    Console.Write($"Вы неправильно ввели данные!!!");
}
 /* if ('A' < 'a')
Console.WriteLine("Done"); // а тут проверка по таблице аски */

for (int i = 0; i < userEnter.Length; i++)
if (userEnter[i] < '0' || userEnter[i] > '9')
Console.Write("\nПровал"); // это как работает проверка на тру и фолс именно по цифрам, у 0 - 48 строка, а у 9 - 57

