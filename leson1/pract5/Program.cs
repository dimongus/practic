// Выдает случайное чилсо из отрезка 10,99 и показывает наибольшшее цифру числа
//78-8

Random randon = new Random();

int randomNamber = randon.Next(10, 100);

int lastDigit = randomNamber % 10;

int digit = randomNamber / 10 % 10;

Console.WriteLine(randomNamber);
Console.WriteLine(digit);
Console.WriteLine(lastDigit);


if (lastDigit > digit)
{
    
    Console.WriteLine("vic".lastDigit);
}

else 
{
    Console.WriteLine(digit);
}
