using System;
class swa{
    static void Main(string[] args){
        int a=8;
        int b=6;
        Console.WriteLine("before swapping");
        Console.WriteLine(a);
        Console.WriteLine(b);
        a=a+b;
        b=a-b;
        a=a-b;
        Console.WriteLine("after swapping");
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}