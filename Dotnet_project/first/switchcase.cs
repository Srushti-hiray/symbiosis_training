using System;
class atm{
    static void Main(string[] args){
        int amount=1000;
        int n,ch,check;
        int with,depo;
        Console.WriteLine("            Welcome to ATM service            ");
        Console.WriteLine("**********************************************");
        Console.WriteLine("Enter pin");
        check=Convert.ToInt32(Console.ReadLine());
        if(check==123)
        {
        do{
        Console.WriteLine("1: check balance");
        Console.WriteLine("2: cash deposite");
        Console.WriteLine("3: cash withdraw");
        Console.WriteLine("4: Quit");
        n=Convert.ToInt32(Console.ReadLine());
        
        switch (n){
            case 1:
            Console.WriteLine("balance is: "+amount);
            break;
            case 2:
            Console.WriteLine("enter amount of deposite:");
            depo=Convert.ToInt32(Console.ReadLine());
            amount=amount+depo;
            break;
            case 3:
            Console.WriteLine("enter amount of withdraw::");
            with=Convert.ToInt32(Console.ReadLine());
            amount=amount-with;
            break;
            case 4:
            Console.WriteLine("Quit succesful");
            break;
        }
        Console.WriteLine("Total amount is:"+amount);
        Console.WriteLine("Thank you for using ATM");
        Console.WriteLine("if you wabt to continue then press 1 else 2");
        ch=Convert.ToInt32(Console.ReadLine());
        }while(ch==1);
        }
        else {
            Console.WriteLine("Enter correct pin");
        }
        

    }
}