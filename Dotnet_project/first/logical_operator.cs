using System;
class logic{
    static void Main(string[] args){
        int a;
        string b;
        string c;
        Console.WriteLine("Enter name");
        c=Console.ReadLine();
        Console.WriteLine("Enter age");
        a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the country");
        b=Console.ReadLine();

        if((b=="india" || b=="India") && a>18 ){
            Console.WriteLine("can do voting");

        }
        else{
            Console.WriteLine("cannot do voting");
        }
    }
}