/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.WriteLine("Введите цифру соответствующую дню недели");
int numberA = int.Parse(Console.ReadLine());
if (numberA<=7&numberA>0)
{
  if (numberA!=6&numberA!=7)
  {
    Console.WriteLine("Рабочий ");
  }
  else
  {
    Console.WriteLine("Выходной ");
  }
}
else
{
  Console.WriteLine("Такого дня недели нет ");
  
}