// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter number a :");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b :");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b :");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine($"a = {num1}, b = {num2}, c = {num3} -> max = {max}");