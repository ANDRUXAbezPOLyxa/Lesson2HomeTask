// Задача 18. Напишите программу, которая по заданному номеру четверти выдаёт диапазон координат этой четверти
void chetvert(string coor)
{
    Console.WriteLine("диапазон координат для заданной четверти: " + coor);
}
Console.WriteLine("введите номер четверти [1,2,3,4]");
int n = int.Parse(Console.ReadLine());
if (n<1 || n>4)
{
  Console.WriteLine("введите номер четверти [1,2,3,4],другой номер не подходит");  
}
if (n==1)
{
    chetvert("x>0,y>0");
}
if (n==2)
{
    chetvert("x<0,y>0");
}
if (n==3)
{
    chetvert("x<0,y<0");
}
if (n==4)
{
    chetvert("x>0,y<0");
}