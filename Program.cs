﻿/*Напишите программу, которая на вход принимает
 два числа и выдаёт, какое число большее, а какое меньшее*/
Console.Write("Введите первое число: ");
int number1 = int.Parse (Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse (Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}
else if (number2>number1)
{
     Console.WriteLine($"Число {number2} больше числа {number1}");
}
else 
{
     Console.WriteLine($"Числа {number2}  {number1} равны");
}