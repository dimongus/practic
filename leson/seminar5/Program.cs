
using System.Data.SqlTypes;
// int[] array = CreateRandomArray(12, -9, 9);
// PrintArray(array, "Cool Array");

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     Random random = new Random();
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = random.Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// // vivod novogo massiva

// void PrintArray(int[] array, string message)
// {
//     string str = string.Join(",", array);
//     Console.WriteLine($"{message}[{str}]");
//     // Console.WriteLine(string.Join(",",array));

// }



//ZADAcha+++++++
// int SumPisitive = GetSumOfPositiveNumber(array);
// Console.WriteLine(SumPisitive);
// int SumNegative = GetSumOfNegativeNumber(array);
// Console.WriteLine(SumNegative);

// krasivee kod 2 variant
/* int[] GetSum = SumPisitiveAndNegative(array);
PrintArray(GetSum,"negative+pisitive");

int[] SumPisitiveAndNegative(int[] array)
{
   
} */
//___________________________________________________
// int GetSumOfPositiveNumber(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }

// int GetSumOfNegativeNumber(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }

//_______________________
//3 variaant
/* (int, int) GetSum = SumPisitiveAndNegative(array);
Console.WriteLine(GetSum.Item1);
Console.WriteLine(GetSum.Item2);
(int, int) SumPisitiveAndNegative(int[] array)
{
    int sumPiz = 0;
    int sumNeg = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPiz += array[i];
        }
        else
        {
            sumNeg += array[i];
        }
    }
    return (sumPiz, sumNeg);
} */



//_____________________________________________________
// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
// int[] array = new int[] { -4, -8, 8, 2 };

// Console.WriteLine(string.Join(",",ChangeArray(array)));

// int[] ChangeArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] != 0)
//         {

//    array[i] = array[i] * -1;
//         }
//     }
//     return array;

// }

//_________________________________________________

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] array = new int[] { 6, 7, 19, 345, 3 };
// Console.WriteLine(SearchName(6, array));

// string SearchName(int number, int[] array)    
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return "yes";
//         }
//     }return "no";

// }


//__________________________________________
//  Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

//  int[] array = CreateArray(124);
//  Console.WriteLine(string.Join(",",array));
//  Console.WriteLine(Searchcount(array,10,99));


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 124);
//     }
//     return array;
// }


// int Searchcount(int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= min && array[i] <= max){
//             count++;     
//         }
//     } return count;
// }




//------------------------------------------------------------

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = new int[] { 1, 2, 3, 4, 5 };

PrintArray(array);
PrintArray(QW(array));


int[] QW(int array)
{
    int.num2 = array.Lenght % 2;
    int[marray = new int[array.Lenght / 2 + num2]];
    for (int i = 0; i < array.Length / 2; i++)
    {
        marray[i]=array[i]* array[array.Lenght-1-i];
    
    }
    if(num2!=0)
    {marray[marray.Lenght-1] = array[array.Length/2];}

    return array;
}