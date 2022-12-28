// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int numN = int.Parse(Console.ReadLine());
// Method(numN);

// void Method(int N, int n = 0)
// {
//     n++;

//     if (n > N)
//     {
//         return;
//     }

//     Console.WriteLine($"{n},");
//     Method(n);
// }
//=>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"



// int numN = int.Parse(Console.ReadLine());
// int numNM = int.Parse(Console.ReadLine());
// Method(numN, numNM);
// void Method(int n, int m)
// {
//     if (n > m)
//     {
//         return;
//     }
//     Console.Write($"{n},");
//     n++;
//     Method(n, m);
// }

// ++++++++++++++++++++++++++++++++++++++++++++++=
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 45 -> 9


// int numN = int.Parse(Console.ReadLine());
// Method(numN);

// int Method(int number)
// {
//     int result = 0;
//     if (number > 0)
//     {
//         result += number % 10;
//         number /= 10;
//     }
//     else
//     {
//         return result;
//     }
//     return result + Method(numN);

// }
// =========================================
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8



int numN = int.Parse(Console.ReadLine());
int numM = int.Parse(Console.ReadLine());
Console.WriteLine(Method(numN,numM));

int Method(int number, int stepen)
{
    int result = 1;
    if(stepen>0)
    {
        result*=number;
            stepen--;
    }
    else
    {
        return result;
    }
    return result * Method(number,stepen);
}