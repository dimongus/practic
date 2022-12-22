// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Ai,j = i+j. 
//Выведите полученный массив на экран.
// m = 3, n = 4. 0 1 23
// 1 2 34
// 2 3 45

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(m, n);
PrintArray(array);


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// int[,] GetArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }

//     }
//     return array;
// }
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечетные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
// 25 мин


// void Reparir2Array = (int[,] array)
// {
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 != 0 && j % 2 != 0) array[i, j] = array[i, j] * array[i, j];
//         }
//     }
// }   


// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 47 2
// 5 92 3
// 8 42 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// int FinfElements(int[,]array)
// {
//     int sum = 0;
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             if(i==j)sum +=  array[i,j]
//         }
//     }
//     return sum;
// }

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


void GetRevers(int [,] array)
{
    int result;
    for (int i = 0; i < array.GetLength(1); i++)
    {
    
        result= array[0,i];
        array[0,i]= array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = array[0,i] ;
    }
}


//та же задача только с созданием другого массива

int [,]CreateNewArray(int[,]arary)
{
    int[,]newa = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newa[i,j] =array[i,j];
        }
    }
    for (int i = 0; i < newa.GetLength(1); i++)
    {
        newa[0,i]=array[array.GetLength(0)-1,i];
        newa[array.GetLength(0)-1,i]= array[i,j];
    }
    return newa;
}