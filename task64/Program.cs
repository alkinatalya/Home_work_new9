/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью 
рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.WriteLine("Введите число от которого нужно вывести числа до 1:");
int n = int.Parse(Console.ReadLine()!);
System.Console.Write($" Все натуральные числа от{n}  до 1:");
System.Console.WriteLine();
void Rec(int n)
{
    System.Console.Write(n);
    if (n <= 1)
    {
        System.Console.WriteLine();
        return;
    }
    System.Console.Write(", ");
    Rec(n - 1);
    return;
}
Rec(n);
