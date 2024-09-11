using System;
class vowel{
    public static void Main(string []b){
        char a;
        Console.Write("Enter Character : ");
        a=Console.ReadLine()[0];
        if(a=='a'||a=='e'||a=='i'||a=='o'||a=='u'||a=='A'||a=='E'||a=='O'||a=='I'||a=='U'){
            Console.WriteLine(a +" is vowel");
        }
        else{
            Console.WriteLine(a +" is consonant");
        }

    }
}