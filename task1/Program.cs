/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Random rand = new Random();
int initNumber = rand.Next(100, 1000);
int hnum= initNumber/10;
int result = hnum%10;
System.Console.WriteLine($"{initNumber} ==> {result}");
