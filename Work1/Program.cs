/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int rundomeNumber = new Random ().Next(100,1000);
Console.WriteLine(rundomeNumber);
int numberTwo = (rundomeNumber / 10) % 10;
Console.WriteLine($"{numberTwo}");
