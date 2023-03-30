/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.Clear();
Console.Write("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine());
if (num<10000 || num>99999)
{
    Console.WriteLine("Вы ввели не пятизначное число ");
}
else
{
int num1 = num/10000;
int num2 = num%10;
int num3 = num/1000%10;
int num4 = num/10%10;
if (num1 == num2 && num3 == num4)
{
    Console.WriteLine("Число является палиндромом ");
}
else
{
    Console.WriteLine("Число НЕ является палиндромом ");
}
}