// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("введите число");
int n = int.Parse(Console.ReadLine());
if (n < 100)
{
  Console.WriteLine("третьей цифры нет");  
}
if (n >=100 && n <=999)
{
int a = n % 10;
Console.WriteLine(a);
}
if (n>999 && n <=9999)
{
int b = n % 100;
int c = b / 10;
Console.WriteLine(c);
}
if (n>9999 && n <=99999)
{
int b = n % 1000;
int c = b / 100;
Console.WriteLine(c);
}
if (n>99999 && n <=999999)
{
int b = n % 10000;
int c = b / 1000;
Console.WriteLine(c);
}