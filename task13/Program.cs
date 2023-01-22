/*Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).
645 -> 6
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
Console.WriteLine("Введите число A");
int numberA = int.Parse(Console.ReadLine());
int numA = numberA/100;
if (numA>0)
{
    int result =numA%10;
    Console.WriteLine($"Третья цифра {result} ");    
}
else
{
    Console.WriteLine($"Третьей цифры нет"); 
}