//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456->6 782->2 918->8

Console.WriteLine("ВВедите число");
int num = int.Parse(Console.ReadLine());

if (num < 1000 && num > 99)
{
    int result = num % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Нельзя такое число");
}