using System;
class fac{
    static void Main(string[] args){
        int a=5;
        int i;
        int sum=1;
        for(i=a;i>0;i--){
            sum = sum * i;
            
        }
        Console.WriteLine(sum);
    }
}