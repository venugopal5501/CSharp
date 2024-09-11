using System;
class percent
{
    public static void Main(string[] args)
    {
        int roll, a, b, c, d, e;
        string name;
        Console.WriteLine("Enter Rollnumber: ");
        roll = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter Mark1: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Mark2: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Mark3: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Roll Number : " + roll);
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Tamil : " + a);
        Console.WriteLine("English : " + b);
        Console.WriteLine("Maths : " + c);
        d = a + b + c;
        e = d / 3;
        Console.WriteLine("Total : " + d);
        Console.WriteLine("Total : " + e);
    }
}