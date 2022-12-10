namespase Task1;

public static class SystemCoordinate
{
    pablic static int GetCoordinate(int n)
    {
        if (n == 1)
        {
            Console.WriteLine(" x>0;y>0");
        }
        if (n == 2)
        {
            Console.WriteLine(" x<0;y>0");
        }
        if (n == 3)
        {
            Console.WriteLine(" x<0;y<0");
        }
        if (n == 4)
        {
            Console.WriteLine(" x>0;y<0");
        }
        return -1;
        
    }
}