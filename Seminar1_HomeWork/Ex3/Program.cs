//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Enter number a :");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1%2 == 0)
    {
    Console.WriteLine($"{num1} -> да");   
    }
else Console.WriteLine($"{num1} -> нет");