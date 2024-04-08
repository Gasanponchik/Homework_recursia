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




