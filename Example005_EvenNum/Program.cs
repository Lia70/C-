// Задача 8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n1; i += 2)
    Console.WriteLine(i);
    