
int[] array = CreateRandomArray(12, -9, 9);
PrintArray(array, "Cool Array");

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
// vivod novogo massiva

void PrintArray(int[] array, string message)
{
    string str = string.Join(",", array);
    Console.WriteLine($"{message}[{str}]");
    // Console.WriteLine(string.Join(",",array));

}



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
(int, int) GetSum = SumPisitiveAndNegative(array);
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
}