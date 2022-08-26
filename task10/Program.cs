// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("введите число от 100 до 999");
int n = int.Parse(Console.ReadLine());
if (n < 100)
{
    Console.WriteLine("вы ввели слишком маленькое число");
}
if (n > 999)
{
   Console.WriteLine("вы ввели слишком большое число"); 
}
if (n >100 && n < 999)
{
int a = n % 100;
int b = a / 10;
Console.WriteLine(b);
}
