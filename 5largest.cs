using System;
class large{
    public static void Main(string []args){
        int a,b,c;
        Console.Write("Enter Number 1 : ");
        a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number 2 : ");
        b=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number 3 : ");
        c=Convert.ToInt32(Console.ReadLine());

        if(a>b && a>c){
            Console.WriteLine(+a +" is larger");
        }
        else if(b>a && b>c){
            Console.WriteLine(+b +" is larger");
        }
        else{
            Console.WriteLine(+c +" is larger");
        }
        
    }
}