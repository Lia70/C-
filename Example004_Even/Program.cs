// Задача 6. Напишите программу, которая на вход принимает число
// выдает, является ли число четным

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
  Console.WriteLine("Yes");
else
  Console.WriteLine("No");

