using System;

class triangle
{
    public static void Main(string[] args)
    {
        int a, b, c, d;
        Console.Write("Enter value for a : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value for b : ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value for c : ");
        c = Convert.ToInt32(Console.ReadLine());
        d = a + b + c;
        if ((d >= 0) && (d == 180))
        {
            Console.WriteLine("Triangle can be form");
        }
        else
        {
            Console.WriteLine("Triangle can't be form");
        }
    }
}