//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Enter number N :");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 1) 
    {
    Console.Write($"{num1} -> 2");   // Двойка будет выводиться на экран при любом числе больше 1
    for (int count = 4; count <= num1; count = count+2) // поэтому счетчик начинается с первого четного после двух
        {
        Console.Write($", {count}"); // все эти пляски для того, чтобы избавиться от запятой после последней цифры
        }
    }
else Console.WriteLine("Введите число больше 1");