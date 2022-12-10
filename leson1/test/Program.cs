int[] parametersX = new int[] { 1, -1, 1, -1, 0 };
int[] parametersY = new int[] { 1, -1, -1, 1, 0 };

int[] expected = new int[] { 1, 3, 4, 2, -1};

for (var i = 0; i < parametersY.Length; i++)
{
int actual = GetNumberOfQuarter(parametersX[i],parametersY[i]);

if(expected[i] == actual)
{
Console.WriteLine("Ok");
}
else{
Console.WriteLine("Bad");
}
}


int GetNumberOfQuarter(int x, int y)
{
if (x > 0 && y > 0)
{
return 1;
}

if (x < 0 && y > 0)
{
return 2;
}

if (x < 0 && y < 0)
{
return 3;
}

if (x > 0 && y < 0)
{
return 4;
}

return -1;
}