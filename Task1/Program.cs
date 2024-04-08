// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

System.Console.Write("Введите начальное число: ");
int firstNum = Convert.ToInt32(Console.ReadLine()!);

System.Console.Write("Введите последнее число: ");
int theEndNum = Convert.ToInt32(Console.ReadLine()!);

int Digit(int firstNum, int theEndNum)
{
if(firstNum == theEndNum) return firstNum;
Console.Write($"{firstNum}\t");
return Digit(firstNum + 1,theEndNum);
}

System.Console.WriteLine(Digit(firstNum,theEndNum));


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

