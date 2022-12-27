// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// int m;
// int n;
// while (true)
// {



//     Console.WriteLine("vedite m");
//     m = int.Parse(Console.ReadLine());
//     Console.WriteLine("vedite n");
//     n = int.Parse(Console.ReadLine());
//     if (m == n)
//     {
//         break;
//     }
//     Console.WriteLine("more one please");
// }
// int[,] arrayresult = CreateArrayRandom(m, n);
// PrintArray(arrayresult);

// Console.WriteLine();
// int[,] revers = RevversArray(arrayresult);
// PrintArray(revers);

// int[,] CreateArrayRandom(int m, int n)
// {
//     Random random = new Random();
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(-10, 50);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] RevversArray(int[,] array)
// {
//     int[,] result = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result[i, j] = array[j, i];
//         }
//     }
//     return result;
// }

//_________________________________________________________________________

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3 4, 6, 1 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


// Console.WriteLine("m please");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("n please");
// int n = int.Parse(Console.ReadLine());
//  Console.WriteLine("number please");
//     int number = int.Parse(Console.ReadLine());

// int[,] arrayresult = CreateArrayRandom(m, n);
// PrintArray(arrayresult);

//  Console.WriteLine($"{number} mane" + FindElementsArray(arrayresult));

// int[,] CreateArrayRandom(int m, int n)
// {
//     Random random = new Random();
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(1, 5);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int FindElementsArray(int[,] array)
// {

//     int index = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (number == array[i, j])
//                 index++;


//         }

//     }
//     return index;
// }
//========================================================================
//  vtoroi varian reseniya

//  cherez metod slovar

// Console.WriteLine("\n\nКоличество вхождений элементов массива: ");
// PrintDicnionary(GetDictionary(matrix));

// Dictionary<int, int> GetDictionary(int[,] matrix)
// {
// var dictionary = new Dictionary<int, int>();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// if(dictionary.ContainsKey(matrix[i, j]))
// {
// dictionary[matrix[i, j]] = dictionary[matrix[i, j]] + 1;
// } else
// {
// dictionary[matrix[i, j]] = 1;
// }
// }

// return dictionary;
// }

// void PrintDicnionary(Dictionary<int,int> dictionary)
// {
// foreach(var d in dictionary)
// {
// Console.WriteLine($"el: {d.Key} count: {d.Value}");
// }
// }

/* tretiu */


// int m = InputInt("m please");
// int n = InputInt("n please");
// int[,] array = Create2DRandomArray(m, n);
// Prind2DArray(array);
// List<(int number, int frequense)> dictionary = FindFrequence(array);
// Console.WriteLine(string.Join("\n", dictionary));

// List<(int number, int frequense)> FindFrequence(int[,] array)
// {
//     List<(int number, int count)> dictionary = new List<(int, int)>();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int index = FindIndex(dictionary, array[i, j]);
//             if (index != -1)
//             {
//                 dictionary[index] = (array[i, j]),dictionary[index].count + 1;
//             }
//             else
//             {
//                 dictionary.Add((array[i, j], 1));
//             }
//         }

//     }
//     return dictionary;
// }

// int FindIndex(List<(int, int)> list, int number)
// {
//     for (int i = 0; i < list.count; i++)
//     {
//         if (list[i].Item1 == number)
//         {
//             return i;
//         }
//     }
//     return -1;
// }

// =====================================================
//  Задайте двумерный массив из целых чисел. Напишите программу,
//   которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив: 14 72
// 59 23
// 84 24
// 52 67
Console.WriteLine("m please");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("n please");
int n = int.Parse(Console.ReadLine());

PrintArray(array);
Console.WriteLine();
(int row, int column) = GetMinNumber(array);
Console.WriteLine();
PrintArray( GMN0(array, row, column));


int[,] CreateArrayRandom(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 50);
        }
    }
    return array;
}

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


(int row, int column) GetMinNumber(int[,] array)
{
    int min = array[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                row = i;
                column = i;
            }   
        }
    }
    return (row, column);
}

int[,] GMN0(int[,] array, int row, int column)
{
    int resulti = 0;
    int resultj = 0;
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(row==i)
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
       result[resulti,resultj]= array[i,j];
       result++;
        }
        if (row != i){
    
            resulti++;}
            resultj=0;
    }
    return result;
}