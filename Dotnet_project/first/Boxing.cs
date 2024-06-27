using System;
class boxing{
    static void Main(string[] args){
        int num=20;
        object obj =num;
        string myString = num.ToString();
        
        myString="akshada";
        Console.WriteLine(myString);
        
        Console.WriteLine(obj);
    }
}