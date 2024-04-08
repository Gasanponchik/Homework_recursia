// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ack(int n, int m)
{
if (n == 0) return m + 1;
else if (m == 0) return Ack(n - 1, 1);
else return Ack(n - 1, Ack(n,m - 1));
}

System.Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Ack(n,m));


