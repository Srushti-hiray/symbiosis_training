using System;

class icecream{
     
    static void Main(string[] args){
        int n,ch,ch1;
        double gst;
        string q;
        int num;
        double amount1,amount2;
        double amount=0.0;
        int vanila=100;
        int mango=100;
        int straw=150;
        int chocolate=200;
        int black=300;

        Console.WriteLine("           Bharkadevi Icecream           ");
        do{
        Console.WriteLine("1: Print menu");
        Console.WriteLine("2: order");
        Console.WriteLine("3: billing");
        Console.WriteLine("4: Quit");
        Console.WriteLine();
        n=Convert.ToInt32(Console.ReadLine());
        
        switch (n){
            case 1:
            Console.WriteLine("Vanila: 100");
            Console.WriteLine("mango: 100");
            Console.WriteLine("straw: 150");
            Console.WriteLine("chocolate: 200");
            Console.WriteLine("Blackberry: 300");
            Console.WriteLine();
            break;
            case 2:

            do{
            Console.WriteLine("Enter the icecream you want:");
            q=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the icecream quantity:");
            num=Convert.ToInt32(Console.ReadLine());

            if(q=="Vanila"){
                amount=amount+(100*num);
                
            }
            else if(q=="mango"){
                amount=amount+(100*num);
                
            }
            else if(q=="straw"){
                amount=amount+(150*num);
                
            }
            else if(q=="chocolate"){
                amount=amount+(200*num);
                
            }
            else if(q=="Blackberry"){
                amount=amount+(300*num);
                
            }
            Console.WriteLine("if you want to order more than enter 1");
            ch=Convert.ToInt32(Console.ReadLine());
            }while(ch==1);

            break;
            case 3:
            Console.WriteLine("---------------Bharkadevi Icecream---------------");
            Console.WriteLine(DateTime.Now);
            
            amount1 =0.08 * amount;
            amount2=amount+amount1;
            Console.WriteLine("Total bill is::"+amount);
            Console.WriteLine();
            Console.WriteLine("Total bill with GST of 8%::"+amount2);
            Console.WriteLine();
            break;
            case 4:
            Console.WriteLine("Quit succesful");
            break;
        }
        Console.WriteLine();
        Console.WriteLine("Thank you for visiting");
        Console.WriteLine("if you want to continue then press 1 else 2");
        ch1=Convert.ToInt32(Console.ReadLine());
        }while(ch1==1);
        }
        
    }
