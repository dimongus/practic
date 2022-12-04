//выводит случвйное 3х значное число и удаляет вторую цифру числа


Random random = new Random();
int number = random.Next(100,1000);

Console.WriteLine(number);

int firstDitgit = number / 100;
int lastDitgit = number % 10;
int newDitgit = firstDitgit * 10 + lastDitgit;

Console.WriteLine(newDitgit);
