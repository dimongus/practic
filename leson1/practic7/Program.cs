//принимает на вход 2 числа и выводит кратное число 
// Если второе число не кратно числу 1 то программа выводит остаток оот деления

// int firstNumber = ReadNumber(" Введите первое число");
// int secondNumber = ReadNumber("Ввкдите второе число");
// Console.WriteLine("первое число" + firstNumber);
// Console.WriteLine("второе число" + secondNumber);

// int ReadNumber(string text){
//     Console.WriteLine(text);
// int number;
// string readNumber = Console.ReadLine();
// if(int.TryParse(readNumber, out number)){}
// else {
//         Console.WriteLine("Введена какаято фигня, попытайтесь еще раз");
//         number = ReadNumber (text);
//     }
// return number;
// }   

// if(firstNumber % secondNumber ==0) {
//     Console.WriteLine("Первое число кратно второму");
// }
// else
// {
//     Console.WriteLine("Первое число не кратно второму. остаток ОТ ДЕЛЕНИЯ" + firstNumber % secondNumber);
// }


Random random = new Random();
int randomN1 = random.Next(10,100);
int randomN2 = random.Next(1,10);

Console.WriteLine(randomN1);
Console.WriteLine(randomN2);

if ((randomN1 % randomN2) ! = 0)
{
    Console.WriteLine(randomN1 % randomN2);

}
else
{
Console.WriteLine("Кратно");
}