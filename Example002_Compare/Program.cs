// Задача 1. Напишите программу, которая на вход принимает два числа,
// а на выход выдает какое число большее, а какое меньшее

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine(a);
else 
    Console.WriteLine(b);

