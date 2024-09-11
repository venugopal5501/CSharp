using System;

class odd
{
    public static void Main(string[] args)
    {
        int a;

        Console.WriteLine("Enter Number");
        a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.Write(+a + " is even number");

        }
        else if (a < 0)
        {
            Console.Write("Please enter valid number");


        }
        else
        {
            Console.Write(+a + " is odd number");

        }
    }
}