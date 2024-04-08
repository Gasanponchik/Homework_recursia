// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
int[] arr = new int[size];
int i = 0;

int[] RandomMas(int[] array, int num)
{
for (int i = 0; i < num; i++)
{
array[i] = new Random().Next(1, 100);
}
return array;
}

void PrintMas(int[] array)
{
foreach (int item in array)
{
System.Console.Write($"{item}\t");
}
}

void AntiMas(int[] array, int i)
{
if (array.Length - i == 0) return;

System.Console.Write($"{array[array.Length - 1 - i]}\t");

 AntiMas(array, ++i);
}

RandomMas(arr, size);
PrintMas(arr);
System.Console.WriteLine();
AntiMas(arr, i);
