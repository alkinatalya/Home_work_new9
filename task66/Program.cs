/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.WriteLine("Введите первое число:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int n = int.Parse(Console.ReadLine()!);
System.Console.Write("Все натуральные числа от M до :");
 int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
void PrintSumm(int m, int n, int summ)
{
   summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}
PrintSumm(m, n, temp=0);
