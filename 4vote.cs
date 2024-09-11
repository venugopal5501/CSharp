using System;
class vote
{
    static public void Main(string[] a)
    {
        int b;
        Console.WriteLine("Enter Age : ");
        b = Convert.ToInt32(Console.ReadLine());
        if (b >= 18)
        {
            Console.Write("Age " + b + "is eligible to vote");
        }
        else if (b < 0)
        {
            Console.Write("Please enter valid age");
        }
        else
        {
            Console.Write("Age " + b + " is not eligible to vote");
        }

    }
}