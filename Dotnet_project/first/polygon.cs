using System;
class polygon{
    static void Main(string[]args){
        int n,l,b;
        double a;
        Console.WriteLine("Enter number of side");
        n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter radius");
        b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter lenght of side");
        l=Convert.ToInt32(Console.ReadLine());
        a=((n/2.0)*l*b);
        Console.WriteLine("area is:"+a);
    }

    
}