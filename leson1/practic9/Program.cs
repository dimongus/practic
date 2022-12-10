// вывод квадрата числа Н


int num = int.Parse(Console.ReadLine());
int[] arr = GetCalculateTheSquaresOfnumbers(num);

PrintArray(arr);

int[] GetCalculateTheSquaresOfnumbers(int N)
{
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
array[i] = (i+1) * (i+1);
}
return array;
}

void PrintArray(int []array)
{
for (int i = 0; i< array.Length; i++)
{
Console.WriteLine(array[i]);
}
}