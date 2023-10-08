/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> */
Random rand = new Random();
int initNumber = rand.Next(10, 1000000);
int a = initNumber / 100;
if (a < 1)
{
    System.Console.WriteLine("There is no third digit in a number");
}
else
{
    int result = a % 10;
    System.Console.WriteLine($"{initNumber} -->{result}");
}
System.Console.WriteLine($"Task resolved");
