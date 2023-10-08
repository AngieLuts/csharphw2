/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
System.Console.WriteLine("Введите номер дня недели");
int day=Convert.ToInt32(Console.ReadLine());
if (day == 6 || day ==7)
{
    System.Console.WriteLine("Поздравляю! Это выходной день!");
}
else if (day > 7)
{
    System.Console.WriteLine("Дней всего 7, попробуйте ввести число от 1 до 7");
}
else
{
    System.Console.WriteLine("К сожалению, это рабочий день :(");
}