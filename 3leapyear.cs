using System;

class leap{
    public static void Main(string []args){
        int a;
        Console.Write("Enter Year : ");
        a=Convert.ToInt32(Console.ReadLine());
        if(a%4==0 || a%400==0){
            Console.WriteLine(+a +" is leap year");
        }
        else if(a<0){
            Console.WriteLine("Please enter valid year");
        }
        else{
            Console.WriteLine(+a +" is not a leap year");
        }
    }
}