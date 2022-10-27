// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter number a :");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b :");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    {
    Console.WriteLine($"a = {num1}, b = {num2} -> max = {num1}");
    }
else if (num1 < num2)
    {
    Console.WriteLine($"a = {num1}, b = {num2} -> max = {num2}");
    }
else Console.WriteLine($"a = {num1}, b = {num2} -> числа равны");

