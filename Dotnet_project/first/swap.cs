using System;

class swap{
    static void Main(string[] args){
        int a,b,c;
        a=Convert.ToInt32(Console.ReadLine());
        b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("a="+a+"b="+b);
        c=a;
        a=b;
        b=c;
        Console.WriteLine("a="+a+"b="+b);

           }
}