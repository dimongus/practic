// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


// int number = ReadNumber("ВВедите номер четверти");

// switch (number)

// {
//     case 1:
//         WriteNumber("Диапазон х>0,y>0");
//         break;
//     case 2:
//         WriteNumber("Диапазон х>0,y<0");
//         break;
//     case 3:
//         WriteNumber("Диапазон х<0,y<0");
//         break;
//     case 4:
//         WriteNumber("Диапазон х<0,y>0");
//         break;

// }

// int ReadNumber(string text){
//     Console.WriteLine(text);
//     int number;
//     string readNumber = Console.ReadLine() ?? "Nullable";
//     if (int.TryParse(readNumber, out number)) { }
//     else
//     {
//         Console.WriteLine("Ввод некоректный, введите цифры");
//         number = ReadNumber(text);
//     }
//     return number;
// }

// void WriteNumber(string text){
//     Console.WriteLine(text);
// }


// !second


int quarter = int.Parse(Console.ReadLine());
string result = GetRangeNumberOfQuarter(quarter);
Console.WriteLine(result);

string GetRangeNumberOfQuarter(int numberOfQuarter)

{
    if (numberOfQuarter == 1)
    {
        return "(x >0 && y>0)";
    }
    if (numberOfQuarter == 2)
    {
        return "(x <0 && y>0)";
    }
    if (numberOfQuarter == 3)
    {
        return "(x <0 && y<0)";
    }
    if (numberOfQuarter == 4)
    {
        return "(x >0 && y<0)";
    }
    return "-1";
}