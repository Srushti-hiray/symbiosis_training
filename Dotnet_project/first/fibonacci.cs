using System;
class fib{
    static void Main(string[] args){
        int a=0;
        int b=1;
        int i,c;
        int num=8;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for(i=2;i<num;i++){
        c=a+b;
        Console.WriteLine(c);
        a=b;
        b=c;
            
        }
        
    }
}