using System;

class positive{
    public static void Main(string []args){
        int a;
        Console.WriteLine("Enter Number : ");
        a=Convert.ToInt32(Console.ReadLine());
        if(a<0){
            Console.WriteLine(+a +" is negative number");
        }
        else{
            Console.Write(+a +" is positive number");
        }
    }
}