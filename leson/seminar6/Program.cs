using System.Reflection.Metadata;
// revers massiwa

// int a = 5;
// int b = 6;
// int tnp =a;
//  a=b;
//  b= tmp;

// int[] array = new int[4] { 1, 2, 3, 4 };
// Revers(array);
// PrintArray(array);


// void PrintArray(int[] array)
// {
//     Console.WriteLine(string.Join(",", array));
// }

// void Revers(int[] array)
// {
//     int tmp ;
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         tmp = array[i];
//         array[i]=array[array.Length-1-i];
//         array[array.Length-1-i] = tmp;
//     }
// }


//?????????vtoroi var
// int[] reversed = Revers(array);
// PrintArray(reversed);

// int[] Revers(int[] array)
// {
//     int[] reversed = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         reversed[i] = array[array.Length - 1 - i];

//     }
//     return reversed;
// }


// //__________________________________________________________


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
// 3 -> 11
// 2 -> 10

// int n1 = int.Parse(Console.ReadLine());
// int n2 = int.Parse(Console.ReadLine());
// int n3 = int.Parse(Console.ReadLine());

// GetFalsOrTrue(n1, n2, n3);
// Console.WriteLine(GetFalsOrTrue(n1, n2, n3));

// bool GetFalsOrTrue(int a, int b,int c)
// {
//     if (a < (b + c) & b < (a + c) & c < (b + a))
//     {
//         return true;
//     }
//     return false;
// }
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++=

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
// 3 -> 11
// 2 -> 10


// int number = int.Parse( Console.ReadLine());
// Console.WriteLine(Get2N(number));

// string Get2N(int number){

// string text = "";
// for (int i = 0; 0 < number; i++)
// {
//     text+=number%2 + teext;
//     number /=2;
// }
// return text;
// }


//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

// int number = int.Parse(Console.ReadLine());
// Console.WriteLine(string.Join(",",GetArrayFibonachi(number)));

// int[] GetArrayFibonachi(int number)
// {
//     int[] array = new int[number];
//     if(number>0) array[0] = 0;
//     if(number>1) array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = (array[i - 1]) + (array[i - 2]);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
// Console.WriteLine(string.Join(",", array));
// }
//================================================================
// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.


int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
Console.WriteLine(string.Join(",",GetRandomNumber(array)));

Console.WriteLine(string.Join(",",GetArrayRevens(array)));

int[] GetArrayRevens(int[] array)
{
    int[] arrayCopy= new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

int[] GetRandomNumber(int[] array)
{
    Random randon = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randon.Next(1, 15);
    }return array;
}
